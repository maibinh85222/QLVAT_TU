using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FrmPhieuNhap : Form
    {
        int vitri = 0;
        string macn = "";
        public FrmPhieuNhap()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phieuNhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDS);

        }

        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            this.v_LAYMAVTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_LAYMAVTTableAdapter.Fill(this.dSMVT.V_LAYMAVT);
            this.v_DSMADHCHUANHAPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DSMADHCHUANHAPTableAdapter.Fill(this.dSDH.V_DSMADHCHUANHAP);
            this.sP_LAYMAKHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYMAKHOTableAdapter.Fill(this.dSMK.SP_LAYMAKHO);
            this.cTPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPhieuNhapTableAdapter.Fill(this.qLVTDS.CTPhieuNhap);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDS.PhieuNhap);
            macn = ((DataRowView)phieuNhapBindingSource[0])["MaPN"].ToString();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;  // bật tắt theo phân quyền
                btnThemPN.Enabled = btnXoaPN.Enabled = btnRefresh.Enabled = groupBox.Enabled =
                     btnThemCTPN.Enabled = btnXoaCTPN.Enabled = groupBox.Enabled = groupBoxCT.Enabled = false;

            }
            else
            {
                cmbChinhanh.Enabled = groupBox.Enabled = groupBoxCT.Enabled = false;
                btnThemPN.Enabled = btnXoaPN.Enabled = btnRefresh.Enabled = btnXoaPN.Enabled = btnThemCTPN.Enabled
                    = true;
            }
            btnThoat.Enabled = true;
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChinhanh.SelectedValue == null) return;
            if (cmbChinhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChinhanh.SelectedValue.ToString();

            if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.qLVTDS.PhieuNhap);
                this.cTPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTPhieuNhapTableAdapter.Fill(this.qLVTDS.CTPhieuNhap);
            }
        }

        private void btnThemPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            phieuNhapBindingSource.AddNew();
            groupBox.Enabled = true;
            txtNgay.DateTime = DateTime.Now;
            //string temp = DateTime.Now.ToString("d");
            txtNgay.Enabled = false;
            txtMaNV.Text = Program.username;

            SqlDataReader myReader1;
            String strlenh1 = "EXEC SP_MADHCHUACOPN";
            myReader1 = Program.ExecSqlDataReader(strlenh1);
            if (myReader1 == null) return;
            myReader1.Close();
            
            txtMaNV.Enabled = btnThemPN.Enabled = btnXoaPN.Enabled = btnThemCTPN.Enabled = btnXoaCTPN.Enabled =
            cTPhieuNhapGridControl.Enabled = groupBoxCT.Enabled = phieuNhapGridControl.Enabled = false;

            btnOK.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnXoaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemPN.Enabled = phieuNhapGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa phiếu nhập.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaPhieuNhap] " +
                        "@MaPN = N'" + txtMaPN.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Phiếu nhập đã tồn tại trong chi tiết phiếu nhập. Không thể xóa.");
                    return;
                }
                else
                {
                    groupBox.Enabled = false;
                    phieuNhapBindingSource.RemoveCurrent();
                    phieuNhapBindingSource.EndEdit();
                    this.phieuNhapTableAdapter.Update(this.qLVTDS.PhieuNhap);
                }
            }
            else
            {
                btnThemPN.Enabled = btnXoaPN.Enabled = true;

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.phieuNhapTableAdapter.Fill(this.qLVTDS.PhieuNhap);
            this.cTPhieuNhapTableAdapter.Fill(this.qLVTDS.CTPhieuNhap);
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemPN.Enabled = btnXoaPN.Enabled = btnThemCTPN.Enabled = btnXoaCTPN.Enabled = phieuNhapGridControl.Enabled = cTPhieuNhapGridControl.Enabled = true;
        }

        private void btnThemCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cTPhieuNhapBindingSource.AddNew();

            SqlDataReader myReader;
            String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_MAVTDADH] " +
            "@MaPN = N'" + txtMaPN.Text + "', " + " @MaDDH = N'" + txtMaDDH.Text + "' SELECT  'Return Value' = @return_value";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Close();

            groupBoxCT.Enabled = true;
            txtMaCTPN.Text = txtMaPN.Text;
            txtMaPN.Enabled = btnThemCTPN.Enabled = phieuNhapGridControl.Enabled = cTPhieuNhapGridControl.Enabled
                = btnThemPN.Enabled = btnXoaPN.Enabled = btnXoaCTPN.Enabled = false;
            btnOKCT.Visible = true;
            btnHuyCT.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text.Trim() == "")
            {
                MessageBox.Show("Mã phiếu nhập không được để trống!");
                txtMaPN.Focus();
            }
            else if (txtMaDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đơn đặt hàng không được để trống!");
                txtMaDDH.Focus();
            }
            else if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!");
                txtMaKho.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaPhieuNhap] " +
                        "@MaPN = N'" + txtMaPN.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại.Nhập lại.");
                    txtMaPN.Focus();
                }
                else
                {
                    phieuNhapBindingSource.EndEdit();
                    MessageBox.Show("Thêm phiếu nhập thành công!");
                    phieuNhapBindingSource.ResetCurrentItem();
                    this.phieuNhapTableAdapter.Update(this.qLVTDS.PhieuNhap);

                    btnOK.Visible = btnHuy.Visible = false;
                    groupBox.Enabled = groupBoxCT.Enabled = false;
                    btnThemPN.Enabled = btnXoaPN.Enabled = phieuNhapGridControl.Enabled =
                        cTPhieuNhapGridControl.Enabled = btnThemCTPN.Enabled = btnXoaCTPN.Enabled = true;
                    //txtMaDDH.Items.Clear();
                    //txtMaDDH.SelectedItem = 0;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.phieuNhapBindingSource.EndEdit();
            phieuNhapBindingSource.RemoveCurrent();
            btnOK.Visible = btnHuy.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemPN.Enabled = btnXoaPN.Enabled = cTPhieuNhapGridControl.Enabled = btnThemCTPN.Enabled =
                phieuNhapGridControl.Enabled = btnXoaCTPN.Enabled = true;
        }

        private void btnOKCT_Click(object sender, EventArgs e)
        {
            //string temp = txtSL.Text;
            if (txtMaCTMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã mặt hàng không được để trống!");
                txtMaCTMH.Focus();
            }
            else if (txtSL.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                txtSL.Focus();
            }
            else if (txtDG.Text.Trim() == "" )
            {
                MessageBox.Show("Đơn giá không được để trống!");
                txtDG.Focus();
            }
            else if (int.Parse(txtDG.Text) <= 500)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 500!");
                txtDG.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaCTPN] " +
            "@MaPN = N'" + txtMaCTPN.Text + "', " + " @MaMH = N'" + txtMaCTMH.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);

                if (myReader == null) return;

                myReader.Read();
                int value1 = myReader.GetInt32(0);

                myReader.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết phiếu nhập đã tồn tại.Nhập lại.");
                    txtMaPN.Focus();
                }
                else
                {
                    //dS.EnforceConstraints = false;
                    cTPhieuNhapBindingSource.EndEdit();
                    MessageBox.Show("Thêm chi tiết phiếu nhập thành công!");
                    cTPhieuNhapBindingSource.ResetCurrentItem();
                    this.cTPhieuNhapTableAdapter.Update(this.qLVTDS.CTPhieuNhap);
                    btnOKCT.Visible = btnHuyCT.Visible = false;
                    groupBox.Enabled = groupBoxCT.Enabled = btnThemPN.Enabled = btnXoaPN.Enabled = false;
                    phieuNhapGridControl.Enabled = btnThemCTPN.Enabled = btnXoaCTPN.Enabled 
                    = cTPhieuNhapGridControl.Enabled = btnThemPN.Enabled = btnXoaPN.Enabled = true;


                    //this.cTPhieuNhapTableAdapter.Fill(this.qLVTDS.CTPhieuNhap);

                    //txtMaMHCT.Items.Clear();

                    //txtMaCTMH.SelectedItem = 0;
                }

            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            this.cTPhieuNhapBindingSource.EndEdit();
            cTPhieuNhapBindingSource.RemoveCurrent();
            btnOKCT.Visible = btnHuyCT.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemPN.Enabled = btnXoaPN.Enabled = btnXoaCTPN.Enabled =
            btnThemCTPN.Enabled = phieuNhapGridControl.Enabled = cTPhieuNhapGridControl.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoaCTPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemCTPN.Enabled = cTPhieuNhapGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa phiếu nhập.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                    groupBox.Enabled = false;
                    cTPhieuNhapBindingSource.RemoveCurrent();
                    cTPhieuNhapBindingSource.EndEdit();
                    this.cTPhieuNhapTableAdapter.Update(this.qLVTDS.CTPhieuNhap);
               
            }
            else
            {
                btnThemCTPN.Enabled = btnXoaCTPN.Enabled = true;

            }
        }

        private void txtMaCTPN_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

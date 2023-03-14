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
    public partial class FrmHoaDon : Form
    {
        string macn = "";
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void hoaDonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hoaDonBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDS);

        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            this.v_LAYMAVTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_LAYMAVTTableAdapter.Fill(this.dSMVT.V_LAYMAVT);
            this.sP_LAYMAKHOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_LAYMAKHOTableAdapter.Fill(this.dSMK.SP_LAYMAKHO);
            this.v_LAYMAKHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_LAYMAKHTableAdapter.Fill(this.dSKH.V_LAYMAKH);
            this.cTHoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTHoaDonTableAdapter.Fill(this.qLVTDS.CTHoaDon);
            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.qLVTDS.HoaDon);
            macn = ((DataRowView)hoaDonBindingSource[0])["MaHD"].ToString();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;  // bật tắt theo phân quyền
                btnThemHD.Enabled = btnXoaHD.Enabled = btnReload.Enabled = btnXoaCTHD.Enabled
                    = groupBox.Enabled = groupBoxCT.Enabled = btnThemCTHD.Enabled = false;

            }
            else
            {
                cmbChinhanh.Enabled = groupBox.Enabled = groupBoxCT.Enabled = false;
                btnThemHD.Enabled = btnXoaHD.Enabled = btnReload.Enabled = btnXoaHD.Enabled
                    = btnThemCTHD.Enabled = true;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                this.hoaDonTableAdapter.Fill(this.qLVTDS.HoaDon);
                this.cTHoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTHoaDonTableAdapter.Fill(this.qLVTDS.CTHoaDon);
            }
        }

        private void btnThemHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            hoaDonBindingSource.AddNew();
            groupBox.Enabled = true;
            txtNgay.DateTime = DateTime.Now;
            //string temp = DateTime.Now.ToString("d");
            txtNgay.Enabled = false;
            txtMaNV.Text = Program.username;

            txtMaNV.Enabled = btnThemHD.Enabled = btnXoaHD.Enabled = btnThemCTHD.Enabled = btnXoaCTHD.Enabled =
            hoaDonGridControl.Enabled = cTHoaDonGridControl.Enabled = groupBoxCT.Enabled = false;

            btnOK.Visible = true;
            btnHuy.Visible = true;
        }

        private void btnXoaHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemHD.Enabled = hoaDonGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa hoá đơn.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaHoaDon] " +
                        "@MAHD = N'" + txtMaHD.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Hoá đơn đã tồn tại trong chi tiết hoá đơn. Không thể xóa.");
                    return;
                }
                else
                {
                    groupBox.Enabled = false;
                    hoaDonBindingSource.RemoveCurrent();
                    hoaDonBindingSource.EndEdit();
                    this.hoaDonTableAdapter.Update(this.qLVTDS.HoaDon);
                }
            }
            else
            {
                btnThemHD.Enabled = btnXoaHD.Enabled = true;

            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.hoaDonTableAdapter.Fill(this.qLVTDS.HoaDon);
            this.cTHoaDonTableAdapter.Fill(this.qLVTDS.CTHoaDon);
            groupBox.Enabled = groupBoxCT.Enabled = false;
            hoaDonGridControl.Enabled = cTHoaDonGridControl.Enabled = btnThemHD.Enabled
             = btnXoaCTHD.Enabled = btnThemCTHD.Enabled = btnXoaHD.Enabled = true;
        }

        private void btnThemCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cTHoaDonBindingSource.AddNew();
            txtMaHDCT.Text = txtMaHD.Text;
            txtMaHDCT.Enabled = btnThemCTHD.Enabled = btnXoaCTHD.Enabled = btnThemHD.Enabled = 
               groupBox.Enabled = btnXoaHD.Enabled = hoaDonGridControl.Enabled = false;
            btnOKCT.Visible = true;
            btnHuyCT.Visible = true;
            groupBoxCT.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text.Trim() == "")
            {
                MessageBox.Show("Mã hoá đơn không được để trống!");
                txtMaHD.Focus();
            }
            else if (txtMaKH.Text.Trim() == "")
            {
                MessageBox.Show("Mã khách hàng không được để trống!");
                txtMaKH.Focus();
            }

            else if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!");
                txtMaNV.Focus();
            }
            else if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!");
                txtMaKho.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaHoaDon] " +
                        "@MAHD = N'" + txtMaHD.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã hoá đơn đã tồn tại.Nhập lại.");
                    txtMaHD.Focus();
                }
                else
                {
                    hoaDonBindingSource.EndEdit();
                    MessageBox.Show("Thêm hoá đơn thành công!");
                    hoaDonBindingSource.ResetCurrentItem();
                    this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.hoaDonTableAdapter.Update(this.qLVTDS.HoaDon);
                    btnOK.Visible = btnHuy.Visible = false;
                    groupBox.Enabled = groupBoxCT.Enabled = false;
                    btnThemHD.Enabled = btnXoaHD.Enabled = hoaDonGridControl.Enabled =
                        cTHoaDonGridControl.Enabled = true;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.hoaDonBindingSource.EndEdit();
            hoaDonBindingSource.RemoveCurrent();
            btnOK.Visible = btnHuy.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemHD.Enabled = btnXoaHD.Enabled = cTHoaDonGridControl.Enabled = hoaDonGridControl.Enabled = true;
        }

        private void btnOKCT_Click(object sender, EventArgs e)
        {
            if (txtMaMHCT.Text.Trim() == "")
            {
                MessageBox.Show("Mã mặt hàng không được để trống!");
            }
            else if (txtSL.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0!");
                txtSL.Focus();
            }
            else if (txtDG.Value <= 500)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 500!");
                txtDG.Focus();

            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaCTHD] " +
            "@MAHD = N'" + txtMaHD.Text + "', " + " @MAMH = N'" + txtMaMHCT.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh);

                if (myReader == null) return;

                myReader.Read();
                int value1 = myReader.GetInt32(0);

                myReader.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết hoá đơn đã tồn tại.Nhập lại.");
                    txtMaHD.Focus();
                }
                else
                {
                    cTHoaDonBindingSource.EndEdit();
                    MessageBox.Show("Thêm chi tiết hoá đơn thành công!");
                    cTHoaDonBindingSource.ResetCurrentItem();
                    this.cTHoaDonTableAdapter.Update(this.qLVTDS.CTHoaDon);
                    btnOKCT.Visible = btnHuyCT.Visible = false;
                    groupBox.Enabled = groupBoxCT.Enabled = false;
                    hoaDonGridControl.Enabled = btnThemCTHD.Enabled = true;
                }
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            this.cTHoaDonBindingSource.EndEdit();
            cTHoaDonBindingSource.RemoveCurrent();
            btnOKCT.Visible = btnHuyCT.Visible = false;
            groupBox.Enabled = groupBoxCT.Enabled = false;
            btnThemCTHD.Enabled = cTHoaDonGridControl.Enabled = hoaDonGridControl.Enabled = true;
        }

        private void btnXoaCTHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemHD.Enabled = hoaDonGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa hoá đơn.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                
                groupBox.Enabled = false;
                cTHoaDonBindingSource.RemoveCurrent();
                cTHoaDonBindingSource.EndEdit();
                this.cTHoaDonTableAdapter.Update(this.qLVTDS.CTHoaDon);
            }
            else
            {
                btnThemCTHD.Enabled = btnXoaCTHD.Enabled = true;

            }
        }
    }
}

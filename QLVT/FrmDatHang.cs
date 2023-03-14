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
    public partial class FrmDatHang : Form
    {
        string macn = "";
        int clicksua = 0;
        int vitri = 0;
        public FrmDatHang()
        {
            InitializeComponent();
        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.datHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLVTDS);

        }

        private void FrmDatHang_Load(object sender, EventArgs e)
        {

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.qLVTDS.DatHang);

            this.cTDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDatHangTableAdapter.Fill(this.qLVTDS.CTDatHang);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.qLVTDS.PhieuNhap);
            this.nhaCCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhaCCTableAdapter.Fill(this.qLVTDS.NhaCC);
            this.v_LAYMAVTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_LAYMAVTTableAdapter.Fill(this.dSMVT.V_LAYMAVT);
            macn = ((DataRowView)datHangBindingSource[0])["MaDDH"].ToString();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;  // bật tắt theo phân quyền
                btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThemCTDDH.Enabled
                    = btnXoaCTDDH.Enabled = groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;

            }
            else
            {
                cmbChinhanh.Enabled = groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
            }
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
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.qLVTDS.DatHang);
                this.cTDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.cTDatHangTableAdapter.Fill(this.qLVTDS.CTDatHang);
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = datHangBindingSource.Position;
            datHangBindingSource.AddNew();
            groupBoxDH.Enabled = true;
            txtNgay.DateTime = DateTime.Now;
            //string temp = DateTime.Now.ToString("d");
            txtNgay.Enabled = false;
            txtMaNV.Text = Program.username;

            txtMaNV.Enabled = btnThem.Enabled = btnXoa.Enabled = btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled =
            cTDatHangGridControl.Enabled = groupBoxCTDH.Enabled = false;

            btnOK.Visible = btnRefresh.Enabled = btnUndo.Enabled = true;
            btnHuy.Visible = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnRefresh.Enabled = btnThoat.Enabled =
              datHangGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa đặt hàng.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaDonDatHang] " +
                        "@MaDDH = N'" + txtMaDDH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Đơn đặt hàng đã tồn tại trong chi tiết đơn đặt hàng. Không thể xóa.");
                    return;
                }
                else
                {
                    groupBoxDH.Enabled = false;
                    datHangBindingSource.RemoveCurrent();
                    datHangBindingSource.EndEdit();
                    this.datHangTableAdapter.Update(this.qLVTDS.DatHang);
                }
            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;

            }
        }

        private void btnThemCTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cTDatHangBindingSource.AddNew();
            groupBoxCTDH.Enabled = true;
            txtMaCTDDH.Text = txtMaDDH.Text;
            txtMaCTDDH.Enabled = btnThem.Enabled = btnXoa.Enabled = btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled = btnRefresh.Enabled = datHangGridControl.Enabled = groupBoxDH.Enabled = false;
            btnOkCT.Visible = true;
            btnHuyCT.Visible = true;
        }

        private void btnXoaCTDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled = btnRefresh.Enabled = cTDatHangGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa chi tiết đơn đặt hàng.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaChiTietDonDatHang] " +
                        "@MADDH = N'" + txtMaDDH.Text + "', " +
                        "@MAVT = N'" + txtMaCTMH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết đơn đặt hàng đã tồn tại trong chi tiết phiếu nhập. Không thể xóa.");
                    return;
                }
                else
                {
                    groupBoxCTDH.Enabled = false;
                    cTDatHangBindingSource.RemoveCurrent();
                    cTDatHangBindingSource.EndEdit();
                    this.cTDatHangTableAdapter.Update(this.qLVTDS.CTDatHang);
                }
            }
            else
            {
                btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled = btnRefresh.Enabled = true;

            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.datHangTableAdapter.Fill(this.qLVTDS.DatHang);
            this.cTDatHangTableAdapter.Fill(this.qLVTDS.CTDatHang);
            groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
            btnOkCT.Visible = btnHuyCT.Visible = false;
            datHangGridControl.Enabled = cTDatHangGridControl.Enabled = btnThem.Enabled
                = btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            datHangBindingSource.CancelEdit();
            if (btnThemCTDDH.Enabled == false) datHangBindingSource.Position = vitri;
            datHangGridControl.Enabled = true;
            groupBoxDH.Enabled = false;
            btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnOK.Visible = btnUndo.Enabled = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMaDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đặt hàng không được để trống!");
                txtMaDDH.Focus();
            }
            else if (txtMaNCC.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhà cung cấp không được để trống!");
                txtMaNCC.Focus();
            }
            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaDatHang] " +
                        "@MaDDH = N'" + txtMaDDH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã đặt hàng đã tồn tại. Nhập lại.");
                    txtMaDDH.Focus();
                }
                else
                {
                    datHangBindingSource.EndEdit();
                    MessageBox.Show("Thêm đơn đặt hàng thành công!");
                    datHangBindingSource.ResetCurrentItem();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.datHangTableAdapter.Update(this.qLVTDS.DatHang);
                    //groupBoxbtnCTDH.Visible = false;
                    btnOK.Visible = btnHuy.Visible = false;
                    groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
                    btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThemCTDDH.Enabled
                         = btnXoaCTDDH.Enabled = cTDatHangGridControl.Enabled = datHangGridControl.Enabled = true;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.datHangBindingSource.EndEdit();
            datHangBindingSource.RemoveCurrent();
            btnOK.Visible = btnHuy.Visible = false;
            groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnRefresh.Enabled
             = cTDatHangGridControl.Enabled = true;
        }

        private void btnOkCT_Click(object sender, EventArgs e)
        {
            if (txtMaCTDDH.Text.Trim() == "")
            {
                MessageBox.Show("Mã đặt hàng không được để trống!");
                txtMaCTDDH.Focus();
            }
            else if (txtMaCTMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã vật tư không được để trống!");
                txtMaCTMH.Focus();
            }
            else if (txtSLDH.Text.Trim() == "")
            {
                MessageBox.Show("Số lượng không được để trống!");
                txtSLDH.Focus();

            }
            else if (txtDGDH.Text.Trim() == "")
            {
                MessageBox.Show("Đơn giá không được để trống!");
                txtDGDH.Focus();

            }

            else
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaCTDDH] " +
            "@MADDH = N'" + txtMaDDH.Text + "', " + " @MAVT = N'" + txtMaCTMH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Chi tiết đặt hàng đã tồn tại. Nhập lại.");
                    txtMaDDH.Focus();
                }
                else
                {
                    try
                    {
                        cTDatHangBindingSource.EndEdit();
                        MessageBox.Show("Thêm chi tiết đặt hàng thành công");
                        cTDatHangBindingSource.ResetCurrentItem();
                        //this.cTDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.cTDatHangTableAdapter.Update(this.qLVTDS.CTDatHang);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    btnOkCT.Visible = btnHuyCT.Visible = false;
                    groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
                    btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled = btnRefresh.Enabled = 
                        btnThem.Enabled = btnXoa.Enabled = cTDatHangGridControl.Enabled = datHangGridControl.Enabled = true;
                }
            }
        }

        private void btnHuyCT_Click(object sender, EventArgs e)
        {
            this.cTDatHangBindingSource.EndEdit();
            cTDatHangBindingSource.RemoveCurrent();
            btnOkCT.Visible = btnHuyCT.Visible = false;
            groupBoxDH.Enabled = groupBoxCTDH.Enabled = false;
            btnThemCTDDH.Enabled = btnXoaCTDDH.Enabled = btnRefresh.Enabled = true;
            datHangGridControl.Enabled = cTDatHangGridControl.Enabled = true;
        }

        private void groupBoxCTDH_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}

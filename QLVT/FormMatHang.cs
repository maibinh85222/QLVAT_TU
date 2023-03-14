using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace QLVT
{
    public partial class FormMatHang : Form
    {
        int vitri = 0;
        string macn = "";
        bool clicksua = false;
        public FormMatHang()
        {
            InitializeComponent();
        }

        private void matHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        public void Fill()
        {
            this.matHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.matHangTableAdapter.Fill(this.dS.MatHang);
            this.cTDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTDatHangTableAdapter.Fill(this.dS.CTDatHang);
            this.cTHoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTHoaDonTableAdapter.Fill(this.dS.CTHoaDon);
            this.cTPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.cTPhieuNhapTableAdapter.Fill(this.dS.CTPhieuNhap);
        }
        public void ShowAll()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled
                    = btnReload.Enabled = btnThoat.Enabled = matHangGridControl.Enabled = true;
            groupBox1.Enabled = false;
        }
        private void FormMatHang_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            Fill();
            if (Program.mGroup == "CONGTY")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = false;
                btnThoat.Enabled = btnReload.Enabled = true;
            }
            //else if (Program.mGroup == "CHINHANH")
            //{
            //    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            //    btnThoat.Enabled = btnReload.Enabled = true;
            //    btnGhi.Enabled = false;
            //}
            else
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnThoat.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            groupBox1.Enabled = true;
            bdsMH.AddNew();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = matHangGridControl.Enabled
                    = btnReload.Enabled = false;
            btnGhi.Enabled = true;
            txtDVT.Text = "cái";
            clicksua = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = matHangGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            txtMaLH.Enabled = false;
            txtMaMH.Enabled = false;
            matHangGridControl.Enabled = false;
            clicksua = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled =
               btnThoat.Enabled = btnReload.Enabled =
               matHangGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa vật tư.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaMH] " +
                        "@MAMH = N'" + txtMaMH.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã mặt hàng đã tồn tại trong chi tiết phiếu nhập, hoá đơn hay đơn đặt hàng. Không thể xóa!");
                    return;
                }
                else
                {
                    groupBox1.Enabled = false;
                    bdsMH.RemoveCurrent();
                    bdsMH.EndEdit();
                    this.matHangTableAdapter.Update(this.dS.MatHang);
                }
            }
            else
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled
                    = btnReload.Enabled = true;
            }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã mặt hàng không được để trống!");
                txtMaMH.Focus();
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên mặt hàng không được để trống!");
                txtTen.Focus();
            }
            else if (txtDVT.Text.Trim() == "")
            {
                MessageBox.Show("Đơn vị tính không được để trống!");
                txtDVT.Focus();
            }
            else
            {
               if(clicksua == false)
                {
                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaMH] " +
                            "@MAMH = N'" + txtMaMH.Text + "' SELECT  'Return Value' = @return_value";
                    myReader1 = Program.ExecSqlDataReader(strlenh1);

                    if (myReader1 == null) return;

                    myReader1.Read();
                    int value1 = myReader1.GetInt32(0);

                    myReader1.Close();
                    if (value1 == 1)
                    {
                        MessageBox.Show("Mã mặt hàng đã tồn tại. Nhập lại.");
                        txtMaMH.Focus();
                    }
                    else
                    {
                        bdsMH.EndEdit();
                        MessageBox.Show("Thêm mặt hàng thành công!");
                        bdsMH.ResetCurrentItem();
                        this.matHangTableAdapter.Update(this.dS.MatHang);
                        ShowAll();
                    }
                }
               else
                {
                    this.bdsMH.EndEdit();
                    MessageBox.Show("Sửa mặt hàng thành công!");
                    bdsMH.ResetCurrentItem();
                    this.matHangTableAdapter.Update(this.dS.MatHang);
                    ShowAll();
                }
            }
            

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.CancelEdit();
            if (btnThem.Enabled == false) bdsMH.Position = vitri;
            matHangGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.matHangTableAdapter.Fill(this.dS.MatHang);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void matHangGridControl_Click(object sender, EventArgs e)
        {
        }
    }
}

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
    public partial class FormKho : Form
    {
        private SqlDataReader myReader = null;
        bool flag=true;
        String lenh = "";
        String maCN = "";
        Stack UNDO = new Stack();
        public string maKho;
        public string tenKho;
        public string diaChi;
        int vitri = 0;
        String macn = "";
        bool clicksua = false;
        public FormKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void enableForm()
        {

            txtMaKho.Text = "";
            txtDiaChi.Text = "";
            txtTenKho.Text = "";
            btnGhi.Enabled = false;
            txtMaKho.Enabled = false;
            txtDiaChi.Enabled = false;
            txtTenKho.Enabled = false;
            btnUndo.Enabled = true;
            if (UNDO.Count == 0)
            {
                btnUndo.Enabled = false;
            }
        }
        private void Fill()
        {
            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dS.Kho);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.dS.HoaDon);
        }
        public void ShowAll()
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled
                    = btnReload.Enabled = btnThoat.Enabled = true;
            khoGridControl.Enabled = true;
            groupBox1.Enabled = false;
        }
        private void FormKho_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            Fill();
            this.v_DS_PHANMANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_PHANMANHTableAdapter.Fill(this.qLVTDataSet.V_DS_PHANMANH);
            macn = ((DataRowView)bdsKho[0])["MaCN"].ToString();
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CONGTY")
            {
                cmbChinhanh.Enabled = true;  // bật tắt theo phân quyền
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnGhi.Enabled = false;
                btnThoat.Enabled = btnReload.Enabled = true;
            }
            //else if (Program.mGroup == "CHINHANH")
            //{
            //    cmbChinhanh.Enabled = false;  // bật tắt theo phân quyền
            //    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            //    btnThoat.Enabled = btnReload.Enabled = true;
            //    btnGhi.Enabled = false;
            //}
            else
            {
                cmbChinhanh.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnThoat.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = false;
            }
            txtMaCN.Enabled = false;
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
                Fill();
                macn = ((DataRowView)bdsKho[0])["MaCN"].ToString();
            }
        }

        private void khoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            bdsKho.AddNew();
            groupBox1.Enabled = true;
            txtMaCN.Text = macn;
            
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = khoGridControl.Enabled
                    = btnReload.Enabled = false;
            btnGhi.Enabled = true;
            clicksua = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsKho.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = khoGridControl.Enabled = false;
            btnGhi.Enabled = true;
            txtMaKho.Enabled = txtMaCN.Enabled = false;
            khoGridControl.Enabled = false;
            clicksua = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaKho.Text.Trim() == "")
            {
                MessageBox.Show("Mã kho không được để trống!");
                txtMaKho.Focus();
            }
            else if (txtTenKho.Text.Trim() == "")
            {
                MessageBox.Show("Tên kho không được để trống!");
                txtTenKho.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ kho không được để trống!");
                txtDiaChi.Focus();
            }
            else
            {
               if(clicksua == false)
                {
                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaKho]" +
                            "@MaKho = N'" + txtMaKho.Text + "' SELECT  'Return Value' = @return_value";
                    myReader1 = Program.ExecSqlDataReader(strlenh1);

                    if (myReader1 == null) return;

                    myReader1.Read();
                    int value1 = myReader1.GetInt32(0);

                    myReader1.Close();
                    if (value1 == 1)
                    {
                        MessageBox.Show("Mã kho đã tồn tại. Nhập lại.");
                        txtMaKho.Focus();
                    }
                    else
                    {
                        bdsKho.EndEdit();
                        MessageBox.Show("Thêm kho thành công!");
                        bdsKho.ResetCurrentItem();
                        this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.khoTableAdapter.Update(this.dS.Kho);
                        ShowAll();
                    }
                }
               else
                {
                    this.bdsKho.EndEdit();
                    MessageBox.Show("Sửa kho thành công!");
                    bdsKho.ResetCurrentItem();
                    this.khoTableAdapter.Update(this.dS.Kho);
                    ShowAll();
                }
            }
            
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled =
               btnThoat.Enabled = btnReload.Enabled =
               khoGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa kho.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaKho] " +
                        "@MAKHO = N'" + txtMaKho.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã kho đã tồn tại trong phiếu nhập hoặc hoá đơn. Không thể xóa.");
                    return;
                }
                else
                {
                    groupBox1.Enabled = false;
                    bdsKho.RemoveCurrent();
                    bdsKho.EndEdit();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.dS.Kho);
                }
            }
            else
            {
                ShowAll();
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsKho.CancelEdit();
            if (btnThem.Enabled == false) bdsKho.Position = vitri;
            khoGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dS.Kho);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void khoGridControl_Click(object sender, EventArgs e)
        {
            
        }
    }
}

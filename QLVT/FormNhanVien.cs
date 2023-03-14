using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Collections;

namespace QLVT
{
    public partial class FormNhanVien : Form
    {
        
        int vitri = 0;
        string Macn = "";
        string macn = "";
        bool clicksua = false;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public void ShowAll()
        {
            btnGhi.Enabled = btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled =
                btnThoat.Enabled = btnCCN.Enabled =  btnReload.Enabled =
                nhanVienGridControl.Enabled = true;
            groupBox1.Enabled = false;
        }
        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private void Fill()
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
            this.hoaDonTableAdapter.Connection.ConnectionString = Program.connstr;
            this.hoaDonTableAdapter.Fill(this.dS.HoaDon);
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dS.PhieuNhap);
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dS.DatHang);
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
           
            dS.EnforceConstraints = false;
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            Fill();
            macn = ((DataRowView)bdsNV[0])["MaCN"].ToString();
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
            else 
            {
                cmbChinhanh.Enabled = false;  // bật tắt theo phân quyền
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
                btnThoat.Enabled = btnReload.Enabled = true;
                btnGhi.Enabled = false;
            }
            txtMaCN.Enabled = false;
            if(Program.mGroup == "USER")
            {
                btnTTK.Enabled = false;
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
                Fill();
                macn = ((DataRowView)bdsNV[0])["MaCN"].ToString();
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            bdsNV.AddNew();
            txtMaCN.Text = macn;
            txtTrangThaiXoa.EditValue = "0";
            btnThem.Enabled = btnCCN.Enabled = btnXoa.Enabled = btnSua.Enabled = btnThoat.Enabled
             = btnReload.Enabled = nhanVienGridControl.Enabled = false;
            btnGhi.Enabled = true;
            txtMaCN.Enabled = false;
            txtTrangThaiXoa.Enabled = false;
            nhanVienGridControl.Enabled = false;
            clicksua = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            groupBox1.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled
                = btnThoat.Enabled = btnCCN.Enabled = nhanVienGridControl.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            txtMaNV.Enabled = false;
            txtMaCN.Enabled = false;
            txtTrangThaiXoa.Enabled = false;
            nhanVienGridControl.Enabled = false;
            clicksua = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được để trống!");
                txtMaNV.Focus();
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!");
                txtTen.Focus();
            }
            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được để trống!");
                txtHo.Focus();
            }
            else if (txtNgaySinh.Text.Trim() == "")
            {
                MessageBox.Show("Ngày sinh nhân viên không được để trống!");
                txtNgaySinh.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ nhân viên không được để trống!");
                txtDiaChi.Focus();
            }
            else if(cmbPhai.Text.Trim() == "")
            {
                MessageBox.Show("Phái không được để trống!");
                cmbPhai.Focus();
            }
            else
            {
                if (clicksua == false)
                {
                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraMaNhanVienTonTai] " +
                            "@MaNV = N'" + txtMaNV.Text + "' SELECT  'Return Value' = @return_value";
                    myReader1 = Program.ExecSqlDataReader(strlenh1);

                    if (myReader1 == null) return;

                    myReader1.Read();
                    int value1 = myReader1.GetInt32(0);

                    myReader1.Close();
                    if (value1 == 1)
                    {
                        MessageBox.Show("Mã nhân viên đã tồn tại. Nhập lại.");
                        txtMaNV.Focus();
                    }
                    else
                    {
                        bdsNV.EndEdit();
                        MessageBox.Show("Thêm nhân viên thành công!");
                        bdsNV.ResetCurrentItem();
                        this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                        ShowAll();
                    }
                }
                else
                {
                    this.bdsNV.EndEdit();
                    MessageBox.Show("Sửa nhân viên thành công!");
                    bdsNV.ResetCurrentItem();
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                    ShowAll();
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = btnSua.Enabled =
               btnThoat.Enabled = btnCCN.Enabled = btnReload.Enabled = nhanVienGridControl.Enabled = true;
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn xóa", "Xóa nhân viên.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_KiemTraXoaMaNhanVien] " +
                        "@MANV = N'" + txtMaNV.Text + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                int value1 = myReader1.GetInt32(0);

                myReader1.Close();
                if (value1 == 1)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại trong phiếu nhập, hoá đơn hay đặt hàng. Không thể xóa.");
                    return;
                }
                else
                {
                    groupBox1.Enabled = false;
                    txtTrangThaiXoa.Text = "1";
                    bdsNV.EndEdit();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
            }
            else
            {
                ShowAll();
            }
            
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnThem.Enabled == false) bdsNV.Position = vitri;
            nhanVienGridControl.Enabled = true;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.dS.NhanVien);

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

        private void btnCCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắc muốn chuyển nhân viên", "Chuyển nhân viên.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                txtTrangThaiXoa.Text = "1";
                bdsNV.EndEdit();
                this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                SqlDataReader myReader1;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[sp_MaxMaNV] " +
                            "@temp = N'" + 0 + "' SELECT  'Return Value' = @return_value";
                myReader1 = Program.ExecSqlDataReader(strlenh1);

                if (myReader1 == null) return;

                myReader1.Read();
                //int value1 = myReader1.GetInt32(0);
                int manv = int.Parse(txtMaNV.Text);
                myReader1.Close();
                if (Program.mChinhanh == 0)
                {
                    Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_03";
                    Macn = "CN2";
                }
                else
                {
                    Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_02";
                    Macn = "CN1";
                }
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
                if (Program.KetNoi() == 0)
                {
                    MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                    return;
                }
                else
                {

                    nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;

                    string ngaysinh = txtNgaySinh.Text;
                    DateTime dt = Convert.ToDateTime(ngaysinh);

                    SqlDataReader myReader2;

                    string lenh = "EXEC  sp_CHUYENCHINHANH " +
                                    manv + ",'" +
                                    txtHo.Text + "','" +
                                    txtTen.Text + "','" +
                                    txtDiaChi.Text + "','" +
                                    txtSdt.Text + "','" +
                                    dt + "','" +
                                    Macn + "'," +
                                    0 + ",'" +
                                    cmbPhai.Text + "'";
                    myReader2 = Program.ExecSqlDataReader(lenh);

                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                    if (Program.mChinhanh == 0)
                    {
                        Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_02";
                        Macn = "CN1";
                    }
                    else
                    {
                        Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_03";
                        Macn = "CN2";
                    }
                    if (Program.KetNoi() == 0)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }
                    nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    nhanVienTableAdapter.Fill(dS.NhanVien);
                    this.nhanVienTableAdapter.Update(this.dS.NhanVien);
                }
            }
                
        }

        private void btnTTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTaoTK tk = new FormTaoTK();
            tk.Show();
        }
    }
}

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
    public partial class FormTaoTK : Form
    {
        public FormTaoTK()
        {
            InitializeComponent();
        }

        public void LoadDataNhanVien()
        {
            SqlDataAdapter da = new SqlDataAdapter("select MaNV,HoTen from V_LAYMANHANVIENLG", Program.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbNV.DataSource = dt;
            cmbNV.ValueMember = "MANV";
            cmbNV.DisplayMember = "HOTEN";
        }

        public void XetQuyen()
        {
            if (Program.mGroup.Equals("CONGTY"))
            {
                cmbQuyen.Items.Add("CONGTY");
                cmbQuyen.SelectedIndex = 0;
            }
            else if(Program.mGroup.Equals("CHINHANH"))
            {
                cmbQuyen.Items.Add("CHINHANH");
                cmbQuyen.SelectedIndex = 0;
            }
            else
            {
                btnTaoTK.Enabled = false;
                cmbQuyen.Enabled = cmbNV.Enabled = txtTenDN.Enabled = txtPass.Enabled = btnTaoTK.Enabled = false;
            }
            
        }

        //private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.bdsNV.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.dS);

        //}

        //private void Fill()
        //{
        //    dS.EnforceConstraints = false;
        //    // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
        //    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
        //    this.nhanVienTableAdapter.Fill(this.dS.NhanVien);
        //    macn = ((DataRowView)bdsNV[0])["MaNV"].ToString();
        //}

        private void FormTaoTK_Load(object sender, EventArgs e)
        {
            LoadDataNhanVien();
            XetQuyen();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            string maNhanVien = cmbNV.SelectedValue.ToString();
            string tenDangNhap = txtTenDN.Text;
            string matKhau = txtPass.Text;
            string quyenHan = cmbQuyen.Text.ToString();
            if (tenDangNhap.Equals(""))
            {
                MessageBox.Show("Tên đăng nhập không được để trống !");
                txtTenDN.Focus();
                return;
            }
            if (matKhau.Equals(""))
            {
                MessageBox.Show("Mật khẩu không được để trống !");
                txtPass.Focus();
                return;
            }

            SqlDataReader myReader;

            String strLenh = "EXEC  SP_TaoTaiKhoan N'"
                + tenDangNhap + "',N'" + matKhau + "',N'" + maNhanVien + "','" + quyenHan + "'";
            try
            {
                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader != null)
                {
                    MessageBox.Show("Tạo  login thành công!");
                    myReader.Close();
                    Program.conn.Close();
                    LoadDataNhanVien();
                    //Reset();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Không thể tạo login ! ");
                MessageBox.Show(ex.Message);
                return;
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

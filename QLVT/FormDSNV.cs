using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVT
{
    public partial class FormDSNV : Form
    {
        public FormDSNV()
        {
            InitializeComponent();
        }

        private void FormDSNV_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
            cmbChinhanh.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChinhanh.DisplayMember = "TENCN";
            cmbChinhanh.ValueMember = "TENSERVER";
            cmbChinhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "CHINHANH") cmbChinhanh.Enabled = false;
        }

        private void cmbChinhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if(cmbChinhanh.SelectedIndex == Program.mChinhanh)
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
                if (Program.mChinhanh == 0) Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_02";
                else Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_03";
                Program.KetNoi();
            }
            if (cmbChinhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
                if (Program.servername == "DESKTOP-CJNDVE0\\NHONVUONG_02") Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_03";
                else if (Program.servername == "DESKTOP-CJNDVE0\\NHONVUONG_03") Program.servername = "DESKTOP-CJNDVE0\\NHONVUONG_02";
                Program.KetNoi();
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if(cmbChinhanh.SelectedIndex == 0 || cmbChinhanh.SelectedIndex == 1)
            {
                XtraDSNV dsnv = new XtraDSNV();
                dsnv.lblTieude.Text = "DANH SÁCH NHÂN VIÊN CỦA " + cmbChinhanh.Text.ToUpper();
                ReportPrintTool print = new ReportPrintTool(dsnv);
                print.ShowPreviewDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormDSVT : Form
    {
        public FormDSVT()
        {
            InitializeComponent();
        }

        private void FormDSVT_Load(object sender, EventArgs e)
        {
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            XtraDSVT dsnv = new XtraDSVT();
            dsnv.lblTieude.Text = "DANH SÁCH MẶT HÀNG CỦA CÔNG TY";
            ReportPrintTool print = new ReportPrintTool(dsnv);
            print.ShowPreviewDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormChiTietSoLuongNhap : Form
    {
        public FormChiTietSoLuongNhap()
        {
            InitializeComponent();
        }

        private void FormChiTietSoLuongNhap_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = lblTu.Value;
            DateTime denNgay = lblDen.Value;
            XtraNhap thnx = new XtraNhap(tuNgay, denNgay);
            ReportPrintTool print = new ReportPrintTool(thnx);
            print.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

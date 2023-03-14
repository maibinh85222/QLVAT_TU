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
    public partial class FormTongHopNhapXuat : Form
    {
        public FormTongHopNhapXuat()
        {
            InitializeComponent();
        }

        private void FormTongHopNhapXuat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = lblTu.Value;
            DateTime denNgay = lblDen.Value;
            XtraTongHopNhapXuat thnx = new XtraTongHopNhapXuat(tuNgay,denNgay);
            thnx.lblNgay.Text = "Từ ngày:" + tuNgay.ToString() + " Đến ngày:" + denNgay.ToString();
            
            ReportPrintTool print = new ReportPrintTool(thnx);
            print.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

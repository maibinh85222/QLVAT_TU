using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class XtraNhap : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraNhap(DateTime nbd, DateTime nkt)
        {
            InitializeComponent();
            qlvtds1.EnforceConstraints = false;
            this.sp_BangKeCTSLNhapTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sp_BangKeCTSLNhapTableAdapter1.Fill(qlvtds1.sp_BangKeCTSLNhap, nbd, nkt);
        }

    }
}

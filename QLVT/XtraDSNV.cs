using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class XtraDSNV : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraDSNV()
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_DSNVTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_DSNVTableAdapter1.Fill(ds1.SP_DSNV);
        }

    }
}

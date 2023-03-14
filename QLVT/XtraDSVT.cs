using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class XtraDSVT : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraDSVT()
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sP_DSVTTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_DSVTTableAdapter1.Fill(ds1.SP_DSVT);
        }

    }
}

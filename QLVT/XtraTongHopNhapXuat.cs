using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLVT
{
    public partial class XtraTongHopNhapXuat : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraTongHopNhapXuat(DateTime nbd, DateTime nkt)
        {
            InitializeComponent();
            qlvtds1.EnforceConstraints = false;
            this.sP_TONGHOPNHAPXUATTableAdapter1.Connection.ConnectionString = Program.connstr;
            this.sP_TONGHOPNHAPXUATTableAdapter1.Fill(qlvtds1.SP_TONGHOPNHAPXUAT, nbd, nkt);
        }
        private DetailReportBand CreateContainer(XRTable table, string date, int Amount, decimal TotalMoney)
        {
            DetailReportBand detailrp = new DetailReportBand();
            DetailBand detail = new DetailBand();
            detail.Controls.Add(table);

            var header = new ReportHeaderBand()
            {
                HeightF = 20
            };

            var label = new XRLabel
            {
                Text = date,
                Font = new Font(Font.FontFamily, 15, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoWidth = false,
                WidthF = 100
            };
            label.SizeF = new System.Drawing.SizeF(200F, 23F);

            header.Controls.Add(label);

            var footer = new ReportFooterBand();

            footer.Controls.AddRange(new XRControl[] {
               new XRLabel
               {
                   Text="Tổng Số Lượng: ",
                   SizeF=new SizeF(100,30),
                   LocationF = new PointF(LocationF.X+250,LocationF.Y),
                   Font = new Font(Font.FontFamily,10,FontStyle.Bold)

               },
               new XRLabel
               {
                   Text= string.Format("{0:n}", Convert.ToInt32(Amount) ),
                   SizeF=new SizeF(100,30),
                   LocationF = new PointF(LocationF.X+350,LocationF.Y)
               },
               //new XRLabel
               //{
               //    Text = "Tổng Tiền: ",
               //    SizeF=new SizeF(100,30),
               //    LocationF = new PointF(LocationF.X+450,LocationF.Y),
               //    Font = new Font(Font.FontFamily,10,FontStyle.Bold)
               //},
               //new XRLabel
               //{
               //    Text=string.Format("{0:n}", TotalMoney ),
               //    SizeF=new SizeF(100,30),
               //    LocationF = new PointF(LocationF.X+550,LocationF.Y)

               //}
            });


            detailrp.Bands.AddRange(

                new Band[]
                {
                  header,
                    detail,
                    footer
                }
                );
            return detailrp;
        }
    }
}

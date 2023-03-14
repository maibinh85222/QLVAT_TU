using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QLVT.DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLVT
{
    public partial class XtraCTSLNhap : DevExpress.XtraReports.UI.XtraReport
    {
        private List<CTSLNhap> data;
        public XtraCTSLNhap(List<CTSLNhap> data)
        {
            InitializeComponent();
            this.data = data;
            CreateReport();
        }
        private void CreateReport()
        {

            List<List<CTSLNhap>> datareports = new List<List<CTSLNhap>>();
            var month = data[0].NgayLap.Month + 1;
            var year = data[0].NgayLap.Year + 1;
            List<CTSLNhap> temp = null;
            foreach (var item in data)
            {
                if (item.NgayLap.Month != month || item.NgayLap.Year != year)
                {
                    temp = new List<CTSLNhap>();
                    month = item.NgayLap.Month;
                    year = item.NgayLap.Year;
                    datareports.Add(temp);
                }
                temp.Add(item);
            }
            foreach (var item in datareports)
            {
                XRTable table = CreateTable(item);
                this.Bands.Add(CreateContainer(table, item[0].NgayLap.ToString(" MMMM yyyy"), item.Sum(x => x.SoLuong), item.Sum(x => x.ThanhTien)));

            }

        }
        private void Fill(List<CTSLNhap> model, XRTable table)
        {
            foreach (var item in model)
            {
                var row = SetValues(item);
                table.Rows.Add(row);
            }
        }
        private XRTableCell[] createTile()
        {
            var row = new XRTableRow();

            Type type = typeof(CTSLNhap);
            var properties = type.GetProperties();


            XRTableCell[] titles = new XRTableCell[properties.Length];

            for (int i = 0; i < properties.Length; i++)
            {
                titles[i] = new XRTableCell
                {
                    Text = properties[i].Name,
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter,
                    ForeColor = Color.Red,
                    Font = new Font(Font.FontFamily, 12, FontStyle.Bold),
                    Weight = 100

                };
            }
            return titles;
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
               new XRLabel
               {
                   Text = "Tổng Tiền: ",
                   SizeF=new SizeF(100,30),
                   LocationF = new PointF(LocationF.X+450,LocationF.Y),
                   Font = new Font(Font.FontFamily,10,FontStyle.Bold)
               },
               new XRLabel
               {
                   Text=string.Format("{0:n}", TotalMoney ),
                   SizeF=new SizeF(100,30),
                   LocationF = new PointF(LocationF.X+550,LocationF.Y)

               }
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
        private XRTable CreateTable(List<CTSLNhap> models)
        {
            XRTable table = new XRTable();
            table.SizeF = new System.Drawing.SizeF(637F, 23F);

            var row = new XRTableRow();
            row.Cells.AddRange(createTile());
            table.Rows.Add(row);

            Fill(models, table);

            return table;
        }

        private XRTableRow SetValues(object obj)
        {
            var row = new XRTableRow();

            Type type = obj.GetType();
            var properties = type.GetProperties();
            foreach (var item in properties)
            {
                var cell = new XRTableCell()
                {
                    TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                };

                if (item.PropertyType == typeof(DateTime))
                {
                    cell.Text = ((DateTime)item.GetValue(obj)).ToString("dd/MM/yyyy");
                }
                else
                {

                    cell.Text = item.GetValue(obj).ToString();
                }
                row.Cells.Add(cell);
            }
            return row;
        }
    }
}

using DevExpress.XtraReports.UI;
using QLVT.DTO;
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
    public partial class FormCTSLNhap : Form
    {
        public FormCTSLNhap()
        {
            InitializeComponent();
        }
        private List<CTSLNhap> GetData(string FromDate, string ToDate)
        {
            SqlConnection sql = new SqlConnection(Program.connstr);

            try
            {
                sql.Open();
            }
            catch
            {
                MessageBox.Show("Vui long thử đăng nhập lại!!");
                return null;
            }
            SqlCommand cmd = sql.CreateCommand();

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "sp_BangKeCTSLNhap";
            cmd.Parameters.AddRange(new SqlParameter[]
            {
                new SqlParameter("FromDate",FromDate),
                new SqlParameter("ToDate",ToDate)
            });
           var data = new List<CTSLNhap>();


            var results = cmd.ExecuteReader();
            while (results.Read())
            {
                data.Add(new CTSLNhap
                {
                    MaPN = results["MaPN"].ToString(),
                    SoLuong = Convert.ToInt32(results["SoLuong"]),
                    NgayLap = Convert.ToDateTime(results["Ngay"]),
                    DonGia = Convert.ToInt32(results["DonGia"]),
                    TenMH = results["Ten"].ToString(),
                    HoTen = results["NameNV"].ToString(),
                    ThanhTien = Convert.ToInt32(results["TotalMoney"])
                });
            }

            return data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var data = GetData(dateTimePicker1.Value.ToString("yyyy/MM/dd"), dateTimePicker2.Value.ToString("yyyy/MM/dd"));
            if (data == null) return;
            if (data.Count < 1)
            {
                MessageBox.Show("Dữ liệu không khớp, vui lòng chọn lại khoản thời gian!");
                return;
            }
            XtraCTSLNhap ctn = new XtraCTSLNhap(data);
            ReportPrintTool print = new ReportPrintTool(ctn);
            print.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCTSLNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

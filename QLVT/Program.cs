using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace QLVT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "QLVT";
        public static String remotelogin = "HTKN";
        public static String remotepassword = "123";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoten = "";
        public static int mChinhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static FormMain frmChinh;
        public static SqlCommand sqlcmd = new SqlCommand();

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }
        public static int ExecuteReader(SqlCommand cmd)
        {
            int result;
            try
            {
                Program.KetNoi();
                cmd.Connection = Program.conn;
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Loi khi thuc thi lenh SQL: " + ex.Message);
            }
            finally
            {
                Program.conn.Close();
            }
            try
            {
                result = (int)cmd.Parameters["@VALUE"].Value;
            }
            catch { }

            return result;
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;
                
            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public static DataTable ExecSqlDataTable(String cmd)
        {   
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
     
        public static int ExecSqlNonQuery(String strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut 
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.");
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // trang thai lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
        public static object ExecuteScalarQuery(string query, object[] parameter)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connstr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand();
                command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                string[] listPara = query.Split(' ');
                String sp = listPara[0];
                if (parameter != null)
                {

                    int i = 0;

                    command.CommandText = sp;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            //  MessageBox.Show(item+" - "+parameter[i], "", MessageBoxButtons.OK);
                            i++;
                        }


                    }
                }


                SqlParameter returnParameter = command.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    return data;//connection close
                }


                data = returnParameter.Value.ToString();

                connection.Close();
            }
            return data;
        }

        public static object ExecuteScalarQueryString(string query, object[] parameter)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connstr))
            {

                connection.Open();
                SqlCommand command = new SqlCommand();
                command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                string[] listPara = query.Split(' ');
                String sp = listPara[0];
                if (parameter != null)
                {

                    int i = 0;

                    command.CommandText = sp;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            //  MessageBox.Show(item+" - "+parameter[i], "", MessageBoxButtons.OK);
                            i++;
                        }


                    }
                }


                SqlParameter returnParameter = command.Parameters.Add("@Out", SqlDbType.NVarChar, 150);
                returnParameter.Direction = ParameterDirection.Output;
                command.ExecuteNonQuery();
                //the Size property has an invalid size of 0 phai them cai size 150
                data = returnParameter.Value.ToString();

                connection.Close();
            }
            return data;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmChinh = new FormMain();
            Application.Run(frmChinh);
            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            //Application.Run(new FormDangNhap());
        }

        //public static DataTable Table(BindingSource bs)
        //{
        //    var bsFirst = bs;
        //    while (bsFirst.DataSource is BindingSource)
        //        bsFirst = (BindingSource)bsFirst.DataSource;

        //    DataTable dt;
        //    if (bsFirst.DataSource is DataSet)
        //        dt = ((DataSet)bsFirst.DataSource).Tables[bsFirst.DataMember];
        //    else if (bsFirst.DataSource is DataTable)
        //        dt = (DataTable)bsFirst.DataSource;
        //    else
        //        return null;

        //    if (bsFirst != bs)
        //    {
        //        if (dt.DataSet == null) return null;
        //        dt = dt.DataSet.Relations[bs.DataMember].ChildTable;
        //    }

        //    return dt;
        //}
    }
}

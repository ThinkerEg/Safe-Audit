using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Safe_Audit.Properties;

namespace Safe_Audit.DAL
{
    public class DataAccessLayer
    {
        // تم إضافة public هنا عشان الخط الأحمر يختفي في الـ BL
        public SqlConnection sqlconnection;
        string server = Settings.Default.Server;
        string database = Settings.Default.Database;
        string mode = Settings.Default.Mode;
        public DataAccessLayer()
        {
            // تم تغيير اسم القاعدة وإضافة Integrated Security لضمان الدخول بحساب الويندوز
            // وإضافة TrustServerCertificate لحل مشاكل التشفير في النسخ الجديدة
            //sqlconnection = new SqlConnection(@"Server=.;Database=Safe_Audit;Integrated Security=True;TrustServerCertificate=True;");
        
        //public DataAccessLayer()
        //{

        SET_ONLINE();
            if (mode == "SQL")
            {
                sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + ",1433; Database=" +
                                                  Properties.Settings.Default.Database + "; Integrated Security=false; User ID=" +
                                                  Properties.Settings.Default.ID + "; Password=" + Properties.Settings.Default.Password + "");


    }
            else
            {
            sqlconnection = new SqlConnection(@"Server=.;Database=Safe_Audit;Integrated Security=True;TrustServerCertificate=True;");

                // //المششكلة يرى الداتا لكن المشكلة في صلاحيات المستخدم
                // تم الحل
                //sqlconnection = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; AttachDbFilename = " + Properties.Settings.Default.Database + "; Integrated Security = True;User Instance=True");
            }
        }
        
        public void SET_ONLINE()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=" + Properties.Settings.Default.Server + "; Database=master; Integrated Security=True");
                SqlCommand cmd2;
                string strQuery = "ALTER Database " + Properties.Settings.Default.Database + " SET ONLINE  WITH ROLLBACK IMMEDIATE ";
                cmd2 = new SqlCommand(strQuery, con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                cmd2.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                //for (int i = 0; i < 3000; i++)
                //{

                //}
            }
            catch
            {

            }
        }
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open) sqlconnection.Open();
        }

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open) sqlconnection.Close();
        }

        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(stored_procedure, sqlconnection);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            if (param != null) sqlcmd.Parameters.AddRange(param);

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand(stored_procedure, sqlconnection);
            sqlcmd.CommandType = CommandType.StoredProcedure;
            if (param != null) sqlcmd.Parameters.AddRange(param);
            sqlcmd.ExecuteNonQuery();
        }
    }
}

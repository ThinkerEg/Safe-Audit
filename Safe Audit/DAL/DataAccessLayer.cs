using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Safe_Audit.DAL
{
    public class DataAccessLayer
    {
        // تم إضافة public هنا عشان الخط الأحمر يختفي في الـ BL
        public SqlConnection sqlconnection;

        public DataAccessLayer()
        {
            // تم تغيير اسم القاعدة وإضافة Integrated Security لضمان الدخول بحساب الويندوز
            // وإضافة TrustServerCertificate لحل مشاكل التشفير في النسخ الجديدة
            sqlconnection = new SqlConnection(@"Server=.;Database=Safe_Audit;Integrated Security=True;TrustServerCertificate=True;");
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
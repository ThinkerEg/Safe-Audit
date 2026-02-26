using System;
using System.Data;
using System.Data.SqlClient;
using Safe_Audit.DAL; // استدعاء طبقة البيانات

namespace Safe_Audit.BL
{
    class CLS_Expenses
    {
        // دالة جلب المصروفات بناءً على طلبك
        public DataTable SearchExpenses(DateTime From, DateTime To, string Search)
        {
            DataAccessLayer dal = new DataAccessLayer();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@From", SqlDbType.DateTime);
            param[0].Value = From;

            param[1] = new SqlParameter("@To", SqlDbType.DateTime);
            param[1].Value = To;

            param[2] = new SqlParameter("@Search", SqlDbType.NVarChar, 255);
            param[2].Value = Search;

            return dal.SelectData("SP_SearchExpenses", param);
        }
    }
}
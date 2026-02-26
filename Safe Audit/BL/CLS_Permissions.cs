using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Audit.BL
{
    class CLS_Permissions
    {
        // دالة التحقق من الباسورد
        public bool Verify_Admin_Password(string inputPassword)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Pwd", SqlDbType.NVarChar) { Value = inputPassword };

            DataTable dt = dal.SelectData("SELECT * FROM System_Permissions WHERE Admin_Password = @Pwd", param);
            return dt.Rows.Count > 0;
        }

        // دالة تحديث الباسورد
        public void Update_Password(string newPwd)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NewPwd", SqlDbType.NVarChar) { Value = newPwd };
            dal.Open();
            dal.ExecuteCommand("UPDATE System_Permissions SET Admin_Password = @NewPwd", param);
            dal.Close();
        }
    }
}

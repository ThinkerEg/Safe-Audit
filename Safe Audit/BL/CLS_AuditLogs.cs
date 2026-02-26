using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Audit.BL
{
    class CLS_AuditLogs
    {
        public DataTable Get_Audit_Logs()
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            // إجراء بسيط لجلب سجلات جدول الـ Audit
            return dal.SelectData("SELECT * FROM Audit_Log_Changes ORDER BY Change_Date DESC", null);
        }
    }
}

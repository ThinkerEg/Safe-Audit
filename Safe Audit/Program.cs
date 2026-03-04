using Safe_Audit.DAL;
using System;
using System.Windows.Forms;

namespace Safe_Audit
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. فحص الاتصال بقاعدة البيانات أولاً
            if (TestConnection())
            {
                // 2. إذا نجح الاتصال، ننشئ شاشة اللوجن
                PL.FRM_Login login = new PL.FRM_Login();

                // 3. ننتظر نتيجة الدخول (ShowDialog)
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // 4. إذا نجح الدخول، افتح الشاشة الرئيسية للبرنامج
                    Application.Run(new PL.FRM_Main());
                }
                else
                {
                    // إذا أغلق المستخدم شاشة اللوجن بدون دخول ناجح
                    Application.Exit();
                }
            }
            else
            {
                // 5. إذا فشل الاتصال بالسيرفر، افتح شاشة الإعدادات فوراً
                MessageBox.Show("عفواً، لا يمكن الاتصال بسيرفر البيانات. برجاء ضبط إعدادات السيرفر.",
                                "خطأ في الاتصال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Application.Run(new PL.FRM_CONFIG());
            }
        }

        // دالة فحص الاتصال (كما هي في كودك)
        static bool TestConnection()
        {
            try
            {
                DataAccessLayer dal = new DataAccessLayer();
                dal.Open();
                dal.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
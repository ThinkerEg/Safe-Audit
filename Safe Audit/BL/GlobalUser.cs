using System;

namespace Safe_Audit.BL
{
    public static class GlobalUser
    {
        // المعرف الوحيد للمستخدم (المستخدم في الـ Foreign Keys والـ Log)
        public static int ID { get; set; } = 1;

        // الاسم الكامل للعرض في واجهة البرنامج
        public static string FullName { get; set; } = "مدير النظام";

        // نوع المستخدم (أدمن، كاشير، إلخ) للتحكم في الصلاحيات
        public static string UserType { get; set; }
    }
}
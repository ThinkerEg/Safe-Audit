using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System;
using System.Drawing; // ضروري للألوان
using System.Windows.Forms; // ضروري للأدوات مثل Button و TextBox
using System.Runtime.InteropServices; // ضروري للـ DllImport

namespace Safe_Audit.BL
{
    // جعلنا الكلاس public static ليسهل استخدامه في أي مكان
    public static class HelperMethods
    {
        // أضف هذه الألوان داخل public static class HelperMethods

        public static Color HeaderColor = Color.FromArgb(41, 128, 185);    // الأزرق الاحترافي (نفس صورة image_965b42.png)
        public static Color PrimaryColor = Color.FromArgb(41, 128, 185);   // لون الـ Brand الأساسي
        public static Color SuccessColor = Color.FromArgb(39, 174, 96);    // أخضر للوارد / الإضافة
        public static Color DangerColor = Color.FromArgb(192, 57, 43);     // أحمر للمنصرف / الإغلاق / الحذف
        public static Color WarningColor = Color.FromArgb(243, 156, 18);   // برتقالي للتعديل
        public static Color BackColor = Color.FromArgb(236, 240, 241);     // رمادي هادئ جداً للخلفية

        // أضف هذا السطر مع الـ DllImports الموجودة فوق في الهيلبر
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // دالة جاهزة لتحريك أي فورم عن طريق أي أداة (مثل البانل)
        public static void MoveForm(IntPtr handle)
        {
            ReleaseCapture();
            SendMessage(handle, 0x112, 0xf012, 0);
        }
        // استدعاء مكتبة الويندوز المسؤولة عن رسم الأشكال (GDI+)
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // إحداثي اليسار
            int nTopRect,      // إحداثي الأعلى
            int nRightRect,    // إحداثي اليمين
            int nBottomRect,   // إحداثي الأسفل
            int nWidthEllipse, // عرض الانحناء (القطر)
            int nHeightEllipse // طول الانحناء (القطر)
        );

        /// <summary>
        /// دالة موحدة لتطبيق الحواف المستديرة على أي أداة
        /// </summary>
        /// <param name="control">الأداة (Form, Button, Panel, GroupBox...)</param>
        /// <param name="radius">درجة الانحناء</param>
        public static void ApplyRoundedCorners(Control control, int radius)
        {
            if (control != null && control.Width > 0 && control.Height > 0)
            {
                control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
            }
            //if (control != null && control.Width > 0 && control.Height > 0)
            //{
            //    // تم تعديل الإحداثيات هنا بنقصان 1 بكسل من العرض والارتفاع لإظهار الحواف المختفية
            //    control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width - 1, control.Height - 1, radius, radius));
            //}
        }
        // في كلاس HelperMethods.cs
        public static void FormFadeIn(Form frm, int interval = 20)
        {
            frm.Opacity = 0; // يبدأ الفورم وهو مخفي تماماً
            Timer timer = new Timer();
            timer.Interval = interval; // سرعة الظهور
            timer.Tick += (s, e) =>
            {
                if (frm.Opacity < 1)
                {
                    frm.Opacity += 0.05; // يظهر تدريجياً بنسبة 5% في كل لقطة
                }
                else
                {
                    timer.Stop(); // توقف عندما نصل للظهور الكامل
                    timer.Dispose();
                }
            };
            timer.Start();
        }
        // في كلاس HelperMethods.cs
        public static void FormFadeOut(Form frm, int interval = 20)
        {
            Timer timer = new Timer();
            timer.Interval = interval;
            timer.Tick += (s, e) =>
            {
                if (frm.Opacity > 0)
                {
                    frm.Opacity -= 0.05; // يختفي تدريجياً
                }
                else
                {
                    timer.Stop();
                    timer.Dispose();
                    frm.Close(); // يغلق الفورم بعد انتهاء التلاشي
                }
            };
            timer.Start();
        }
        //public static void StyleButtons(Form frm)
        //{
        //    foreach (Control c in frm.Controls)
        //    {
        //        if (c is GroupBox grp) // لو الأزرار داخل GroupBox
        //        {
        //            foreach (Control btn in grp.Controls)
        //            {
        //                if (btn is Button b)
        //                {
        //                    b.FlatStyle = FlatStyle.Flat;
        //                    b.FlatAppearance.BorderSize = 0;
        //                    b.Cursor = Cursors.Hand;
        //                    // جعل حواف الأزرار دائرية أيضاً!
        //                    ApplyRoundedCorners(b, 10);
        //                }
        //            }
        //        }
        //    }
        //}
        // 1. تعديل دالة مسح الحقول
        public static void ClearFields(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is NumericUpDown)
                {
                    ((NumericUpDown)c).Value = 0;
                }
                else if (c.HasChildren)
                {
                    ClearFields(c); // البحث داخل الحاويات
                }
            }
        }

        // 2. تعديل دالة تنسيق الأزرار
        public static void StyleButtons(Form frm)
        {
            foreach (Control c in frm.Controls)
            {
                // إذا كان الزر على الفورم مباشرة
                if (c is Button)
                {
                    ApplyButtonStyle((Button)c);
                }
                // إذا كان هناك جدول
                else if (c is DataGridView)
                {
                    FormatDataGridView((DataGridView)c);
                }
                // إذا كانت الأدوات داخل حاوية (Panel, GroupBox)
                if (c.HasChildren)
                {
                    StyleControlsInside(c);
                }
            }
        }

        // دالة مساعدة لتجنب التكرار
        private static void StyleControlsInside(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is Button) ApplyButtonStyle((Button)c);
                if (c is DataGridView) FormatDataGridView((DataGridView)c);
                if (c.HasChildren) StyleControlsInside(c);
            }
        }
        private static void ApplyButtonStyle(Button b)
        {
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;

            // إذا كان اسم الزرار يحتوي على كلمة Close خليه يقلب أحمر عند الوقوف عليه
            if (b.Name.ToLower().Contains("close"))
            {
                b.FlatAppearance.MouseOverBackColor = Color.Red;
                b.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            }

            ApplyRoundedCorners(b, 10);
        }
        //private static void ApplyButtonStyle(Button b)
        //{
        //    b.FlatStyle = FlatStyle.Flat;
        //    b.FlatAppearance.BorderSize = 0;
        //    b.Cursor = Cursors.Hand;
        //    ApplyRoundedCorners(b, 10);
        //}
        // 1. دالة موحدة لتنسيق أي DataGridView في البرنامج بشكل احترافي
        public static void FormatDataGridView(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            // تنسيق الهيدر (العناوين)
            dgv.ColumnHeadersDefaultCellStyle.BackColor = HeaderColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;

            // تنسيق الصفوف
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
        }
        public static bool IsValid(Control container)
        {
            foreach (Control c in container.Controls)
            {
                // الطريقة القديمة في التحقق والتحويل
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;

                    // تجاهل الحقول الاختيارية بناءً على التاج
                    if (txt.Tag != null && txt.Tag.ToString() == "Optional")
                        continue;

                    if (string.IsNullOrWhiteSpace(txt.Text))
                    {
                        txt.BackColor = Color.MistyRose;
                        return false;
                    }
                    else
                    {
                        txt.BackColor = Color.White;
                    }
                }
                else if (c.HasChildren)
                {
                    if (!IsValid(c)) return false;
                }
            }
            return true;
        }
        //private static void ApplyButtonStyle(Button b)
        //{
        //    b.FlatStyle = FlatStyle.Flat;
        //    b.FlatAppearance.BorderSize = 0;
        //    b.Cursor = Cursors.Hand;

        //    // إذا كان اسم الزرار يحتوي على كلمة Close خليه يقلب أحمر عند الوقوف عليه
        //    if (b.Name.ToLower().Contains("close"))
        //    {
        //        b.FlatAppearance.MouseOverBackColor = Color.Red;
        //        b.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        //    }

        //    ApplyRoundedCorners(b, 10);
        //}
        //public static bool IsValid(Control container)
        //{
        //    foreach (Control c in container.Controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            TextBox txt = (TextBox)c;
        //            if (string.IsNullOrWhiteSpace(txt.Text))
        //            {
        //                txt.BackColor = Color.MistyRose;
        //                return false;
        //            }
        //        }
        //        else if (c.HasChildren)
        //        {
        //            if (!IsValid(c)) return false;
        //        }
        //    }
        //    return true;
        //}

        public static void OpenChildForm(Form childForm)
        {
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // --- السطر المطلوب إضافته هنا ---
            childForm.BackColor = BackColor;
            // --------------------------------

            ApplyRoundedCorners(childForm, 20);
            FormFadeIn(childForm);
            StyleButtons(childForm);
            childForm.Show();
        }
    }
    //public static void ApplyRoundedCorners(Control control, int radius)
    //{
    //    if (control != null && control.Width > 0 && control.Height > 0)
    //    {
    //        // تم تعديل الإحداثيات هنا بنقصان 1 بكسل من العرض والارتفاع لإظهار الحواف المختفية
    //        control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width - 1, control.Height - 1, radius, radius));
    //    }
    //}
}
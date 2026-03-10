using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Safe_Audit.BL
{
    public static class HelperMethods
    {
        #region الألوان الأساسية الديناميكية
        public static Color HeaderColor { get { return Properties.Settings.Default.HeaderColor; } set { Properties.Settings.Default.HeaderColor = value; } }
        public static Color PrimaryColor { get { return Properties.Settings.Default.PrimaryColor; } set { Properties.Settings.Default.PrimaryColor = value; } }
        public static Color BackColor { get { return Properties.Settings.Default.BackColor; } set { Properties.Settings.Default.BackColor = value; } }
        public static Color SuccessColor = Color.FromArgb(46, 204, 113);
        public static Color DangerColor = Color.FromArgb(231, 76, 60);
        public static Color WarningColor = Color.FromArgb(241, 196, 15);

        public static Color GetContrastColor(Color backgroundColor)
        {
            double luminance = (0.299 * backgroundColor.R + 0.587 * backgroundColor.G + 0.114 * backgroundColor.B) / 255;
            return luminance > 0.5 ? Color.Black : Color.White;
        }

        public static void ResetToDefault()
        {
            HeaderColor = Color.FromArgb(44, 62, 80);
            PrimaryColor = Color.FromArgb(52, 152, 219);
            BackColor = Color.FromArgb(244, 247, 249);
            Properties.Settings.Default.Save();
        }
        #endregion

        #region تحريك الفورم والحواف
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public static void MoveForm(IntPtr handle) { ReleaseCapture(); SendMessage(handle, 0x112, 0xf012, 0); }

        public static void ApplyModernCorners(Control control, int radius)
        {
            if (control == null || control.Width <= 0 || control.Height <= 0) return;
            using (GraphicsPath path = new GraphicsPath())
            {
                float r = (float)radius;
                path.StartFigure();
                path.AddArc(0, 0, r, r, 180, 90); path.AddArc(control.Width - r, 0, r, r, 270, 90);
                path.AddArc(control.Width - r, control.Height - r, r, r, 0, 90); path.AddArc(0, control.Height - r, r, r, 90, 90);
                path.CloseFigure(); control.Region = new Region(path);
            }
        }
        #endregion

        #region إدارة الفورمات
        //public static void PrepareForm(Form frm)
        //{
        //    frm.FormBorderStyle = FormBorderStyle.None;
        //    frm.BackColor = BackColor;
        //    ApplyModernCorners(frm, 20);
        //    Control[] headers = frm.Controls.Find("pnlHeader", true);
        //    if (headers.Length > 0)
        //    {
        //        Panel pnlHeader = headers[0] as Panel;
        //        if (pnlHeader != null) { pnlHeader.MouseDown += delegate { MoveForm(frm.Handle); }; pnlHeader.BackColor = HeaderColor; }
        //    }
        //    StyleAllControls(frm);
        //    FormFadeIn(frm);
        //}
        public static void PrepareForm(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.BackColor = BackColor;
            ApplyModernCorners(frm, 20);

            Control[] headers = frm.Controls.Find("pnlHeader", true);
            if (headers.Length > 0)
            {
                Panel pnlHeader = headers[0] as Panel;
                if (pnlHeader != null)
                {
                    pnlHeader.MouseDown += delegate { MoveForm(frm.Handle); };
                    pnlHeader.BackColor = HeaderColor;

                    // تحديث ألوان أي Labels موجودة داخل الهيدر تلقائياً
                    foreach (Control ctrl in pnlHeader.Controls)
                    {
                        if (ctrl is Label)
                        {
                            ctrl.ForeColor = GetContrastColor(pnlHeader.BackColor);
                        }
                    }
                }
            }

            StyleAllControls(frm);
            FormFadeIn(frm);
        }

        public static void OpenChildForm(Form childForm) { childForm.StartPosition = FormStartPosition.CenterScreen; childForm.CreateControl(); PrepareForm(childForm); childForm.Show(); }

        public static void FormFadeIn(Form frm) { frm.Opacity = 0; Timer t = new Timer(); t.Interval = 20; t.Tick += delegate { if (frm.Opacity < 1) frm.Opacity += 0.05; else { t.Stop(); t.Dispose(); } }; t.Start(); }

        public static void FormFadeOut(Form frm)
        {
            if (frm == null) return;
            Timer t = new Timer(); t.Interval = 20;
            t.Tick += delegate { if (frm.Opacity > 0) frm.Opacity -= 0.05; else { t.Stop(); t.Dispose(); frm.Close(); } };
            t.Start();
        }
        #endregion

        #region تنسيق العناصر (الأزرار والجداول)
        public static void StyleButtons(Control container) { StyleAllControls(container); }

        public static void StyleAllControls(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Cursor = Cursors.Hand;
                    string btnText = btn.Text.ToLower();
                    string btnName = btn.Name.ToLower();

                    // 1. المجموعة الحمراء (خروج وإغلاق)
                    if (btnName.Contains("close") || btnText.Contains("خروج") || btnText.Contains("إغلاق") || btnText == "x")
                    {
                        btn.BackColor = DangerColor; // اللون الأحمر الثابت أو من السيتنج
                        btn.ForeColor = Color.White;
                        btn.FlatAppearance.MouseOverBackColor = Color.Red;
                    }
                    // 2. المجموعة الزرقاء - أزرار الأكشن (حفظ/دخول/بحث)
                    else if (btnName.StartsWith("btnsave") || btnName.StartsWith("btn_save_con") || btnName.StartsWith("btnlogin") ||
                             btnText.Contains("حفظ") || btnText.Contains("دخول"))
                    {
                        btn.BackColor = PrimaryColor;
                        btn.ForeColor = GetContrastColor(PrimaryColor);
                        ApplyModernCorners(btn, 10);
                    }
                    // 3. المجموعة الصفراء/البرتقالية - (تعديل/إختبار)
                    else if (btnName.StartsWith("btnupdate") || btnName.StartsWith("btn_test_con") || btnName.StartsWith("btnedit") ||
                             btnText.Contains("تعديل") || btnText.Contains("إختبار"))
                    {
                        // هنا نستخدم لون التعديل المخصص من السيتنج
                        btn.BackColor = Properties.Settings.Default.EditColor;
                        btn.ForeColor = GetContrastColor(btn.BackColor);
                        ApplyModernCorners(btn, 10);
                    }
                    // 4. المجموعة الخضراء - (إضافة/تحديث/جديد)
                    else if (btnName.StartsWith("btnadd") ||  btnName.StartsWith("btnrefresh") ||
                             btnText.Contains("إضافة") || btnText.Contains("تحديث") || btnText.Contains("بحث"))
                    {
                        // هنا نستخدم لون الإضافة المخصص من السيتنج
                        btn.BackColor = Properties.Settings.Default.AddColor;
                        btn.ForeColor = GetContrastColor(btn.BackColor);
                        ApplyModernCorners(btn, 10);
                    }
                    //// 5. المجموعة الرمادية - (مسح/مسار/تجميد)
                    //else if (btnText.Contains("مسح") || btnText.Contains("مسار") || btnText.Contains("تجميد") || btnName.StartsWith("btnnew") || btnText.Contains("جديد"))
                    //{
                    //    btn.BackColor = Color.FromArgb(127, 140, 141); // رمادي هادي
                    //    btn.ForeColor = Color.White;
                    //    ApplyModernCorners(btn, 10);
                    //}
                    // 5. المجموعة الرمادية - (مسح/مسار/تجميد/جديد)
                    else if (btnText.Contains("مسح") || btnText.Contains("مسار") || btnText.Contains("تجميد") ||
                             btnName.StartsWith("btnnew") || btnText.Contains("جديد"))
                    {
                        // هنا نستخدم لون الـ OtherColor من السيتنج بدلاً من اللون الثابت
                        btn.BackColor = Properties.Settings.Default.OtherColor;
                        btn.ForeColor = GetContrastColor(btn.BackColor);
                        ApplyModernCorners(btn, 10);
                    }
                }

                DataGridView dgv = c as DataGridView;
                if (dgv != null) FormatDataGridView(dgv);

                if (c.HasChildren) StyleAllControls(c);
            }
        }
        public static void FormatDataGridView(DataGridView dgv)
        {
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false; dgv.ReadOnly = true; dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false; dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White; dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = HeaderColor;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = GetContrastColor(HeaderColor);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 35;
        }
        #endregion

        #region مسح الحقول والتحقق
        public static void ClearFields(Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox) ((TextBox)c).Clear();
                else if (c is ComboBox) ((ComboBox)c).SelectedIndex = -1;
                if (c.HasChildren) ClearFields(c);
            }
        }

        public static bool IsValid(Control container)
        {
            foreach (Control c in container.Controls)
            {
                TextBox txt = c as TextBox;
                if (txt != null)
                {
                    if (txt.Tag != null && txt.Tag.ToString() == "Optional") continue;
                    if (string.IsNullOrEmpty(txt.Text.Trim())) { txt.BackColor = Color.MistyRose; return false; }
                    txt.BackColor = Color.White;
                }
                if (c.HasChildren) { if (!IsValid(c)) return false; }
            }
            return true;
        }
        #endregion
    }
}
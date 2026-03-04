using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using Safe_Audit.DAL; // تأكد من المسار الصحيح للـ DAL

namespace Safe_Audit.PL
{
    public partial class FRM_Users : Form
    {
        DataAccessLayer DAL = new DataAccessLayer();

        // استدعاءات الويندوز للتحريك وقص الحواف (من كودك القديم)
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public FRM_Users()
        {
            InitializeComponent();
            // تطبيق الحواف المستديرة عند تشغيل الفورم
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 25, 25));
        }

        // 1. تحديث الجدول (بلمساتك الجمالية)
        private void RefreshGrid()
        {
            try
            {
                DataTable dt = DAL.SelectData("SELECT UserID, FullName, UserName, UserType FROM Users", null);
                dgvUsers.DataSource = dt;

                if (dgvUsers.Columns.Count > 0)
                {
                    dgvUsers.Columns["UserID"].Visible = false; // إخفاء المعرف
                    dgvUsers.Columns["FullName"].HeaderText = "الاسم بالكامل";
                    dgvUsers.Columns["UserName"].HeaderText = "اسم المستخدم";
                    dgvUsers.Columns["UserType"].HeaderText = "نوع الصلاحية";

                    // التنسيق الحديث اللي كان في كودك
                    dgvUsers.EnableHeadersVisualStyles = false;
                    dgvUsers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 52, 71);
                    dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
            }
            catch (Exception ex) { MessageBox.Show("خطأ في التحميل: " + ex.Message); }
        }

        private void FRM_Users_Load(object sender, EventArgs e)
        {
            comboUserType.Items.Clear();
            comboUserType.Items.AddRange(new string[] { "Admin", "User" }); // عدلها حسب احتياج Safe_Audit
            RefreshGrid();
        }

        // 2. زر التعديل (المنطق الذكي للباسورد)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) { MessageBox.Show("اختر مستخدماً أولاً"); return; }

            try
            {
                string sql;
                List<SqlParameter> paras = new List<SqlParameter>
                {
                    new SqlParameter("@Name", txtFullName.Text),
                    new SqlParameter("@User", txtUserName.Text),
                    new SqlParameter("@Type", comboUserType.SelectedItem?.ToString() ?? "User"),
                    new SqlParameter("@ID", dgvUsers.CurrentRow.Cells["UserID"].Value)
                };

                // منطق الباسورد: لو التكست فاضي مش هنعدله في الداتابيز
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    sql = "UPDATE Users SET FullName=@Name, UserName=@User, UserType=@Type, Password=@Pass WHERE UserID=@ID";
                    paras.Add(new SqlParameter("@Pass", txtPassword.Text));
                }
                else
                {
                    sql = "UPDATE Users SET FullName=@Name, UserName=@User, UserType=@Type WHERE UserID=@ID";
                }

                DAL.ExecuteCommand(sql, paras.ToArray());
                MessageBox.Show("تم التعديل بنجاح");
                RefreshGrid();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show("خطأ في التعديل: " + ex.Message); }
        }

        // 3. حدث النقر على الجدول لملء البيانات
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtUserName.Text = row.Cells["UserName"].Value?.ToString();
                comboUserType.SelectedItem = row.Cells["UserType"].Value?.ToString();
                txtPassword.Clear(); // للأمان
            }
        }
        private void btnIsActive_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) return;

            string userName = dgvUsers.CurrentRow.Cells["UserName"].Value.ToString();

            if (MessageBox.Show($"هل تريد تجميد حساب ({userName})؟ لن يتمكن من دخول النظام ولكن بياناته ستبقى في السجلات.",
                "تجميد حساب", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvUsers.CurrentRow.Cells["UserID"].Value);
                    // تحديث الحالة فقط وليس الحذف
                    DAL.ExecuteCommand("UPDATE Users SET IsActive = 0 WHERE UserID = @ID",
                        new SqlParameter[] { new SqlParameter("@ID", id) });

                    MessageBox.Show("تم تجميد الحساب بنجاح");
                    RefreshGrid();
                }
                catch (Exception ex) { MessageBox.Show("خطأ: " + ex.Message); }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // التأكد من عدم التكرار والبيانات الفارغة
            if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("برجاء إدخال اسم المستخدم وكلمة المرور");
                return;
            }

            try
            {
                // إضافة المستخدم مع حالة "نشط" تلقائياً
                string sql = "INSERT INTO Users (FullName, UserName, Password, UserType, IsActive) VALUES (@Name, @User, @Pass, @Type, 1)";
                SqlParameter[] paras = {
            new SqlParameter("@Name", txtFullName.Text),
            new SqlParameter("@User", txtUserName.Text),
            new SqlParameter("@Pass", txtPassword.Text),
            new SqlParameter("@Type", comboUserType.SelectedItem.ToString())
        };

                DAL.ExecuteCommand(sql, paras);
                MessageBox.Show("تم حفظ المستخدم بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
                ClearFields();
            }
            catch (Exception ex) { MessageBox.Show("خطأ في الحفظ: " + ex.Message); }
        }
        // تحريك الفورم
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void ClearFields()
        {
            txtFullName.Clear(); txtUserName.Clear(); txtPassword.Clear();
            comboUserType.SelectedIndex = -1;
        }
    }
}
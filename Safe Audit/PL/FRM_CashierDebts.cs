using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Safe_Audit.BL; // تأكد من استدعاء كلاسات البيزنس

namespace Safe_Audit.PL
{
    public partial class FRM_CashierDebts : Form
    {
        CLS_Settlements stl = new CLS_Settlements(); // كلاس التسويات والعجز
        CLS_Accounts acc = new CLS_Accounts();       // كلاس الحركات المالية

        public FRM_CashierDebts()
        {
            InitializeComponent();
            LoadCashiers();
        }

        // 1. تحميل قائمة الكاشيرية
        void LoadCashiers()
        {
            try
            {
                cmbCashiers.DataSource = stl.GET_ALL_CASHIERS();
                cmbCashiers.DisplayMember = "CashierName";
                cmbCashiers.ValueMember = "CashierID";
                cmbCashiers.SelectedIndex = -1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // 2. عند اختيار كاشير (عرض الأرقام والجدول)
        private void cmbCashiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCashiers.SelectedValue == null || cmbCashiers.SelectedIndex == -1) return;

            try
            {
                int cashierID = Convert.ToInt32(cmbCashiers.SelectedValue);

                // أ- جلب المديونية الصافية (باستخدام الميثود اللي عملناها قبل كدة)
                decimal debt = stl.GetCashierRemainingDebt(cashierID);
                lblNetDebt.Text = debt.ToString("N2");
                lblNetDebt.ForeColor = debt > 0 ? Color.Red : Color.Green;

                // ب- جلب تفاصيل العمليات (عجوزات وسدادات)
                // ملحوظة: يفضل عمل Method في الـ BL تنفذ الـ Union Query الذي ناقشناه
                dgvTransactions.DataSource = stl.GetCashierRemainingDebt(cashierID);

                // تنسيق الجدول
                FormatGrid();
            }
            catch { }
        }

        void FormatGrid()
        {
            if (dgvTransactions.Columns.Count > 0)
            {
                dgvTransactions.Columns[0].HeaderText = "التاريخ";
                dgvTransactions.Columns[1].HeaderText = "نوع الحركة";
                dgvTransactions.Columns[2].HeaderText = "المبلغ";
                dgvTransactions.Columns[3].HeaderText = "ملاحظات";

                // تلوين الصفوف (اختياري لتمييز السداد عن العجز)
                foreach (DataGridViewRow row in dgvTransactions.Rows)
                {
                    if (row.Cells[1].Value.ToString().Contains("سداد"))
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }

        // 3. الزرار السحري (Shortcut السداد)
        private void btnPayShortcut_Click(object sender, EventArgs e)
        {
            if (cmbCashiers.SelectedValue == null)
            {
                MessageBox.Show("من فضلك اختر الكاشير أولاً");
                return;
            }

            // فتح فورم الحركات المالية
            FRM_FinancialMovements frm = new FRM_FinancialMovements();

            // تمرير البيانات للفورم الآخر (يجب أن يكون لديك ميثود استقبال هناك أو تجعل الأدوات Public)
            frm.Show(); // نفتح الفورم أولاً

            // استهداف الأدوات مباشرة (بما أننا في نفس الـ Namespace)
            // ملاحظة: تأكد من جعل Modifiers للأدوات في فورم الحركات "Public" من شاشة التصميم
            frm.SetExternalCashier(Convert.ToInt32(cmbCashiers.SelectedValue));

            // تحديث البيانات بعد إغلاق فورم السداد
            frm.FormClosed += (s, args) => { cmbCashiers_SelectedIndexChanged(null, null); };
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void btnRefresh_Click(object sender, EventArgs e) => cmbCashiers_SelectedIndexChanged(null, null);
    }
}
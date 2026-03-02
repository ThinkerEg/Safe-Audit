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
        //private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    // التحقق من أن الكومبو بوكس ظاهر وأن هناك قيمة مختارة فعلياً
        //    if (cmbCashier.Visible && cmbCashier.SelectedValue != null)
        //    {
        //        try
        //        {
        //            //MessageBox.Show(cmbCashier.SelectedValue + "");
        //            // جلب المديونية باستخدام الكلاس المختص
        //            decimal debt = ALL_CASHIER.GetCashierRemainingDebt(Convert.ToInt32(cmbCashier.SelectedValue));
        //            // MessageBox.Show(debt + "");
        //            if (debt > 0)
        //            {
        //                lblCashierBalance.Text = "المديونية الحالية: " + debt.ToString("N2") + " ج.م";
        //                lblCashierBalance.ForeColor = System.Drawing.Color.Red; // تنبيه باللون الأحمر
        //                numAmount.Value = debt; // وضع المبلغ تلقائياً لتسهيل السداد
        //            }
        //            else
        //            {
        //                lblCashierBalance.Text = "لا توجد مديونية مستحقة";
        //                lblCashierBalance.ForeColor = System.Drawing.Color.Green; // أخضر للدلالة على عدم وجود عجز
        //                numAmount.Value = 0;
        //            }

        //            lblCashierBalance.Visible = true;
        //        }
        //        catch (Exception ex)
        //        {

        //            MessageBox.Show(ex + "");// في حالة حدوث خطأ أثناء التحميل أو التحويل
        //            lblCashierBalance.Visible = false;
        //        }
        //    }
        //    else
        //    {
        //        lblCashierBalance.Visible = false;
        //    }

        //}
        // 2. عند اختيار كاشير (عرض الأرقام والجدول)
        private void cmbCashiers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCashiers.SelectedValue == null || cmbCashiers.SelectedValue is DataRowView) return;

            try
            {
                int cashierID = Convert.ToInt32(cmbCashiers.SelectedValue);

                // 1. جلب المديونية الصافية (للملصقات/Labels)
                decimal debt = stl.GetCashierRemainingDebt(cashierID);
                lblNetDebt.Text = debt.ToString("N2");
                lblNetDebt.ForeColor = debt > 0 ? Color.Red : Color.Green;

                // 2. جلب جدول الحركات (الصح هنا إننا ننادي الدالة اللي بترجع DataTable)
                // دي الدالة اللي عملناها في كلاس BL وبترجع الـ Union
                DataTable dt = stl.GetCashierTransactionsReport(cashierID);
                dgvTransactions.DataSource = dt;

                // تنسيق الجدول
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في جلب البيانات: " + ex.Message);
            }
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
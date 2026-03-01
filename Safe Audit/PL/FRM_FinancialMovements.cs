using System;
using System.Data;
using System.Windows.Forms;
using Safe_Audit.BL;

namespace Safe_Audit.PL
{
    public partial class FRM_FinancialMovements : Form
    {
        CLS_Accounts acc = new CLS_Accounts();
        CLS_Settlements ALL_CASHIER = new CLS_Settlements();
        bool isLoaded = false; // متغير لمنع تنفيذ الأحداث أثناء تحميل البيانات

        public FRM_FinancialMovements()
        {
            InitializeComponent();
            LoadData();
            isLoaded = true; // تفعيل الأحداث بعد التحميل
        }
        public void SetExternalCashier(int id)
        {
            // التأكد من أن الكومبو بوكس محمل بالبيانات أولاً
            cmbCashier.SelectedValue = id;
            cmbTransType.Text = "سداد عجز كاشير (قبض)";

            // اختياري: قفل التحكم عشان المدير ميغيرش الاسم بالخطأ
            // cmbCashier.Enabled = false; 
        }
        void LoadData()
        {
            try
            {
                // تحميل الحسابات
                cmbAccount.DataSource = acc.Get_All_Accounts();
                cmbAccount.DisplayMember = "MethodName";
                cmbAccount.ValueMember = "MethodID";
                cmbAccount.SelectedIndex = -1;

                // تحميل الكاشيرية
                cmbCashier.DataSource = ALL_CASHIER.GET_ALL_CASHIERS();
                cmbCashier.DisplayMember = "CashierName";
                cmbCashier.ValueMember = "CashierID";
                cmbCashier.SelectedIndex = -1;

                // أنواع العمليات
                cmbTransType.Items.Clear();
                cmbTransType.Items.Add("سداد عجز كاشير (قبض)");
                cmbTransType.Items.Add("توريد لصاحب المال (صرف)");
                cmbTransType.Items.Add("مصروفات من العهدة (صرف)");
            }
            catch (Exception ex) { MessageBox.Show("خطأ في التحميل: " + ex.Message); }
        }

        private void cmbTransType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTransType.SelectedIndex == -1) return;

            bool isSadaad = cmbTransType.SelectedItem.ToString().Contains("سداد عجز");

            cmbCashier.Visible = isSadaad;
            lblCashierBalance.Visible = isSadaad;
            txtResponsible.Visible = !isSadaad;
            label6.Text = isSadaad ? "اختر الكاشير:" : "المستلم / المسؤول:";

            if (!isSadaad)
            {
                numAmount.Value = 0;
                lblCashierBalance.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. التحقق الأساسي
                if (cmbAccount.SelectedValue == null || cmbTransType.SelectedIndex == -1 || numAmount.Value <= 0)
                {
                    MessageBox.Show("أكمل البيانات الأساسية (الحساب، النوع، المبلغ)"); return;
                }

                object cashierID = DBNull.Value;
                string responsibleName = txtResponsible.Text.Trim();
                string category = cmbTransType.SelectedItem.ToString();
                string dbType = category.Contains("قبض") ? "Deposit" : "Withdraw";

                // 2. منطق سداد العجز
                if (category.Contains("سداد عجز"))
                {
                    if (cmbCashier.SelectedValue == null) { MessageBox.Show("اختر الكاشير"); return; }
                    cashierID = cmbCashier.SelectedValue;
                    responsibleName = cmbCashier.Text;
                }
                else if (string.IsNullOrEmpty(responsibleName))
                {
                    MessageBox.Show("اكتب اسم المستلم"); return;
                }

                // 3. التحقق من رصيد الحساب (خزنة/فيزا) في حالة الصرف
                if (dbType == "Withdraw")
                {
                    DataRowView drv = (DataRowView)cmbAccount.SelectedItem;
                    decimal currentBal = Convert.ToDecimal(drv["CurrentBalance"]);
                    if (numAmount.Value > currentBal)
                    {
                        MessageBox.Show($"الرصيد الحالي ({currentBal}) لا يكفي!", "عجز في الحساب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // 4. الحفظ
                if (MessageBox.Show("تأكيد حفظ العملية؟", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    acc.AddFinancialTransaction(
                        Convert.ToInt32(cmbAccount.SelectedValue),
                        dbType,
                        category,
                        responsibleName,
                        numAmount.Value,
                        dtpDate.Value,
                        txtNotes.Text,
                        cashierID
                    );

                    MessageBox.Show("تم الحفظ وتحديث الرصيد بنجاح");
                   // this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show("حدث خطأ: " + ex.Message); }
        }

        private void cmbCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            // التحقق من أن الكومبو بوكس ظاهر وأن هناك قيمة مختارة فعلياً
            if (cmbCashier.Visible && cmbCashier.SelectedValue != null)
            {
                try
                {
                    //MessageBox.Show(cmbCashier.SelectedValue + "");
                    // جلب المديونية باستخدام الكلاس المختص
                    decimal debt = ALL_CASHIER.GetCashierRemainingDebt(Convert.ToInt32(cmbCashier.SelectedValue));
                   // MessageBox.Show(debt + "");
                    if (debt > 0)
                    {
                        lblCashierBalance.Text = "المديونية الحالية: " + debt.ToString("N2") + " ج.م";
                        lblCashierBalance.ForeColor = System.Drawing.Color.Red; // تنبيه باللون الأحمر
                        numAmount.Value = debt; // وضع المبلغ تلقائياً لتسهيل السداد
                    }
                    else
                    {
                        lblCashierBalance.Text = "لا توجد مديونية مستحقة";
                        lblCashierBalance.ForeColor = System.Drawing.Color.Green; // أخضر للدلالة على عدم وجود عجز
                        numAmount.Value = 0;
                    }

                    lblCashierBalance.Visible = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex + "");// في حالة حدوث خطأ أثناء التحميل أو التحويل
                    lblCashierBalance.Visible = false;
                }
            }
            else
            {
                lblCashierBalance.Visible = false;
            }
         
        }

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbAccount.SelectedValue != null && cmbAccount.SelectedIndex != -1)
                {
                    // بما إن DataSource الحسابات فيه CurrentBalance أصلاً، مش محتاجين نروح لقاعدة البيانات تاني!
                    // هنجيب البيانات من الكومبو بوكس نفسه (توفير أكتر للبروسيسور)
                    DataRowView drv = (DataRowView)cmbAccount.SelectedItem;
                    decimal currentBal = Convert.ToDecimal(drv["CurrentBalance"]);

                    lblAccountBalance.Text = "الرصيد الحالي في الحساب: " + currentBal.ToString("N2") + " ج.م";

                    // لو الرصيد صفر أو سالب نخليه أحمر للتنبيه
                    lblAccountBalance.ForeColor = currentBal <= 0 ? System.Drawing.Color.Red : System.Drawing.Color.Blue;
                }
            }
            catch { lblAccountBalance.Text = ""; }
        }

        private void numAmount_ValueChanged(object sender, EventArgs e)
        {
            UpdateAfterBalance();
        }

        void UpdateAfterBalance()
        {
            if (cmbAccount.SelectedValue == null || cmbTransType.SelectedIndex == -1) return;

            try
            {
                DataRowView drv = (DataRowView)cmbAccount.SelectedItem;
                decimal currentBal = Convert.ToDecimal(drv["CurrentBalance"]);
                decimal amount = numAmount.Value;
                decimal afterBal = 0;

                // تحديد هل العملية إيداع (Deposit) أم سحب (Withdraw)
                string category = cmbTransType.SelectedItem.ToString();
                if (category.Contains("قبض") || category.Contains("سداد عجز"))
                    afterBal = currentBal + amount;
                else
                    afterBal = currentBal - amount;

                lblAccountBalance.Text = $"الرصيد الحالي: {currentBal:N2} | الرصيد بعد العملية: {afterBal:N2}";

                // تنبيه لو الرصيد بعد العملية هيبقى سالب في حالة السحب
                if (afterBal < 0)
                    lblAccountBalance.ForeColor = System.Drawing.Color.Red;
                else
                    lblAccountBalance.ForeColor = System.Drawing.Color.Blue;
            }
            catch { }
        }
    }
}
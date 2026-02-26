using System;
using System.Data;
using System.Windows.Forms;
using Safe_Audit.BL;

namespace Safe_Audit.PL
{
    public partial class FRM_Transfers : Form
    {
        // استدعاء كلاس الحسابات من طبقة الـ Business
        // ملاحظة: تأكد من اسم الكلاس والمجلد عندك (غالباً يكون BL.AccountMethods أو حسب تسميتك)
        CLS_Accounts acc = new CLS_Accounts();

        public FRM_Transfers()
        {
            InitializeComponent();
            LoadAccounts();
        }

        // تحميل الحسابات في الـ ComboBox
        void LoadAccounts()
        {
            try
            {
                DataTable dtFrom = acc.Get_All_Accounts();
                DataTable dtTo = acc.Get_All_Accounts();

                // إعداد كومبو "من حساب"
                cmbFrom.DataSource = dtFrom;
                cmbFrom.DisplayMember = "MethodName";
                cmbFrom.ValueMember = "MethodID";

                // إعداد كومبو "إلى حساب"
                cmbTo.DataSource = dtTo;
                cmbTo.DisplayMember = "MethodName";
                cmbTo.ValueMember = "MethodID";

                // جعل الاختيار الافتراضي فارغ
                cmbFrom.SelectedIndex = -1;
                cmbTo.SelectedIndex = -1;
                lblBalance.Text = "رصيد الحساب: 0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في تحميل الحسابات: " + ex.Message);
            }
        }

        // إظهار رصيد الحساب المختار فوراً عند تغييره
        private void cmbFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            // الطريقة التقليدية المتوافقة مع كل النسخ
            if (cmbFrom.SelectedValue != null && cmbFrom.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbFrom.SelectedItem;
                lblBalance.Text = "رصيد الحساب الحالي: " + drv["CurrentBalance"].ToString() + " ج.م";
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // 1. التحقق من صحة البيانات
            if (cmbFrom.SelectedValue == null || cmbTo.SelectedValue == null)
            {
                MessageBox.Show("من فضلك اختر حساب المصدر وحساب الوجهة");
                return;
            }

            if (cmbFrom.SelectedValue.ToString() == cmbTo.SelectedValue.ToString())
            {
                MessageBox.Show("خطأ: لا يمكن التحويل لنفس الحساب");
                return;
            }

            if (numAmount.Value <= 0)
            {
                MessageBox.Show("من فضلك أدخل مبلغ التحويل");
                return;
            }

            // 2. التحقق من كفاية الرصيد (الرقابة المحاسبية)
            DataRowView drv = (DataRowView)cmbFrom.SelectedItem;
            decimal currentBalance = Convert.ToDecimal(drv["CurrentBalance"]);
            if (numAmount.Value > currentBalance)
            {
                MessageBox.Show("عفواً، رصيد الحساب المختار غير كافٍ لإتمام العملية");
                return;
            }

            // 3. تنفيذ التحويل
            try
            {
                if (MessageBox.Show("هل أنت متأكد من تنفيذ عملية التحويل؟", "تأكيد العملية", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // استدعاء الإجراء المخزن من الـ BL
                    acc.SP_MAKE_TRANSFER(
                        Convert.ToInt32(cmbFrom.SelectedValue),
                        Convert.ToInt32(cmbTo.SelectedValue),
                        numAmount.Value,
                        dtpDate.Value,
                        txtNotes.Text
                    );

                    MessageBox.Show("تمت عملية التحويل بنجاح وتحديث الأرصدة", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK; // لإخبار الفورم الرئيسي بعمل تحديث (Refresh)
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تنفيذ التحويل: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 1. دالة تعبئة الجدول بالبيانات
        void FillGrid()
        {
            try
            {
                // استدعاء الدالة من الـ Business Layer (التي سننشئها بالأسفل)
                DataTable dt = acc.Get_Transfers_By_Date(dtpSearch.Value);
                dgvTransfers.DataSource = dt;

                // تنسيق الأعمدة عشان تظهر بشكل احترافي
                if (dgvTransfers.Columns.Count > 0)
                {
                    dgvTransfers.Columns["TransferID"].Visible = false; // إخفاء رقم المعرف
                    dgvTransfers.Columns["FromAccount"].HeaderText = "من حساب";
                    dgvTransfers.Columns["ToAccount"].HeaderText = "إلى حساب";
                    dgvTransfers.Columns["Amount"].HeaderText = "المبلغ";
                    dgvTransfers.Columns["TransferDate"].HeaderText = "التاريخ";
                    dgvTransfers.Columns["Notes"].HeaderText = "ملاحظات";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في عرض سجل التحويلات: " + ex.Message);
            }
        }

        // 2. حدث زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}
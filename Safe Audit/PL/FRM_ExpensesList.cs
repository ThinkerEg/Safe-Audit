using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration; // للتأكد من قراءة Connection String

namespace Safe_Audit.PL
{
    public partial class FRM_ExpensesList : Form
    {
        // تعريف الأدوات اللازمة للربط
        BindingSource bs = new BindingSource();
        DataTable dt = new DataTable();

        public FRM_ExpensesList()
        {
            InitializeComponent();
        }

        // حدث إغلاق الفورم (الزرار X في التصميم اللي فات)
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // دالة جلب البيانات والبحث
        // استدعاء كلاس المصروفات من الـ BL
        BL.CLS_Expenses exp = new BL.CLS_Expenses();

        private void LoadData()
        {
            try
            {
                // استدعاء البيانات من الطبقة الوسيطة
                DataTable dt = exp.SearchExpenses(dtpFrom.Value.Date, dtpTo.Value.Date, txtSearch.Text);

                bs.DataSource = dt;
                dgvExpenses.DataSource = bs;
                bindingNavigator1.BindingSource = bs;

                // تعديل السطر ده عشان يقرأ اسم العمود العربي اللي في الـ SP
                object sumObject = dt.Compute("Sum([المبلغ])", string.Empty);
                decimal total = sumObject == DBNull.Value ? 0 : Convert.ToDecimal(sumObject);

                lblTotalAmount.Text = "إجمالي المصروفات: " + total.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ: " + ex.Message);
            }
        }
        //private void LoadData()
        //{
        //    try
        //    {
        //        // استدعاء الدالة من الـ BL وليس الـ DAL مباشرة
        //        DataTable dt = exp.SearchExpenses(dtpFrom.Value.Date, dtpTo.Value.Date.AddDays(1).AddSeconds(-1), txtSearch.Text);

        //        bs.DataSource = dt;
        //        dgvExpenses.DataSource = bs;
        //        bindingNavigator1.BindingSource = bs;

        //        // حساب الإجمالي
        //        decimal total = 0;
        //        if (dt.Rows.Count > 0)
        //            total = Convert.ToDecimal(dt.Compute("SUM(Amount)", string.Empty));

        //        lblTotalAmount.Text = "إجمالي المصروفات: " + total.ToString("N2");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("خطأ: " + ex.Message);
        //    }
        //}

        // عند تحميل الفورم
        private void FRM_ExpensesList_Load(object sender, EventArgs e)
        {
            // عرض مصروفات اليوم تلقائياً عند الفتح
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            LoadData();
        }

        // زر البحث
        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // البحث "أثناء الكتابة" في التكست بوكس
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
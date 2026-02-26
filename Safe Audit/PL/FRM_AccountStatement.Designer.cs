namespace Safe_Audit.PL
{
    partial class FRM_AccountStatement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStatement = new System.Windows.Forms.DataGridView();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFinalBalance = new System.Windows.Forms.Label();
            this.lblTotalOut = new System.Windows.Forms.Label();
            this.lblTotalIn = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(380, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "كشف حساب تفصيلي";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(12, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpFilters
            // 
            this.grpFilters.Controls.Add(this.btnShowReport);
            this.grpFilters.Controls.Add(this.dtpTo);
            this.grpFilters.Controls.Add(this.label3);
            this.grpFilters.Controls.Add(this.dtpFrom);
            this.grpFilters.Controls.Add(this.label2);
            this.grpFilters.Controls.Add(this.cmbAccount);
            this.grpFilters.Controls.Add(this.label1);
            this.grpFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFilters.Location = new System.Drawing.Point(0, 50);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(900, 80);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "خيارات العرض";
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.ForeColor = System.Drawing.Color.White;
            this.btnShowReport.Location = new System.Drawing.Point(40, 30);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(120, 30);
            this.btnShowReport.TabIndex = 6;
            this.btnShowReport.Text = "عرض التقرير";
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(191, 33);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(120, 25);
            this.dtpTo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "إلى:";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(377, 33);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(120, 25);
            this.dtpFrom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "من:";
            // 
            // cmbAccount
            // 
            this.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccount.FormattingEnabled = true;
            this.cmbAccount.Location = new System.Drawing.Point(578, 33);
            this.cmbAccount.Name = "cmbAccount";
            this.cmbAccount.Size = new System.Drawing.Size(220, 25);
            this.cmbAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(804, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "اختر الحساب:";
            // 
            // dgvStatement
            // 
            this.dgvStatement.AllowUserToAddRows = false;
            this.dgvStatement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatement.BackgroundColor = System.Drawing.Color.White;
            this.dgvStatement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStatement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStatement.Location = new System.Drawing.Point(0, 130);
            this.dgvStatement.Name = "dgvStatement";
            this.dgvStatement.ReadOnly = true;
            this.dgvStatement.RowHeadersVisible = false;
            this.dgvStatement.Size = new System.Drawing.Size(900, 420);
            this.dgvStatement.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.pnlFooter.Controls.Add(this.lblTotalIn);
            this.pnlFooter.Controls.Add(this.lblTotalOut);
            this.pnlFooter.Controls.Add(this.lblFinalBalance);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 550);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(900, 50);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblFinalBalance
            // 
            this.lblFinalBalance.AutoSize = true;
            this.lblFinalBalance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinalBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblFinalBalance.Location = new System.Drawing.Point(40, 15);
            this.lblFinalBalance.Name = "lblFinalBalance";
            this.lblFinalBalance.Size = new System.Drawing.Size(231, 21);
            this.lblFinalBalance.TabIndex = 0;
            this.lblFinalBalance.Text = "إجمالي الرصيد في هذه الفترة: 0.00";
            // 
            // lblTotalOut
            // 
            this.lblTotalOut.AutoSize = true;
            this.lblTotalOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblTotalOut.Location = new System.Drawing.Point(335, 15);
            this.lblTotalOut.Name = "lblTotalOut";
            this.lblTotalOut.Size = new System.Drawing.Size(231, 21);
            this.lblTotalOut.TabIndex = 1;
            this.lblTotalOut.Text = "إجمالي الرصيد في هذه الفترة: 0.00";
            // 
            // lblTotalIn
            // 
            this.lblTotalIn.AutoSize = true;
            this.lblTotalIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblTotalIn.Location = new System.Drawing.Point(625, 15);
            this.lblTotalIn.Name = "lblTotalIn";
            this.lblTotalIn.Size = new System.Drawing.Size(231, 21);
            this.lblTotalIn.TabIndex = 2;
            this.lblTotalIn.Text = "إجمالي الرصيد في هذه الفترة: 0.00";
            // 
            // FRM_AccountStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvStatement);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_AccountStatement";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_AccountStatement_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatement)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.ComboBox cmbAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.DataGridView dgvStatement;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFinalBalance;
        private System.Windows.Forms.Label lblTotalIn;
        private System.Windows.Forms.Label lblTotalOut;
    }
}
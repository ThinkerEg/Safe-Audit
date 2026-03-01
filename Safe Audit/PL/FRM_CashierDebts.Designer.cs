namespace Safe_Audit.PL
{
    partial class FRM_CashierDebts
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblNetDebt = new System.Windows.Forms.Label();
            this.lblTotalPaid = new System.Windows.Forms.Label();
            this.lblTotalShortage = new System.Windows.Forms.Label();
            this.cmbCashiers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransactions = new System.Windows.Forms.DataGridView();
            this.btnPayShortcut = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(686, 43);
            this.pnlHeader.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(257, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "كشف حساب مديونيات الكاشير";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(10, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 26);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSummary.Controls.Add(this.lblNetDebt);
            this.pnlSummary.Controls.Add(this.lblTotalPaid);
            this.pnlSummary.Controls.Add(this.lblTotalShortage);
            this.pnlSummary.Location = new System.Drawing.Point(17, 95);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(651, 69);
            this.pnlSummary.TabIndex = 2;
            // 
            // lblNetDebt
            // 
            this.lblNetDebt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNetDebt.Location = new System.Drawing.Point(17, 26);
            this.lblNetDebt.Name = "lblNetDebt";
            this.lblNetDebt.Size = new System.Drawing.Size(171, 22);
            this.lblNetDebt.TabIndex = 0;
            this.lblNetDebt.Text = "صافي المديونية: 0.00";
            // 
            // lblTotalPaid
            // 
            this.lblTotalPaid.Location = new System.Drawing.Point(0, 0);
            this.lblTotalPaid.Name = "lblTotalPaid";
            this.lblTotalPaid.Size = new System.Drawing.Size(86, 20);
            this.lblTotalPaid.TabIndex = 1;
            // 
            // lblTotalShortage
            // 
            this.lblTotalShortage.Location = new System.Drawing.Point(0, 0);
            this.lblTotalShortage.Name = "lblTotalShortage";
            this.lblTotalShortage.Size = new System.Drawing.Size(86, 20);
            this.lblTotalShortage.TabIndex = 2;
            // 
            // cmbCashiers
            // 
            this.cmbCashiers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCashiers.FormattingEnabled = true;
            this.cmbCashiers.Location = new System.Drawing.Point(429, 61);
            this.cmbCashiers.Name = "cmbCashiers";
            this.cmbCashiers.Size = new System.Drawing.Size(172, 21);
            this.cmbCashiers.TabIndex = 3;
            this.cmbCashiers.SelectedIndexChanged += new System.EventHandler(this.cmbCashiers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransactions.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransactions.Location = new System.Drawing.Point(17, 173);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.Size = new System.Drawing.Size(651, 260);
            this.dgvTransactions.TabIndex = 1;
            // 
            // btnPayShortcut
            // 
            this.btnPayShortcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnPayShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayShortcut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPayShortcut.ForeColor = System.Drawing.Color.White;
            this.btnPayShortcut.Location = new System.Drawing.Point(17, 442);
            this.btnPayShortcut.Name = "btnPayShortcut";
            this.btnPayShortcut.Size = new System.Drawing.Size(171, 35);
            this.btnPayShortcut.TabIndex = 0;
            this.btnPayShortcut.Text = "إضافة سداد جديد (F2)";
            this.btnPayShortcut.UseVisualStyleBackColor = false;
            this.btnPayShortcut.Click += new System.EventHandler(this.btnPayShortcut_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(0, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            // 
            // FRM_CashierDebts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 494);
            this.Controls.Add(this.btnPayShortcut);
            this.Controls.Add(this.dgvTransactions);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.cmbCashiers);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CashierDebts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblTotalShortage;
        private System.Windows.Forms.Label lblTotalPaid;
        private System.Windows.Forms.Label lblNetDebt;
        private System.Windows.Forms.ComboBox cmbCashiers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransactions;
        private System.Windows.Forms.Button btnPayShortcut;
        private System.Windows.Forms.Button btnRefresh;
    }
}
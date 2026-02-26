namespace Safe_Audit.PL
{
    partial class FRM_Transfers
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFrom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTo = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.grpLogs = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearch = new System.Windows.Forms.DateTimePicker();
            this.dgvTransfers = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.grpLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(850, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(360, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "تحويل مالي داخلي";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "من حساب :";
            // 
            // cmbFrom
            // 
            this.cmbFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFrom.FormattingEnabled = true;
            this.cmbFrom.Location = new System.Drawing.Point(490, 95);
            this.cmbFrom.Name = "cmbFrom";
            this.cmbFrom.Size = new System.Drawing.Size(320, 25);
            this.cmbFrom.TabIndex = 10;
            this.cmbFrom.SelectedIndexChanged += new System.EventHandler(this.cmbFrom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(740, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "إلى حساب :";
            // 
            // cmbTo
            // 
            this.cmbTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTo.FormattingEnabled = true;
            this.cmbTo.Location = new System.Drawing.Point(490, 180);
            this.cmbTo.Name = "cmbTo";
            this.cmbTo.Size = new System.Drawing.Size(320, 25);
            this.cmbTo.TabIndex = 7;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.Green;
            this.lblBalance.Location = new System.Drawing.Point(490, 125);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(95, 17);
            this.lblBalance.TabIndex = 9;
            this.lblBalance.Text = "رصيد الحساب: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(760, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "المبلغ :";
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.Location = new System.Drawing.Point(490, 260);
            this.numAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(320, 25);
            this.numAmount.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "التاريخ :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(490, 330);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(320, 25);
            this.dtpDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(750, 380);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "ملاحظات :";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(490, 400);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(320, 60);
            this.txtNotes.TabIndex = 1;
            // 
            // btnTransfer
            // 
            this.btnTransfer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTransfer.ForeColor = System.Drawing.Color.White;
            this.btnTransfer.Location = new System.Drawing.Point(490, 480);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(320, 40);
            this.btnTransfer.TabIndex = 0;
            this.btnTransfer.Text = "تفيذ عملية التحويل";
            this.btnTransfer.UseVisualStyleBackColor = false;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // grpLogs
            // 
            this.grpLogs.Controls.Add(this.label6);
            this.grpLogs.Controls.Add(this.btnSearch);
            this.grpLogs.Controls.Add(this.dtpSearch);
            this.grpLogs.Controls.Add(this.dgvTransfers);
            this.grpLogs.Location = new System.Drawing.Point(12, 60);
            this.grpLogs.Name = "grpLogs";
            this.grpLogs.Size = new System.Drawing.Size(460, 460);
            this.grpLogs.TabIndex = 12;
            this.grpLogs.TabStop = false;
            this.grpLogs.Text = "سجل التحويلات المنفذة";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "بحث بتاريخ اليوم:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(124, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearch
            // 
            this.dtpSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearch.Location = new System.Drawing.Point(215, 27);
            this.dtpSearch.Name = "dtpSearch";
            this.dtpSearch.Size = new System.Drawing.Size(130, 25);
            this.dtpSearch.TabIndex = 1;
            // 
            // dgvTransfers
            // 
            this.dgvTransfers.AllowUserToAddRows = false;
            this.dgvTransfers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransfers.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransfers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransfers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransfers.Location = new System.Drawing.Point(6, 65);
            this.dgvTransfers.MultiSelect = false;
            this.dgvTransfers.Name = "dgvTransfers";
            this.dgvTransfers.ReadOnly = true;
            this.dgvTransfers.RowHeadersVisible = false;
            this.dgvTransfers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransfers.Size = new System.Drawing.Size(448, 389);
            this.dgvTransfers.TabIndex = 0;
            // 
            // FRM_Transfers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.grpLogs);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.cmbFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Transfers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.grpLogs.ResumeLayout(false);
            this.grpLogs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransfers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.GroupBox grpLogs;
        private System.Windows.Forms.DataGridView dgvTransfers;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpSearch;
        private System.Windows.Forms.Label label6;
    }
}
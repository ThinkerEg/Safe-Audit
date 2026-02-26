namespace Safe_Audit.PL
{
    partial class FRM_Main
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnSettlement = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTransfers = new System.Windows.Forms.Button();
            this.btnStatement = new System.Windows.Forms.Button();
            this.btnAccounts = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlSidebar.Controls.Add(this.btnSettlement);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Controls.Add(this.btnTransfers);
            this.pnlSidebar.Controls.Add(this.btnStatement);
            this.pnlSidebar.Controls.Add(this.btnAccounts);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Location = new System.Drawing.Point(600, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(200, 450);
            this.pnlSidebar.TabIndex = 1;
            // 
            // btnSettlement
            // 
            this.btnSettlement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettlement.FlatAppearance.BorderSize = 0;
            this.btnSettlement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlement.ForeColor = System.Drawing.Color.White;
            this.btnSettlement.Location = new System.Drawing.Point(0, 180);
            this.btnSettlement.Name = "btnSettlement";
            this.btnSettlement.Size = new System.Drawing.Size(200, 60);
            this.btnSettlement.TabIndex = 4;
            this.btnSettlement.Text = "إضافة تسوية مالية";
            this.btnSettlement.Click += new System.EventHandler(this.btnSettlement_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Salmon;
            this.btnExit.Location = new System.Drawing.Point(0, 390);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTransfers
            // 
            this.btnTransfers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfers.FlatAppearance.BorderSize = 0;
            this.btnTransfers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfers.ForeColor = System.Drawing.Color.White;
            this.btnTransfers.Location = new System.Drawing.Point(0, 120);
            this.btnTransfers.Name = "btnTransfers";
            this.btnTransfers.Size = new System.Drawing.Size(200, 60);
            this.btnTransfers.TabIndex = 1;
            this.btnTransfers.Text = "التحويلات المالية";
            this.btnTransfers.Click += new System.EventHandler(this.btnTransfers_Click);
            this.btnTransfers.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnTransfers.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnStatement
            // 
            this.btnStatement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatement.FlatAppearance.BorderSize = 0;
            this.btnStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatement.ForeColor = System.Drawing.Color.White;
            this.btnStatement.Location = new System.Drawing.Point(0, 60);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Size = new System.Drawing.Size(200, 60);
            this.btnStatement.TabIndex = 2;
            this.btnStatement.Text = "كشف الحساب";
            this.btnStatement.Click += new System.EventHandler(this.btnAccountStatement_Click);
            this.btnStatement.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnStatement.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.ForeColor = System.Drawing.Color.White;
            this.btnAccounts.Location = new System.Drawing.Point(0, 0);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(200, 60);
            this.btnAccounts.TabIndex = 3;
            this.btnAccounts.Text = "إدارة الحسابات";
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            this.btnAccounts.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnAccounts.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(600, 60);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(400, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "نظام الخزينة والتدقيق";
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Main";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.Button btnStatement;
        private System.Windows.Forms.Button btnTransfers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSettlement;
    }
}
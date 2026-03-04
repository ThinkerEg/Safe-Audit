namespace Safe_Audit.PL
{
    partial class FRM_CONFIG
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
            this.grpServerInfo = new System.Windows.Forms.GroupBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLoginMode = new System.Windows.Forms.GroupBox();
            this.rbSQL = new System.Windows.Forms.RadioButton();
            this.rbWindows = new System.Windows.Forms.RadioButton();
            this.pl_SQL = new System.Windows.Forms.Panel();
            this.txt_PWD_con = new System.Windows.Forms.TextBox();
            this.txt_ID_con = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save_con = new System.Windows.Forms.Button();
            this.btn_test_con = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtBackup = new System.Windows.Forms.TextBox();
            this.btn_SelectBackupPath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlHeader.SuspendLayout();
            this.grpServerInfo.SuspendLayout();
            this.grpLoginMode.SuspendLayout();
            this.pl_SQL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(450, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(104, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(218, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "إعدادات الاتصال بالسيرفر";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpServerInfo
            // 
            this.grpServerInfo.Controls.Add(this.txtDatabase);
            this.grpServerInfo.Controls.Add(this.txtServer);
            this.grpServerInfo.Controls.Add(this.label2);
            this.grpServerInfo.Controls.Add(this.label1);
            this.grpServerInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpServerInfo.Location = new System.Drawing.Point(25, 65);
            this.grpServerInfo.Name = "grpServerInfo";
            this.grpServerInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpServerInfo.Size = new System.Drawing.Size(400, 150);
            this.grpServerInfo.TabIndex = 1;
            this.grpServerInfo.TabStop = false;
            this.grpServerInfo.Text = "بيانات السيرفر";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDatabase.Location = new System.Drawing.Point(20, 105);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(360, 29);
            this.txtDatabase.TabIndex = 1;
            this.txtDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtServer
            // 
            this.txtServer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtServer.Location = new System.Drawing.Point(20, 50);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(360, 29);
            this.txtServer.TabIndex = 0;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "قاعدة البيانات:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "اسم السيرفر:";
            // 
            // grpLoginMode
            // 
            this.grpLoginMode.Controls.Add(this.rbSQL);
            this.grpLoginMode.Controls.Add(this.rbWindows);
            this.grpLoginMode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpLoginMode.Location = new System.Drawing.Point(25, 225);
            this.grpLoginMode.Name = "grpLoginMode";
            this.grpLoginMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpLoginMode.Size = new System.Drawing.Size(400, 70);
            this.grpLoginMode.TabIndex = 2;
            this.grpLoginMode.TabStop = false;
            this.grpLoginMode.Text = "طريقة الولوج";
            // 
            // rbSQL
            // 
            this.rbSQL.AutoSize = true;
            this.rbSQL.Location = new System.Drawing.Point(30, 30);
            this.rbSQL.Name = "rbSQL";
            this.rbSQL.Size = new System.Drawing.Size(163, 24);
            this.rbSQL.TabIndex = 1;
            this.rbSQL.Text = "SQL Authentication";
            this.rbSQL.UseVisualStyleBackColor = true;
            this.rbSQL.CheckedChanged += new System.EventHandler(this.rbSQL_CheckedChanged);
            // 
            // rbWindows
            // 
            this.rbWindows.AutoSize = true;
            this.rbWindows.Checked = true;
            this.rbWindows.Location = new System.Drawing.Point(200, 30);
            this.rbWindows.Name = "rbWindows";
            this.rbWindows.Size = new System.Drawing.Size(201, 24);
            this.rbWindows.TabIndex = 0;
            this.rbWindows.TabStop = true;
            this.rbWindows.Text = "Windows Authentication";
            this.rbWindows.UseVisualStyleBackColor = true;
            // 
            // pl_SQL
            // 
            this.pl_SQL.Controls.Add(this.txt_PWD_con);
            this.pl_SQL.Controls.Add(this.txt_ID_con);
            this.pl_SQL.Controls.Add(this.label4);
            this.pl_SQL.Controls.Add(this.label5);
            this.pl_SQL.Location = new System.Drawing.Point(25, 301);
            this.pl_SQL.Name = "pl_SQL";
            this.pl_SQL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pl_SQL.Size = new System.Drawing.Size(400, 110);
            this.pl_SQL.TabIndex = 3;
            this.pl_SQL.Visible = false;
            // 
            // txt_PWD_con
            // 
            this.txt_PWD_con.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_PWD_con.Location = new System.Drawing.Point(20, 75);
            this.txt_PWD_con.Name = "txt_PWD_con";
            this.txt_PWD_con.PasswordChar = '*';
            this.txt_PWD_con.Size = new System.Drawing.Size(360, 29);
            this.txt_PWD_con.TabIndex = 1;
            this.txt_PWD_con.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ID_con
            // 
            this.txt_ID_con.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_ID_con.Location = new System.Drawing.Point(20, 25);
            this.txt_ID_con.Name = "txt_ID_con";
            this.txt_ID_con.Size = new System.Drawing.Size(360, 29);
            this.txt_ID_con.TabIndex = 0;
            this.txt_ID_con.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "كلمة المرور:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "اسم المستخدم:";
            // 
            // btn_Save_con
            // 
            this.btn_Save_con.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btn_Save_con.FlatAppearance.BorderSize = 0;
            this.btn_Save_con.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save_con.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Save_con.ForeColor = System.Drawing.Color.White;
            this.btn_Save_con.Location = new System.Drawing.Point(25, 485);
            this.btn_Save_con.Name = "btn_Save_con";
            this.btn_Save_con.Size = new System.Drawing.Size(400, 50);
            this.btn_Save_con.TabIndex = 4;
            this.btn_Save_con.Text = "حفظ الإعدادات ✅";
            this.btn_Save_con.UseVisualStyleBackColor = false;
            this.btn_Save_con.Click += new System.EventHandler(this.btn_Save_con_Click);
            // 
            // btn_test_con
            // 
            this.btn_test_con.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btn_test_con.FlatAppearance.BorderSize = 0;
            this.btn_test_con.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_test_con.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btn_test_con.ForeColor = System.Drawing.Color.White;
            this.btn_test_con.Location = new System.Drawing.Point(230, 545);
            this.btn_test_con.Name = "btn_test_con";
            this.btn_test_con.Size = new System.Drawing.Size(195, 45);
            this.btn_test_con.TabIndex = 5;
            this.btn_test_con.Text = "إختبار الاتصال ⚡";
            this.btn_test_con.UseVisualStyleBackColor = false;
            this.btn_test_con.Click += new System.EventHandler(this.btn_test_con_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(25, 545);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(195, 45);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtBackup
            // 
            this.txtBackup.BackColor = System.Drawing.Color.White;
            this.txtBackup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBackup.Location = new System.Drawing.Point(135, 435);
            this.txtBackup.Name = "txtBackup";
            this.txtBackup.ReadOnly = true;
            this.txtBackup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBackup.Size = new System.Drawing.Size(290, 25);
            this.txtBackup.TabIndex = 7;
            // 
            // btn_SelectBackupPath
            // 
            this.btn_SelectBackupPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btn_SelectBackupPath.FlatAppearance.BorderSize = 0;
            this.btn_SelectBackupPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectBackupPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_SelectBackupPath.ForeColor = System.Drawing.Color.White;
            this.btn_SelectBackupPath.Location = new System.Drawing.Point(25, 435);
            this.btn_SelectBackupPath.Name = "btn_SelectBackupPath";
            this.btn_SelectBackupPath.Size = new System.Drawing.Size(100, 25);
            this.btn_SelectBackupPath.TabIndex = 8;
            this.btn_SelectBackupPath.Text = "مسار النسخ";
            this.btn_SelectBackupPath.UseVisualStyleBackColor = false;
            this.btn_SelectBackupPath.Click += new System.EventHandler(this.btn_SelectBackupPath_Click);
            // 
            // FRM_CONFIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(450, 610);
            this.Controls.Add(this.btn_SelectBackupPath);
            this.Controls.Add(this.txtBackup);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btn_test_con);
            this.Controls.Add(this.btn_Save_con);
            this.Controls.Add(this.pl_SQL);
            this.Controls.Add(this.grpLoginMode);
            this.Controls.Add(this.grpServerInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_CONFIG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_CONFIG_Load);
            this.pnlHeader.ResumeLayout(false);
            this.grpServerInfo.ResumeLayout(false);
            this.grpServerInfo.PerformLayout();
            this.grpLoginMode.ResumeLayout(false);
            this.grpLoginMode.PerformLayout();
            this.pl_SQL.ResumeLayout(false);
            this.pl_SQL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpServerInfo;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpLoginMode;
        private System.Windows.Forms.RadioButton rbSQL;
        private System.Windows.Forms.RadioButton rbWindows;
        private System.Windows.Forms.Panel pl_SQL;
        private System.Windows.Forms.TextBox txt_PWD_con;
        private System.Windows.Forms.TextBox txt_ID_con;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save_con;
        private System.Windows.Forms.Button btn_test_con;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtBackup;
        private System.Windows.Forms.Button btn_SelectBackupPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
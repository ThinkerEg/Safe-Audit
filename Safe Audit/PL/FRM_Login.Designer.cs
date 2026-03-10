
    namespace Safe_Audit.PL
    {
        partial class FRM_Login
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelLine = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btn_connect = new System.Windows.Forms.LinkLabel();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Location = new System.Drawing.Point(50, 253);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(300, 35);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(50, 318);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 45);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "دخول النظام";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.Location = new System.Drawing.Point(150, 369);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "إغلاق";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelLine
            // 
            this.panelLine.Location = new System.Drawing.Point(0, 0);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(200, 100);
            this.panelLine.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackgroundImage = global::Safe_Audit.Properties.Resources.BigShawarma;
            this.pnlHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlHeader.Controls.Add(this.btn_connect);
            this.pnlHeader.Controls.Add(this.comboBoxUsers);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.txtPassword);
            this.pnlHeader.Controls.Add(this.btnLogin);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(400, 430);
            this.pnlHeader.TabIndex = 5;
            // 
            // btn_connect
            // 
            this.btn_connect.AutoSize = true;
            this.btn_connect.LinkColor = System.Drawing.Color.White;
            this.btn_connect.Location = new System.Drawing.Point(22, 396);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(77, 13);
            this.btn_connect.TabIndex = 31;
            this.btn_connect.TabStop = true;
            this.btn_connect.Text = "اعدادات الاتصال";
            this.btn_connect.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_connect_LinkClicked);
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxUsers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxUsers.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.IntegralHeight = false;
            this.comboBoxUsers.Location = new System.Drawing.Point(50, 205);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(300, 27);
            this.comboBoxUsers.TabIndex = 30;
            // 
            // FRM_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(400, 430);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRM_Login_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion
            private System.Windows.Forms.TextBox txtPassword;
            private System.Windows.Forms.Button btnLogin;
            private System.Windows.Forms.Button btnExit;
            private System.Windows.Forms.Panel panelLine;
            private System.Windows.Forms.Panel pnlHeader;
            private System.Windows.Forms.ComboBox comboBoxUsers;
            private System.Windows.Forms.LinkLabel btn_connect;
        }
    }
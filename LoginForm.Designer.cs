namespace tagUMpay
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;

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
            lblTitle = new System.Windows.Forms.Label();
            lblSubtitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            chkShowPassword = new System.Windows.Forms.CheckBox();
            btnLogin = new System.Windows.Forms.Button();
            lblError = new System.Windows.Forms.Label();
            SuspendLayout();

            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(95, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Text = "tagUMpay";

            // lblSubtitle
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            lblSubtitle.Location = new System.Drawing.Point(62, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "Payroll and Attendance Management";

            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(40, 115);
            lblUsername.Name = "lblUsername";
            lblUsername.Text = "Username";

            // txtUsername
            txtUsername.Location = new System.Drawing.Point(40, 138);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new System.Drawing.Size(260, 27);
            txtUsername.TabIndex = 0;

            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(40, 180);
            lblPassword.Name = "lblPassword";
            lblPassword.Text = "Password";

            // txtPassword
            txtPassword.Location = new System.Drawing.Point(40, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new System.Drawing.Size(260, 27);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;

            // chkShowPassword
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new System.Drawing.Point(40, 238);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.TabIndex = 2;
            chkShowPassword.Text = "Show password";
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            // btnLogin
            btnLogin.Location = new System.Drawing.Point(40, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(260, 38);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;

            // lblError
            lblError.ForeColor = System.Drawing.Color.Firebrick;
            lblError.Location = new System.Drawing.Point(40, 322);
            lblError.Name = "lblError";
            lblError.Size = new System.Drawing.Size(260, 40);
            lblError.Text = "";
            lblError.Visible = false;

            // LoginForm
            AcceptButton = btnLogin;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(340, 380);
            Controls.Add(lblTitle);
            Controls.Add(lblSubtitle);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(chkShowPassword);
            Controls.Add(btnLogin);
            Controls.Add(lblError);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "tagUMpay - Login";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}

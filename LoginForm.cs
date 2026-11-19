using System;
using System.Drawing;
using System.Windows.Forms;

namespace tagUMpay
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblMessage;

        public LoginForm()
        {
            SetupUI();
        }

        private void SetupUI()
        {
            Text = "tagUMpay - Login";
            Size = new Size(400, 330);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.White;

            Panel headerPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 70,
                BackColor = Color.FromArgb(122, 28, 28)
            };

            Label lblBrand = new Label
            {
                Text = "tagUMpay",
                ForeColor = Color.FromArgb(201, 154, 46),
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 10)
            };

            Label lblSub = new Label
            {
                Text = "Employee Payroll & Attendance Management",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8.5f),
                AutoSize = true,
                Location = new Point(22, 43)
            };

            headerPanel.Controls.Add(lblBrand);
            headerPanel.Controls.Add(lblSub);

            Label lblUser = new Label
            {
                Text = "Username",
                Location = new Point(40, 92),
                AutoSize = true
            };

            txtUsername = new TextBox
            {
                Location = new Point(40, 114),
                Width = 300,
                Font = new Font("Segoe UI", 10)
            };

            Label lblPass = new Label
            {
                Text = "Password",
                Location = new Point(40, 152),
                AutoSize = true
            };

            txtPassword = new TextBox
            {
                Location = new Point(40, 174),
                Width = 300,
                Font = new Font("Segoe UI", 10),
                UseSystemPasswordChar = true
            };

            lblMessage = new Label
            {
                ForeColor = Color.Firebrick,
                Location = new Point(40, 208),
                Size = new Size(300, 20)
            };

            btnLogin = new Button
            {
                Text = "LOG IN",
                Location = new Point(40, 236),
                Size = new Size(300, 36),
                BackColor = Color.FromArgb(122, 28, 28),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnLogin.Click += BtnLogin_Click;

            Controls.Add(headerPanel);
            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(lblPass);
            Controls.Add(txtPassword);
            Controls.Add(lblMessage);
            Controls.Add(btnLogin);

            AcceptButton = btnLogin;
        }

        private User FindSampleAccount(string username)
        {
            if (username == "admin")
            {
                Admin admin = new Admin();
                admin.UserId = 1;
                admin.AdminId = 1;
                admin.Username = "admin";
                admin.PasswordHash = "admin123";
                return admin;
            }

            if (username == "jdelacruz")
            {
                Employee emp = new Employee();
                emp.UserId = 2;
                emp.EmployeeId = 101;
                emp.Username = "jdelacruz";
                emp.PasswordHash = "emp123";
                emp.FullName = "Juan Dela Cruz";
                emp.PositionId = 1;
                emp.ContactInfo = "0917-555-0101";
                emp.EmploymentStatus = "Regular";
                return emp;
            }

            return null;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";

            User currentUser = FindSampleAccount(txtUsername.Text.Trim());

            if (currentUser == null)
            {
                lblMessage.Text = "Invalid username or password.";
                return;
            }

            currentUser.SetEnteredPassword(txtPassword.Text);

            if (!currentUser.authenticate())
            {
                lblMessage.Text = "Invalid username or password.";
                return;
            }

            txtPassword.Clear();
            Hide();
            currentUser.getDashboardOptions();
            Show();
        }
    }
}
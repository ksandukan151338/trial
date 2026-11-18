using System;
using System.Drawing;
using System.Windows.Forms;

namespace tagUMpay
{
    public class AdminDashboardForm : Form
    {
        private Admin currentAdmin;

        public AdminDashboardForm(Admin admin)
        {
            currentAdmin = admin;
            SetupUI();
        }

        private void SetupUI()
        {
            Text = "tagUMpay - Administrator Dashboard";
            Size = new Size(620, 420);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 60,
                BackColor = Color.FromArgb(122, 28, 28)
            };

            Label lblTitle = new Label
            {
                Text = "Administrator Dashboard",
                ForeColor = Color.FromArgb(201, 154, 46),
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(20, 16)
            };

            Button btnLogout = new Button
            {
                Text = "Logout",
                Location = new Point(500, 16),
                Size = new Size(85, 28),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(122, 28, 28),
                FlatStyle = FlatStyle.Flat
            };
            btnLogout.Click += (s, e) => Close();

            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnLogout);

            Label lblWelcome = new Label
            {
                Text = "Logged in as: " + currentAdmin.Username + " (Admin ID: " + currentAdmin.AdminId + ")",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(25, 80),
                AutoSize = true
            };

            Label lblPrompt = new Label
            {
                Text = "Select an administrative operation:",
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(25, 110),
                AutoSize = true
            };

            Button btnAddEmp = CreateMenuButton("Add Employee", 25, 145);
            btnAddEmp.Click += (s, e) => currentAdmin.addEmployee();

            Button btnUpdateEmp = CreateMenuButton("Update Employee", 215, 145);
            btnUpdateEmp.Click += (s, e) => currentAdmin.updateEmployee();

            Button btnDeleteEmp = CreateMenuButton("Delete Employee", 405, 145);
            btnDeleteEmp.Click += (s, e) => currentAdmin.deleteEmployee();

            Button btnAttendance = CreateMenuButton("Record Attendance", 25, 210);
            btnAttendance.Click += (s, e) => currentAdmin.recordAttendance();

            Button btnPayroll = CreateMenuButton("Prepare Payroll", 215, 210);
            btnPayroll.Click += (s, e) => currentAdmin.preparePayroll();

            Controls.Add(topPanel);
            Controls.Add(lblWelcome);
            Controls.Add(lblPrompt);
            Controls.Add(btnAddEmp);
            Controls.Add(btnUpdateEmp);
            Controls.Add(btnDeleteEmp);
            Controls.Add(btnAttendance);
            Controls.Add(btnPayroll);
        }

        private Button CreateMenuButton(string text, int x, int y)
        {
            return new Button
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(175, 45),
                BackColor = Color.FromArgb(245, 240, 240),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold)
            };
        }
    }
}
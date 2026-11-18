using System;
using System.Drawing;
using System.Windows.Forms;

namespace tagUMpay
{
    public class EmployeeDashboardForm : Form
    {
        private Employee currentEmployee;

        public EmployeeDashboardForm(Employee employee)
        {
            currentEmployee = employee;
            SetupUI();
        }

        private void SetupUI()
        {
            Text = "tagUMpay - Employee Self-Service Portal";
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
                Text = "Employee Self-Service Portal",
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

            GroupBox grpProfile = new GroupBox
            {
                Text = "Personal Employment Details",
                Location = new Point(25, 80),
                Size = new Size(555, 145),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold)
            };

            Label lblDetails = new Label
            {
                Text =
                    "Employee ID: " + currentEmployee.EmployeeId + "\n" +
                    "Full Name: " + currentEmployee.FullName + "\n" +
                    "Position ID: " + currentEmployee.PositionId + "\n" +
                    "Contact Info: " + currentEmployee.ContactInfo + "\n" +
                    "Employment Status: " + currentEmployee.EmploymentStatus,
                Location = new Point(15, 28),
                Size = new Size(520, 105),
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular)
            };
            grpProfile.Controls.Add(lblDetails);

            Button btnViewAttendance = new Button
            {
                Text = "View My Attendance",
                Location = new Point(25, 250),
                Size = new Size(265, 45),
                BackColor = Color.FromArgb(245, 240, 240),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold)
            };
            btnViewAttendance.Click += (s, e) => currentEmployee.viewAttendance();

            Button btnViewPayroll = new Button
            {
                Text = "View My Payroll",
                Location = new Point(315, 250),
                Size = new Size(265, 45),
                BackColor = Color.FromArgb(245, 240, 240),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold)
            };
            btnViewPayroll.Click += (s, e) => currentEmployee.viewPayroll();

            Controls.Add(topPanel);
            Controls.Add(grpProfile);
            Controls.Add(btnViewAttendance);
            Controls.Add(btnViewPayroll);
        }
    }
}
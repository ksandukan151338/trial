using System.Windows.Forms;

namespace tagUMpay
{
    public class Admin : User
    {
        private int adminId;

        public int AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }

        public void addEmployee()
        {
            MessageBox.Show("Add Employee module opened.", "Admin Action");
        }

        public void updateEmployee()
        {
            MessageBox.Show("Update Employee module opened.", "Admin Action");
        }

        public void deleteEmployee()
        {
            MessageBox.Show("Delete Employee module opened.", "Admin Action");
        }

        public void recordAttendance()
        {
            MessageBox.Show("Record Attendance module opened.", "Admin Action");
        }

        public void preparePayroll()
        {
            MessageBox.Show("Prepare Payroll module opened.", "Admin Action");
        }

        public override void getDashboardOptions()
        {
            AdminDashboardForm adminForm = new AdminDashboardForm(this);
            adminForm.ShowDialog();
        }
    }
}
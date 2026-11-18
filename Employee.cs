using System.Windows.Forms;

namespace tagUMpay
{
    public class Employee : User
    {
        private int employeeId;
        private string? fullName;
        private int positionId;
        private string? contactInfo;
        private string? employmentStatus;

        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public int PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }

        public string EmploymentStatus
        {
            get { return employmentStatus; }
            set { employmentStatus = value; }
        }

        public void viewAttendance()
        {
            MessageBox.Show("Displaying personal attendance summary for " + fullName + ".", "Employee Self-Service");
        }

        public void viewPayroll()
        {
            MessageBox.Show("Displaying historical payroll records for " + fullName + ".", "Employee Self-Service");
        }

        public override void getDashboardOptions()
        {
            EmployeeDashboardForm employeeForm = new EmployeeDashboardForm(this);
            employeeForm.ShowDialog();
        }
    }
}
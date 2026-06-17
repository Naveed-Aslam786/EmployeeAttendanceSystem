using System;
using System.Windows.Forms;

namespace EmployeeAttendanceSystem.Forms
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        // Open Employee Form
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            EmployeeForm employee = new EmployeeForm();
            employee.ShowDialog();
        }

        // Open Attendance Form
        private void btnAttendance_Click(object sender, EventArgs e)
        {
            AttendanceForm attendance = new AttendanceForm();
            attendance.ShowDialog();
        }

        // Open Report Form
        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportForm report = new ReportForm();
            report.ShowDialog();
        }

        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

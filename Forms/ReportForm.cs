using System;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using EmployeeAttendanceSystem.Database;

namespace EmployeeAttendanceSystem.Forms
{
    public partial class ReportForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();
        PrintDocument printDocument = new PrintDocument();

        public ReportForm()
        {
            InitializeComponent();

            LoadReport();
            LoadStatistics();

            printDocument.PrintPage += PrintDocument_PrintPage;
        }
        private void LoadStatistics()
        {
            lblTotal.Text =
                "Total: " +
                db.ExecuteScalar("SELECT COUNT(*) FROM Employees");

            lblPresent.Text =
                "Present: " +
                db.ExecuteScalar("SELECT COUNT(*) FROM Attendance WHERE Status='Present'");

            lblAbsent.Text =
                "Absent: " +
                db.ExecuteScalar("SELECT COUNT(*) FROM Attendance WHERE Status='Absent'");

            lblLeave.Text =
                "Leave: " +
                db.ExecuteScalar("SELECT COUNT(*) FROM Attendance WHERE Status='Leave'");
        }

        // Load all attendance records
        private void LoadReport()
        {
            string query = "SELECT * FROM Attendance";
            dgvReport.DataSource = db.GetData(query);
        }

        // Search Report
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query;

            if (txtEmployee.Text == "")
            {
                query =
                "SELECT * FROM Attendance WHERE AttendanceDate = '" +
                dtpReportDate.Value.Date.ToString("yyyy-MM-dd") + "'";
            }
            else
            {
                query =
                "SELECT * FROM Attendance WHERE EmployeeID = " +
                txtEmployee.Text;
            }

            dgvReport.DataSource = db.GetData(query);
        }

        // Print Report
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog dialog = new PrintDialog();

            dialog.Document = printDocument;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        // Print Page
        private void PrintDocument_PrintPage(object sender,
            PrintPageEventArgs e)
        {
            string report =
                "Employee Attendance Report\n\n" +
                "Total Records: " +
                dgvReport.Rows.Count.ToString();

            e.Graphics.DrawString(
                report,
                new System.Drawing.Font("Arial", 14),
                System.Drawing.Brushes.Black,
                100,
                100);
        }
    }
}
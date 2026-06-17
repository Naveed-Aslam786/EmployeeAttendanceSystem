using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeAttendanceSystem.Database;

namespace EmployeeAttendanceSystem.Forms
{
    public partial class AttendanceForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public AttendanceForm()
        {
            InitializeComponent();
            LoadAttendance();
        }

        // Display attendance records
        private void LoadAttendance()
        {
            string query = "SELECT * FROM Attendance";
            dgvAttendance.DataSource = db.GetData(query);
        }

        // Mark Attendance
        private void btnMark_Click(object sender, EventArgs e)
        {
            if (txtEmployee.Text == "" || cmbStatus.Text == "")
            {
                MessageBox.Show("Please enter Employee ID and select attendance status.");
                return;
            }

            string query =
            "INSERT INTO Attendance (EmployeeID, AttendanceDate, Status) " +
            "VALUES (@EmployeeID, @Date, @Status)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeID", Convert.ToInt32(txtEmployee.Text)),
                new SqlParameter("@Date", dtpDate.Value.Date),
                new SqlParameter("@Status", cmbStatus.Text)
            };

            if (db.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Attendance marked successfully.");
                LoadAttendance();
                ClearFields();
            }
        }

        // Update Attendance
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow == null)
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            int id = Convert.ToInt32(
                dgvAttendance.CurrentRow.Cells["AttendanceID"].Value);

            string query =
            "UPDATE Attendance SET EmployeeID=@EmployeeID, AttendanceDate=@Date, Status=@Status WHERE AttendanceID=@ID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@EmployeeID", Convert.ToInt32(txtEmployee.Text)),
                new SqlParameter("@Date", dtpDate.Value.Date),
                new SqlParameter("@Status", cmbStatus.Text),
                new SqlParameter("@ID", id)
            };

            if (db.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Attendance updated successfully.");
                LoadAttendance();
            }
        }

        // Delete Attendance
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAttendance.CurrentRow == null)
            {
                MessageBox.Show("Select a record first.");
                return;
            }

            int id = Convert.ToInt32(
                dgvAttendance.CurrentRow.Cells["AttendanceID"].Value);

            string query =
            "DELETE FROM Attendance WHERE AttendanceID=@ID";

            SqlParameter[] parameters =
            {
                new SqlParameter("@ID", id)
            };

            if (db.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Attendance deleted successfully.");
                LoadAttendance();
                ClearFields();
            }
        }

        // Search Attendance
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query;
            SqlParameter[] parameters;

            if (txtEmployee.Text == "")
            {
                query = "SELECT * FROM Attendance WHERE AttendanceDate = @Date";

                parameters = new SqlParameter[]
                {
            new SqlParameter("@Date", dtpDate.Value.Date)
                };
            }
            else
            {
                query = "SELECT * FROM Attendance WHERE EmployeeID = @EmployeeID";

                parameters = new SqlParameter[]
                {
            new SqlParameter("@EmployeeID", Convert.ToInt32(txtEmployee.Text))
                };
            }

            dgvAttendance.DataSource = db.GetData(query, parameters);
        }

        // Select DataGridView Row
        private void dgvAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAttendance.Rows[e.RowIndex];

                txtEmployee.Text = row.Cells["EmployeeID"].Value.ToString();
                dtpDate.Value = Convert.ToDateTime(
                    row.Cells["AttendanceDate"].Value);

                cmbStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        // Clear Controls
        private void ClearFields()
        {
            txtEmployee.Clear();
            cmbStatus.SelectedIndex = -1;
            dtpDate.Value = DateTime.Now;
        }
    }
}
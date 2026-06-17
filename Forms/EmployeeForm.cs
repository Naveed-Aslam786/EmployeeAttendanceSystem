using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EmployeeAttendanceSystem.Database;

namespace EmployeeAttendanceSystem.Forms
{
    public partial class EmployeeForm : Form
    {
        DatabaseHelper db = new DatabaseHelper();

        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        // Display employees in DataGridView
        private void LoadEmployees()
        {
            string query = "SELECT * FROM Employees";
            dgvEmployees.DataSource = db.GetData(query);
        }

        // Add Employee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "")
            {
                MessageBox.Show("Please fill required fields.");
                return;
            }

            string query =
            "INSERT INTO Employees " +
            "(FullName, Gender, Department, Designation, ContactNumber, Email, JoiningDate) " +
            "VALUES (@Name, @Gender, @Department, @Designation, @Contact, @Email, @Date)";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", txtName.Text),
                new SqlParameter("@Gender", txtGender.Text),
                new SqlParameter("@Department", txtDepartment.Text),
                new SqlParameter("@Designation", txtDesignation.Text),
                new SqlParameter("@Contact", txtContact.Text),
                new SqlParameter("@Email", txtEmail.Text),
                new SqlParameter("@Date", dtpJoiningDate.Value.Date)
            };

            if (db.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Employee added successfully.");
                LoadEmployees();
                ClearFields();
            }
        }

        // Clear controls
        private void ClearFields()
        {
            txtName.Clear();
            txtGender.Clear();
            txtDepartment.Clear();
            txtDesignation.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            dtpJoiningDate.Value = DateTime.Now;
        }
        // Update Employee
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Select an employee first.");
                return;
            }

            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            string query = "UPDATE Employees SET FullName=@Name, Gender=@Gender, Department=@Department, Designation=@Designation, ContactNumber=@Contact, Email=@Email, JoiningDate=@Date WHERE EmployeeID=@ID";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Name", txtName.Text),
        new SqlParameter("@Gender", txtGender.Text),
        new SqlParameter("@Department", txtDepartment.Text),
        new SqlParameter("@Designation", txtDesignation.Text),
        new SqlParameter("@Contact", txtContact.Text),
        new SqlParameter("@Email", txtEmail.Text),
        new SqlParameter("@Date", dtpJoiningDate.Value.Date),
        new SqlParameter("@ID", id)
    };

            if (db.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Employee updated successfully.");
                LoadEmployees();
            }
        }


        // Delete Employee
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null)
            {
                MessageBox.Show("Select an employee first.");
                return;
            }

            int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

            string query = "DELETE FROM Employees WHERE EmployeeID=@ID";

            SqlParameter[] parameters =
            {
        new SqlParameter("@ID", id)
    };

            if (db.ExecuteQuery(query, parameters))
            {
                MessageBox.Show("Employee deleted successfully.");
                LoadEmployees();
                ClearFields();
            }
        }


        // Search Employee
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Employees WHERE FullName LIKE @Name";

            SqlParameter[] parameters =
            {
        new SqlParameter("@Name", "%" + txtName.Text + "%")
    };

            dgvEmployees.DataSource = db.GetData(query, parameters);
        }


        // Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
            LoadEmployees();
        }


        // DataGridView Row Click
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                txtName.Text = row.Cells["FullName"].Value.ToString();
                txtGender.Text = row.Cells["Gender"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
                txtDesignation.Text = row.Cells["Designation"].Value.ToString();
                txtContact.Text = row.Cells["ContactNumber"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                dtpJoiningDate.Value =
                    Convert.ToDateTime(row.Cells["JoiningDate"].Value);
            }
        }
    }
}
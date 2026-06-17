using System.Windows.Forms;

namespace EmployeeAttendanceSystem.Forms
{
    partial class AttendanceForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblEmployee;
        private Label lblDate;
        private Label lblStatus;

        private TextBox txtEmployee;
        private DateTimePicker dtpDate;
        private ComboBox cmbStatus;

        private Button btnMark;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnSearch;

        private DataGridView dgvAttendance;

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
            lblEmployee = new Label();
            lblDate = new Label();
            lblStatus = new Label();

            txtEmployee = new TextBox();
            dtpDate = new DateTimePicker();
            cmbStatus = new ComboBox();

            btnMark = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSearch = new Button();

            dgvAttendance = new DataGridView();

            this.SuspendLayout();

            // Form Style
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Employee
            lblEmployee.Text = "Employee ID:";
            lblEmployee.Location = new System.Drawing.Point(170, 35);
            lblEmployee.AutoSize = true;

            txtEmployee.Location = new System.Drawing.Point(280, 30);
            txtEmployee.Size = new System.Drawing.Size(220, 25);

            // Date
            lblDate.Text = "Date:";
            lblDate.Location = new System.Drawing.Point(170, 80);
            lblDate.AutoSize = true;

            dtpDate.Location = new System.Drawing.Point(280, 75);
            dtpDate.Size = new System.Drawing.Size(220, 25);

            // Status
            lblStatus.Text = "Status:";
            lblStatus.Location = new System.Drawing.Point(170, 125);
            lblStatus.AutoSize = true;

            cmbStatus.Location = new System.Drawing.Point(280, 120);
            cmbStatus.Size = new System.Drawing.Size(220, 25);
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Items.Add("Present");
            cmbStatus.Items.Add("Absent");
            cmbStatus.Items.Add("Leave");

            // Buttons
            btnMark.Text = "Mark";
            btnMark.Location = new System.Drawing.Point(170, 180);
            btnMark.Size = new System.Drawing.Size(90, 35);

            btnUpdate.Text = "Update";
            btnUpdate.Location = new System.Drawing.Point(280, 180);
            btnUpdate.Size = new System.Drawing.Size(90, 35);

            btnDelete.Text = "Delete";
            btnDelete.Location = new System.Drawing.Point(390, 180);
            btnDelete.Size = new System.Drawing.Size(90, 35);

            btnSearch.Text = "Search";
            btnSearch.Location = new System.Drawing.Point(500, 180);
            btnSearch.Size = new System.Drawing.Size(90, 35);

            // DataGridView
            dgvAttendance.Location = new System.Drawing.Point(70, 250);
            dgvAttendance.Size = new System.Drawing.Size(760, 270);
            dgvAttendance.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvAttendance.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // Add Controls
            this.Controls.Add(lblEmployee);
            this.Controls.Add(txtEmployee);

            this.Controls.Add(lblDate);
            this.Controls.Add(dtpDate);

            this.Controls.Add(lblStatus);
            this.Controls.Add(cmbStatus);

            this.Controls.Add(btnMark);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnSearch);

            this.Controls.Add(dgvAttendance);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "AttendanceForm";
            this.Text = "Employee Attendance Management";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
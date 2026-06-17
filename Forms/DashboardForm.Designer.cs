using System.Windows.Forms;

namespace EmployeeAttendanceSystem.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;

        private Button btnEmployee;
        private Button btnAttendance;
        private Button btnReport;
        private Button btnLogout;

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
            lblTitle = new Label();

            btnEmployee = new Button();
            btnAttendance = new Button();
            btnReport = new Button();
            btnLogout = new Button();

            this.SuspendLayout();

            // Form Style
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Title
            lblTitle.Text = "Employee Attendance System";
            lblTitle.Location = new System.Drawing.Point(120, 35);
            lblTitle.Size = new System.Drawing.Size(350, 35);
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 14F,
                System.Drawing.FontStyle.Bold);

            // Employee Button
            btnEmployee.Text = "Employee Management";
            btnEmployee.Location = new System.Drawing.Point(150, 100);
            btnEmployee.Size = new System.Drawing.Size(250, 45);
            btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);

            // Attendance Button
            btnAttendance.Text = "Attendance Management";
            btnAttendance.Location = new System.Drawing.Point(150, 165);
            btnAttendance.Size = new System.Drawing.Size(250, 45);
            btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);

            // Report Button
            btnReport.Text = "Attendance Reports";
            btnReport.Location = new System.Drawing.Point(150, 230);
            btnReport.Size = new System.Drawing.Size(250, 45);
            btnReport.Click += new System.EventHandler(this.btnReport_Click);

            // Logout Button
            btnLogout.Text = "Logout";
            btnLogout.Location = new System.Drawing.Point(150, 295);
            btnLogout.Size = new System.Drawing.Size(250, 45);
            btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // Add Controls
            this.Controls.Add(lblTitle);

            this.Controls.Add(btnEmployee);
            this.Controls.Add(btnAttendance);
            this.Controls.Add(btnReport);
            this.Controls.Add(btnLogout);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(550, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            this.ResumeLayout(false);
        }
    }
}
using System.Windows.Forms;

namespace EmployeeAttendanceSystem.Forms
{
    partial class ReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblDate;
        private Label lblEmployee;
        private DateTimePicker dtpReportDate;
        private TextBox txtEmployee;
        private Button btnSearch;
        private Button btnPrint;
        private DataGridView dgvReport;
        private Label lblTotal;
        private Label lblPresent;
        private Label lblAbsent;
        private Label lblLeave;

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
            lblDate = new Label();
            lblEmployee = new Label();
            lblTotal = new Label();
            lblPresent = new Label();
            lblAbsent = new Label();
            lblLeave = new Label();

            dtpReportDate = new DateTimePicker();
            txtEmployee = new TextBox();

            btnSearch = new Button();
            btnPrint = new Button();

            dgvReport = new DataGridView();

            this.SuspendLayout();

            // Form Style
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Date
            lblDate.Text = "Date:";
            lblDate.Location = new System.Drawing.Point(180, 35);
            lblDate.AutoSize = true;

            dtpReportDate.Location = new System.Drawing.Point(240, 30);
            dtpReportDate.Size = new System.Drawing.Size(200, 25);

            // Employee
            lblEmployee.Text = "Employee:";
            lblEmployee.Location = new System.Drawing.Point(160, 75);
            lblEmployee.AutoSize = true;

            txtEmployee.Location = new System.Drawing.Point(240, 70);
            txtEmployee.Size = new System.Drawing.Size(200, 25);

            // Search Button
            btnSearch.Text = "Search";
            btnSearch.Location = new System.Drawing.Point(500, 30);
            btnSearch.Size = new System.Drawing.Size(100, 35);
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // Print Button
            btnPrint.Text = "Print";
            btnPrint.Location = new System.Drawing.Point(500, 75);
            btnPrint.Size = new System.Drawing.Size(100, 35);
            btnPrint.Click += new System.EventHandler(this.btnPrint_Click);

            // Statistics
            lblTotal.Location = new System.Drawing.Point(150, 130);
            lblTotal.Size = new System.Drawing.Size(120, 25);

            lblPresent.Location = new System.Drawing.Point(300, 130);
            lblPresent.Size = new System.Drawing.Size(120, 25);

            lblAbsent.Location = new System.Drawing.Point(450, 130);
            lblAbsent.Size = new System.Drawing.Size(120, 25);

            lblLeave.Location = new System.Drawing.Point(600, 130);
            lblLeave.Size = new System.Drawing.Size(120, 25);

            // DataGridView
            dgvReport.Location = new System.Drawing.Point(80, 180);
            dgvReport.Size = new System.Drawing.Size(740, 330);
            dgvReport.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvReport.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // Add Controls
            this.Controls.Add(lblDate);
            this.Controls.Add(dtpReportDate);

            this.Controls.Add(lblEmployee);
            this.Controls.Add(txtEmployee);

            this.Controls.Add(btnSearch);
            this.Controls.Add(btnPrint);

            this.Controls.Add(lblTotal);
            this.Controls.Add(lblPresent);
            this.Controls.Add(lblAbsent);
            this.Controls.Add(lblLeave);

            this.Controls.Add(dgvReport);

            // Form Settings
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "ReportForm";
            this.Text = "Employee Attendance Reports";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
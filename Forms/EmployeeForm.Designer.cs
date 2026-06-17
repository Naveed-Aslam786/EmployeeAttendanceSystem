using System.Windows.Forms;

namespace EmployeeAttendanceSystem.Forms
{
    partial class EmployeeForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblName;
        private Label lblGender;
        private Label lblDepartment;
        private Label lblDesignation;
        private Label lblContact;
        private Label lblEmail;
        private Label lblDate;

        private TextBox txtName;
        private TextBox txtGender;
        private TextBox txtDepartment;
        private TextBox txtDesignation;
        private TextBox txtContact;
        private TextBox txtEmail;

        private DateTimePicker dtpJoiningDate;

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Button btnSearch;

        private DataGridView dgvEmployees;

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
            lblName = new Label();
            lblGender = new Label();
            lblDepartment = new Label();
            lblDesignation = new Label();
            lblContact = new Label();
            lblEmail = new Label();
            lblDate = new Label();

            txtName = new TextBox();
            txtGender = new TextBox();
            txtDepartment = new TextBox();
            txtDesignation = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();

            dtpJoiningDate = new DateTimePicker();

            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();

            dgvEmployees = new DataGridView();

            this.SuspendLayout();

            // Form Style
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Labels and TextBoxes

            lblName.Text = "Full Name:";
            lblName.Location = new System.Drawing.Point(140, 35);
            lblName.AutoSize = true;

            txtName.Location = new System.Drawing.Point(270, 30);
            txtName.Size = new System.Drawing.Size(220, 25);


            lblGender.Text = "Gender:";
            lblGender.Location = new System.Drawing.Point(140, 75);
            lblGender.AutoSize = true;

            txtGender.Location = new System.Drawing.Point(270, 70);
            txtGender.Size = new System.Drawing.Size(220, 25);


            lblDepartment.Text = "Department:";
            lblDepartment.Location = new System.Drawing.Point(140, 115);
            lblDepartment.AutoSize = true;

            txtDepartment.Location = new System.Drawing.Point(270, 110);
            txtDepartment.Size = new System.Drawing.Size(220, 25);


            lblDesignation.Text = "Designation:";
            lblDesignation.Location = new System.Drawing.Point(140, 155);
            lblDesignation.AutoSize = true;

            txtDesignation.Location = new System.Drawing.Point(270, 150);
            txtDesignation.Size = new System.Drawing.Size(220, 25);


            lblContact.Text = "Contact Number:";
            lblContact.Location = new System.Drawing.Point(140, 195);
            lblContact.AutoSize = true;

            txtContact.Location = new System.Drawing.Point(270, 190);
            txtContact.Size = new System.Drawing.Size(220, 25);


            lblEmail.Text = "Email Address:";
            lblEmail.Location = new System.Drawing.Point(140, 235);
            lblEmail.AutoSize = true;

            txtEmail.Location = new System.Drawing.Point(270, 230);
            txtEmail.Size = new System.Drawing.Size(220, 25);


            lblDate.Text = "Joining Date:";
            lblDate.Location = new System.Drawing.Point(140, 275);
            lblDate.AutoSize = true;

            dtpJoiningDate.Location = new System.Drawing.Point(270, 270);
            dtpJoiningDate.Size = new System.Drawing.Size(220, 25);


            // Buttons

            btnAdd.Text = "Add";
            btnAdd.Location = new System.Drawing.Point(560, 40);
            btnAdd.Size = new System.Drawing.Size(100, 35);
            btnAdd.Click += new System.EventHandler(this.btnAdd_Click);


            btnUpdate.Text = "Update";
            btnUpdate.Location = new System.Drawing.Point(560, 90);
            btnUpdate.Size = new System.Drawing.Size(100, 35);
            btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);


            btnDelete.Text = "Delete";
            btnDelete.Location = new System.Drawing.Point(560, 140);
            btnDelete.Size = new System.Drawing.Size(100, 35);
            btnDelete.Click += new System.EventHandler(this.btnDelete_Click);


            btnClear.Text = "Clear";
            btnClear.Location = new System.Drawing.Point(560, 190);
            btnClear.Size = new System.Drawing.Size(100, 35);
            btnClear.Click += new System.EventHandler(this.btnClear_Click);


            btnSearch.Text = "Search";
            btnSearch.Location = new System.Drawing.Point(560, 240);
            btnSearch.Size = new System.Drawing.Size(100, 35);
            btnSearch.Click += new System.EventHandler(this.btnSearch_Click);


            // DataGridView

            dgvEmployees.Location = new System.Drawing.Point(70, 340);
            dgvEmployees.Size = new System.Drawing.Size(760, 240);

            dgvEmployees.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmployees.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            dgvEmployees.CellClick +=
                new DataGridViewCellEventHandler(this.dgvEmployees_CellClick);


            // Add Controls

            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            this.Controls.Add(lblGender);
            this.Controls.Add(txtGender);

            this.Controls.Add(lblDepartment);
            this.Controls.Add(txtDepartment);

            this.Controls.Add(lblDesignation);
            this.Controls.Add(txtDesignation);

            this.Controls.Add(lblContact);
            this.Controls.Add(txtContact);

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            this.Controls.Add(lblDate);
            this.Controls.Add(dtpJoiningDate);

            this.Controls.Add(btnAdd);
            this.Controls.Add(btnUpdate);
            this.Controls.Add(btnDelete);
            this.Controls.Add(btnClear);
            this.Controls.Add(btnSearch);

            this.Controls.Add(dgvEmployees);


            // Form Settings

            this.ClientSize = new System.Drawing.Size(900, 650);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "EmployeeForm";
            this.Text = "Employee Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
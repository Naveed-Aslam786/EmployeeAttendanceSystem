namespace EmployeeAttendanceSystem.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // Form Style
            this.BackColor = System.Drawing.Color.WhiteSmoke;

            // Title
            lblTitle.Text = "Employee Attendance System";
            lblTitle.Font = new System.Drawing.Font(
                "Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.AutoSize = true;
            lblTitle.Location = new System.Drawing.Point(70, 35);

            // Username Label
            lblUsername.Text = "Username";
            lblUsername.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(65, 110);

            // Username TextBox
            txtUsername.Location = new System.Drawing.Point(170, 105);
            txtUsername.Size = new System.Drawing.Size(220, 25);

            // Password Label
            lblPassword.Text = "Password";
            lblPassword.Font = new System.Drawing.Font(
                "Segoe UI", 10F);
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(65, 165);

            // Password TextBox
            txtPassword.Location = new System.Drawing.Point(170, 160);
            txtPassword.Size = new System.Drawing.Size(220, 25);
            txtPassword.PasswordChar = '*';

            // Login Button
            btnLogin.Text = "Login";
            btnLogin.Location = new System.Drawing.Point(100, 240);
            btnLogin.Size = new System.Drawing.Size(110, 40);
            btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // Exit Button
            btnExit.Text = "Exit";
            btnExit.Location = new System.Drawing.Point(250, 240);
            btnExit.Size = new System.Drawing.Size(110, 40);
            btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // Add Controls
            this.Controls.Add(lblTitle);
            this.Controls.Add(lblUsername);
            this.Controls.Add(txtUsername);
            this.Controls.Add(lblPassword);
            this.Controls.Add(txtPassword);
            this.Controls.Add(btnLogin);
            this.Controls.Add(btnExit);

            // Form Settings
            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 350);
            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle =
                System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Employee Login";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
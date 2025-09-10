namespace WinFormsApp2
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblFullName;
        private Label lblUsername;
        private Label lblPhone;
        private Label lblPassword;
        private TextBox txtFullName;
        private TextBox txtUsername;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private Button btnKayitOl;

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
            lblFullName = new Label();
            lblUsername = new Label();
            lblPhone = new Label();
            lblPassword = new Label();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kayýt Formu";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.Location = new Point(30, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(200, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Ýsim Soyisim:";
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(30, 120);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(200, 20);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Kullanýcý Adý:";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(30, 180);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(200, 20);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Telefon:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(30, 240);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(200, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Þifre:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(30, 80);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 27);
            txtFullName.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 140);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(30, 200);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 260);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 8;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.MediumSeaGreen;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(30, 310);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(200, 48);
            btnKayitOl.TabIndex = 9;
            btnKayitOl.Text = "Kayýt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // RegistrationForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(260, 380);
            Controls.Add(lblTitle);
            Controls.Add(lblFullName);
            Controls.Add(txtFullName);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPhone);
            Controls.Add(txtPhone);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(btnKayitOl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kayýt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
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
            lblTitle.Text = "Kayýt Formu";
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 10);
            lblTitle.Size = new Size(200, 40);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.Text = "Ýsim Soyisim:";
            lblFullName.Location = new Point(30, 60);
            lblFullName.Size = new Size(200, 20);
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(30, 80);
            txtFullName.Size = new Size(200, 27);
            // 
            // lblUsername
            // 
            lblUsername.Text = "Kullanýcý Adý:";
            lblUsername.Location = new Point(30, 120);
            lblUsername.Size = new Size(200, 20);
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 140);
            txtUsername.Size = new Size(200, 27);
            // 
            // lblPhone
            // 
            lblPhone.Text = "Telefon:";
            lblPhone.Location = new Point(30, 180);
            lblPhone.Size = new Size(200, 20);
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(30, 200);
            txtPhone.Size = new Size(200, 27);
            // 
            // lblPassword
            // 
            lblPassword.Text = "Þifre:";
            lblPassword.Location = new Point(30, 240);
            lblPassword.Size = new Size(200, 20);
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 260);
            txtPassword.Size = new Size(200, 27);
            txtPassword.PasswordChar = '*';
            // 
            // btnKayitOl
            // 
            btnKayitOl.Text = "Kayýt Ol";
            btnKayitOl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKayitOl.BackColor = Color.MediumSeaGreen;
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Location = new Point(30, 310);
            btnKayitOl.Size = new Size(200, 48);
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // RegistrationForm
            // 
            ClientSize = new Size(260, 380);
            BackColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
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
            Name = "RegistrationForm";
            Text = "Kayýt Ol";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtLoginUsername;
        private TextBox txtLoginPassword;
        private Button btnGiris;
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtLoginUsername = new TextBox();
            txtLoginPassword = new TextBox();
            btnGiris = new Button();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Text = "Giriş Paneli";
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 10);
            lblTitle.Size = new Size(200, 40);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Text = "Kullanıcı Adı:";
            lblUsername.Location = new Point(30, 60);
            lblUsername.Size = new Size(200, 20);
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(30, 80);
            txtLoginUsername.Size = new Size(200, 27);
            // 
            // lblPassword
            // 
            lblPassword.Text = "Şifre:";
            lblPassword.Location = new Point(30, 120);
            lblPassword.Size = new Size(200, 20);
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(30, 140);
            txtLoginPassword.Size = new Size(200, 27);
            txtLoginPassword.PasswordChar = '*';
            // 
            // btnGiris
            // 
            btnGiris.Text = "Giriş";
            btnGiris.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnGiris.BackColor = Color.MediumSeaGreen;
            btnGiris.ForeColor = Color.White;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Location = new Point(30, 190);
            btnGiris.Size = new Size(200, 48);
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKayitOl.BackColor = Color.SteelBlue;
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Location = new Point(30, 250);
            btnKayitOl.Size = new Size(200, 48);
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(260, 330);
            BackColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtLoginUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtLoginPassword);
            Controls.Add(btnGiris);
            Controls.Add(btnKayitOl);
            Name = "Form1";
            Text = "Giriş Paneli";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
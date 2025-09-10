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
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Giriş Paneli";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Location = new Point(30, 60);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(200, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Kullanıcı Adı:";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(30, 120);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(200, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Şifre:";
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(30, 80);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(200, 27);
            txtLoginUsername.TabIndex = 2;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(30, 140);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(200, 27);
            txtLoginPassword.TabIndex = 4;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.MediumSeaGreen;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnGiris.ForeColor = Color.White;
            btnGiris.Location = new Point(30, 190);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(200, 48);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.BackColor = Color.SteelBlue;
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKayitOl.ForeColor = Color.White;
            btnKayitOl.Location = new Point(30, 250);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(200, 48);
            btnKayitOl.TabIndex = 6;
            btnKayitOl.Text = "Kayıt Ol";
            btnKayitOl.UseVisualStyleBackColor = false;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // Form1
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(260, 330);
            Controls.Add(lblTitle);
            Controls.Add(lblUsername);
            Controls.Add(txtLoginUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtLoginPassword);
            Controls.Add(btnGiris);
            Controls.Add(btnKayitOl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Paneli";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
namespace WinFormsApp2
{
    partial class ProfilForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label lblSifreDegistir;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Button btnSifreDegistir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblKullaniciAdi = new Label();
            txtUsername = new Label();
            lblAdSoyad = new Label();
            txtFullName = new Label();
            lblTelefon = new Label();
            txtPhone = new Label();
            lblSifreDegistir = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            btnSifreDegistir = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(412, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Profil";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(30, 60);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 20);
            lblKullaniciAdi.TabIndex = 1;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.BorderStyle = BorderStyle.Fixed3D;
            txtUsername.Location = new Point(160, 60);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 25);
            txtUsername.TabIndex = 2;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(30, 100);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(76, 20);
            lblAdSoyad.TabIndex = 3;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Window;
            txtFullName.BorderStyle = BorderStyle.Fixed3D;
            txtFullName.Location = new Point(160, 100);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 25);
            txtFullName.TabIndex = 4;
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(30, 140);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(61, 20);
            lblTelefon.TabIndex = 5;
            lblTelefon.Text = "Telefon:";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Window;
            txtPhone.BorderStyle = BorderStyle.Fixed3D;
            txtPhone.Location = new Point(160, 140);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 25);
            txtPhone.TabIndex = 6;
            // 
            // lblSifreDegistir
            // 
            lblSifreDegistir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSifreDegistir.Location = new Point(30, 192);
            lblSifreDegistir.Name = "lblSifreDegistir";
            lblSifreDegistir.Size = new Size(202, 36);
            lblSifreDegistir.TabIndex = 7;
            lblSifreDegistir.Text = "Şifre Değiştir";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(30, 230);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.PlaceholderText = "Eski Şifre";
            txtEskiSifre.Size = new Size(160, 27);
            txtEskiSifre.TabIndex = 8;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(200, 230);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.PlaceholderText = "Yeni Şifre";
            txtYeniSifre.Size = new Size(160, 27);
            txtYeniSifre.TabIndex = 9;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.BackColor = Color.SteelBlue;
            btnSifreDegistir.FlatStyle = FlatStyle.Flat;
            btnSifreDegistir.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSifreDegistir.ForeColor = Color.White;
            btnSifreDegistir.Location = new Point(30, 270);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(330, 38);
            btnSifreDegistir.TabIndex = 10;
            btnSifreDegistir.Text = "Şifreyi Değiştir";
            btnSifreDegistir.UseVisualStyleBackColor = false;
            // 
            // ProfilForm
            // 
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(413, 320);
            Controls.Add(lblTitle);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtUsername);
            Controls.Add(lblAdSoyad);
            Controls.Add(txtFullName);
            Controls.Add(lblTelefon);
            Controls.Add(txtPhone);
            Controls.Add(lblSifreDegistir);
            Controls.Add(txtEskiSifre);
            Controls.Add(txtYeniSifre);
            Controls.Add(btnSifreDegistir);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfilForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profil";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
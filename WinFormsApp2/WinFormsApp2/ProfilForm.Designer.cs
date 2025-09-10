namespace WinFormsApp2
{
    partial class ProfilForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label txtFullName;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Label lblSifreDegistir;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.Button btnSifreDegistir;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label txtUsername;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtFullName = new Label();
            txtPhone = new Label();
            lblSifreDegistir = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            btnSifreDegistir = new Button();
            lblAdSoyad = new Label();
            lblTelefon = new Label();
            lblKullaniciAdi = new Label();
            txtUsername = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(413, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Profil";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Window;
            txtFullName.Location = new Point(120, 84);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 25);
            txtFullName.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = SystemColors.Window;
            txtPhone.Location = new Point(120, 118);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 25);
            txtPhone.TabIndex = 2;
            txtPhone.Click += lblPhone_Click;
            // 
            // lblSifreDegistir
            // 
            lblSifreDegistir.Location = new Point(12, 189);
            lblSifreDegistir.Name = "lblSifreDegistir";
            lblSifreDegistir.Size = new Size(200, 20);
            lblSifreDegistir.TabIndex = 7;
            lblSifreDegistir.Text = "Şifre Değiştir";
            lblSifreDegistir.Click += lblSifreDegistir_Click;
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(12, 223);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.PlaceholderText = "Eski Şifre";
            txtEskiSifre.Size = new Size(180, 27);
            txtEskiSifre.TabIndex = 8;
            txtEskiSifre.TextChanged += txtEskiSifre_TextChanged;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(212, 223);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.PlaceholderText = "Yeni Şifre";
            txtYeniSifre.Size = new Size(180, 27);
            txtYeniSifre.TabIndex = 9;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Location = new Point(12, 256);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(380, 35);
            btnSifreDegistir.TabIndex = 10;
            btnSifreDegistir.Text = "Şifreyi Değiştir";
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(12, 84);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(76, 20);
            lblAdSoyad.TabIndex = 11;
            lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTelefon
            // 
            lblTelefon.AutoSize = true;
            lblTelefon.Location = new Point(12, 118);
            lblTelefon.Name = "lblTelefon";
            lblTelefon.Size = new Size(61, 20);
            lblTelefon.TabIndex = 12;
            lblTelefon.Text = "Telefon:";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.Location = new Point(12, 50);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(95, 20);
            lblKullaniciAdi.TabIndex = 13;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Location = new Point(120, 50);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(200, 25);
            txtUsername.TabIndex = 14;
            // 
            // ProfilForm
            // 
            ClientSize = new Size(413, 324);
            Controls.Add(lblKullaniciAdi);
            Controls.Add(txtUsername);
            Controls.Add(lblTelefon);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblTitle);
            Controls.Add(txtFullName);
            Controls.Add(txtPhone);
            Controls.Add(lblSifreDegistir);
            Controls.Add(txtEskiSifre);
            Controls.Add(txtYeniSifre);
            Controls.Add(btnSifreDegistir);
            Name = "ProfilForm";
            Text = "Profil";
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtEskiSifre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblSifreDegistir_Click(object sender, EventArgs e)
        {
            
        }
    }
}
namespace WinFormsApp2
{
    partial class ProfilForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblOdenmemis;
        private System.Windows.Forms.DataGridView dgvBorcListesi;
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
            lblFullName = new Label();
            lblPhone = new Label();
            lblOdenmemis = new Label();
            dgvBorcListesi = new DataGridView();
            lblSifreDegistir = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            btnSifreDegistir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBorcListesi).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(650, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Profil";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // lblFullName
            // 
            lblFullName.BackColor = SystemColors.Window;
            lblFullName.Location = new Point(20, 55);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(300, 25);
            lblFullName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.BackColor = SystemColors.Window;
            lblPhone.Location = new Point(326, 55);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(300, 25);
            lblPhone.TabIndex = 2;
            lblPhone.Click += lblPhone_Click;
            // 
            // lblOdenmemis
            // 
            lblOdenmemis.Location = new Point(20, 106);
            lblOdenmemis.Name = "lblOdenmemis";
            lblOdenmemis.Size = new Size(200, 20);
            lblOdenmemis.TabIndex = 5;
            lblOdenmemis.Text = "Borç";
            lblOdenmemis.Click += lblOdenmemis_Click;
            // 
            // dgvBorcListesi
            // 
            dgvBorcListesi.AllowUserToAddRows = false;
            dgvBorcListesi.AllowUserToDeleteRows = false;
            dgvBorcListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorcListesi.ColumnHeadersHeight = 29;
            dgvBorcListesi.Location = new Point(20, 147);
            dgvBorcListesi.Name = "dgvBorcListesi";
            dgvBorcListesi.ReadOnly = true;
            dgvBorcListesi.RowHeadersWidth = 51;
            dgvBorcListesi.Size = new Size(606, 262);
            dgvBorcListesi.TabIndex = 6;
            // 
            // lblSifreDegistir
            // 
            lblSifreDegistir.Location = new Point(20, 390);
            lblSifreDegistir.Name = "lblSifreDegistir";
            lblSifreDegistir.Size = new Size(200, 20);
            lblSifreDegistir.TabIndex = 7;
            lblSifreDegistir.Text = "Şifre Değiştir";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(20, 452);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.PlaceholderText = "Eski Şifre";
            txtEskiSifre.Size = new Size(180, 27);
            txtEskiSifre.TabIndex = 8;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(220, 452);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.PlaceholderText = "Yeni Şifre";
            txtYeniSifre.Size = new Size(180, 27);
            txtYeniSifre.TabIndex = 9;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Location = new Point(20, 487);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(380, 35);
            btnSifreDegistir.TabIndex = 10;
            btnSifreDegistir.Text = "Şifreyi Değiştir";
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // ProfilForm
            // 
            ClientSize = new Size(650, 532);
            Controls.Add(lblTitle);
            Controls.Add(lblFullName);
            Controls.Add(lblPhone);
            Controls.Add(lblOdenmemis);
            Controls.Add(dgvBorcListesi);
            Controls.Add(lblSifreDegistir);
            Controls.Add(txtEskiSifre);
            Controls.Add(txtYeniSifre);
            Controls.Add(btnSifreDegistir);
            Name = "ProfilForm";
            Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)dgvBorcListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
namespace WinFormsApp2
{
    partial class ProfilForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblOdenen;
        private System.Windows.Forms.Label lblOdenmemis;
        private System.Windows.Forms.DataGridView dgvOdenen;
        private System.Windows.Forms.DataGridView dgvOdenmemis;
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
            lblOdenen = new Label();
            lblOdenmemis = new Label();
            dgvOdenen = new DataGridView();
            dgvOdenmemis = new DataGridView();
            lblSifreDegistir = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            btnSifreDegistir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOdenen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOdenmemis).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1408, 40);
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
            // lblOdenen
            // 
            lblOdenen.Location = new Point(749, 106);
            lblOdenen.Name = "lblOdenen";
            lblOdenen.Size = new Size(200, 20);
            lblOdenen.TabIndex = 3;
            lblOdenen.Text = "Ödenen Faturalar";
            // 
            // lblOdenmemis
            // 
            lblOdenmemis.Location = new Point(20, 106);
            lblOdenmemis.Name = "lblOdenmemis";
            lblOdenmemis.Size = new Size(200, 20);
            lblOdenmemis.TabIndex = 5;
            lblOdenmemis.Text = "Ödenmemiş Faturalar (Borç)";
            lblOdenmemis.Click += lblOdenmemis_Click;
            // 
            // dgvOdenen
            // 
            dgvOdenen.AllowUserToAddRows = false;
            dgvOdenen.AllowUserToDeleteRows = false;
            dgvOdenen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOdenen.ColumnHeadersHeight = 29;
            dgvOdenen.Location = new Point(749, 147);
            dgvOdenen.Name = "dgvOdenen";
            dgvOdenen.ReadOnly = true;
            dgvOdenen.RowHeadersWidth = 51;
            dgvOdenen.Size = new Size(642, 263);
            dgvOdenen.TabIndex = 4;
            // 
            // dgvOdenmemis
            // 
            dgvOdenmemis.AllowUserToAddRows = false;
            dgvOdenmemis.AllowUserToDeleteRows = false;
            dgvOdenmemis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOdenmemis.ColumnHeadersHeight = 29;
            dgvOdenmemis.Location = new Point(20, 147);
            dgvOdenmemis.Name = "dgvOdenmemis";
            dgvOdenmemis.ReadOnly = true;
            dgvOdenmemis.RowHeadersWidth = 51;
            dgvOdenmemis.Size = new Size(606, 262);
            dgvOdenmemis.TabIndex = 6;
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
            txtEskiSifre.Location = new Point(505, 455);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.PlaceholderText = "Eski Şifre";
            txtEskiSifre.Size = new Size(180, 27);
            txtEskiSifre.TabIndex = 8;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(705, 455);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.PlaceholderText = "Yeni Şifre";
            txtYeniSifre.Size = new Size(180, 27);
            txtYeniSifre.TabIndex = 9;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Location = new Point(505, 490);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(380, 35);
            btnSifreDegistir.TabIndex = 10;
            btnSifreDegistir.Text = "Şifreyi Değiştir";
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // ProfilForm
            // 
            ClientSize = new Size(1408, 551);
            Controls.Add(lblTitle);
            Controls.Add(lblFullName);
            Controls.Add(lblPhone);
            Controls.Add(lblOdenen);
            Controls.Add(dgvOdenen);
            Controls.Add(lblOdenmemis);
            Controls.Add(dgvOdenmemis);
            Controls.Add(lblSifreDegistir);
            Controls.Add(txtEskiSifre);
            Controls.Add(txtYeniSifre);
            Controls.Add(btnSifreDegistir);
            Name = "ProfilForm";
            Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)dgvOdenen).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOdenmemis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
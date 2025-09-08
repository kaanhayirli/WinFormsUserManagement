
namespace WinFormsApp2
{
    partial class ProfilForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhone;
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
            lblSifreDegistir = new Label();
            txtEskiSifre = new TextBox();
            txtYeniSifre = new TextBox();
            btnSifreDegistir = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(409, 40);
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
            lblPhone.Location = new Point(20, 94);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(300, 25);
            lblPhone.TabIndex = 2;
            lblPhone.Click += lblPhone_Click;
            // 
            // lblSifreDegistir
            // 
            lblSifreDegistir.Location = new Point(20, 143);
            lblSifreDegistir.Name = "lblSifreDegistir";
            lblSifreDegistir.Size = new Size(200, 20);
            lblSifreDegistir.TabIndex = 7;
            lblSifreDegistir.Text = "Şifre Değiştir";
            lblSifreDegistir.Click += this.lblSifreDegistir_Click;
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(20, 175);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.PasswordChar = '*';
            txtEskiSifre.PlaceholderText = "Eski Şifre";
            txtEskiSifre.Size = new Size(180, 27);
            txtEskiSifre.TabIndex = 8;
            txtEskiSifre.TextChanged += this.txtEskiSifre_TextChanged;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(212, 175);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifre.PlaceholderText = "Yeni Şifre";
            txtYeniSifre.Size = new Size(180, 27);
            txtYeniSifre.TabIndex = 9;
            txtYeniSifre.TextChanged += txtYeniSifre_TextChanged;
            // 
            // btnSifreDegistir
            // 
            btnSifreDegistir.Location = new Point(12, 208);
            btnSifreDegistir.Name = "btnSifreDegistir";
            btnSifreDegistir.Size = new Size(380, 35);
            btnSifreDegistir.TabIndex = 10;
            btnSifreDegistir.Text = "Şifreyi Değiştir";
            btnSifreDegistir.Click += btnSifreDegistir_Click;
            // 
            // ProfilForm
            // 
            ClientSize = new Size(409, 260);
            Controls.Add(lblTitle);
            Controls.Add(lblFullName);
            Controls.Add(lblPhone);
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
            throw new NotImplementedException();
        }

        private void lblSifreDegistir_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
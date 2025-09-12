namespace WinFormsApp2
{
    partial class FaturaEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblZorunlu;
        private System.Windows.Forms.Label lblFaturaTipi;
        private System.Windows.Forms.ComboBox cmbFaturaTipi;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblSonTarih;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;

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
            lblZorunlu = new Label();
            lblFaturaTipi = new Label();
            cmbFaturaTipi = new ComboBox();
            lblTutar = new Label();
            txtTutar = new TextBox();
            lblSonTarih = new Label();
            dtpSonTarih = new DateTimePicker();
            lblAciklama = new Label();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 55);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fatura Ekle";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZorunlu
            // 
            lblZorunlu.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblZorunlu.ForeColor = Color.IndianRed;
            lblZorunlu.Location = new Point(30, 60);
            lblZorunlu.Name = "lblZorunlu";
            lblZorunlu.Size = new Size(300, 25);
            lblZorunlu.TabIndex = 1;
            lblZorunlu.Text = "* ile işaretli alanlar zorunludur.";
            // 
            // lblFaturaTipi
            // 
            lblFaturaTipi.Font = new Font("Segoe UI", 12F);
            lblFaturaTipi.Location = new Point(30, 100);
            lblFaturaTipi.Name = "lblFaturaTipi";
            lblFaturaTipi.Size = new Size(120, 30);
            lblFaturaTipi.TabIndex = 2;
            lblFaturaTipi.Text = "Fatura Türü *";
            // 
            // cmbFaturaTipi
            // 
            cmbFaturaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaturaTipi.Font = new Font("Segoe UI", 12F);
            cmbFaturaTipi.Items.AddRange(new object[] { "Elektrik", "Su", "Doğalgaz", "Aidat", "Kira", "Diğer" });
            cmbFaturaTipi.Location = new Point(170, 100);
            cmbFaturaTipi.Name = "cmbFaturaTipi";
            cmbFaturaTipi.Size = new Size(295, 36);
            cmbFaturaTipi.TabIndex = 3;
            // 
            // lblTutar
            // 
            lblTutar.Font = new Font("Segoe UI", 12F);
            lblTutar.Location = new Point(30, 145);
            lblTutar.Name = "lblTutar";
            lblTutar.Size = new Size(120, 30);
            lblTutar.TabIndex = 4;
            lblTutar.Text = "Tutar *";
            // 
            // txtTutar
            // 
            txtTutar.Font = new Font("Segoe UI", 12F);
            txtTutar.Location = new Point(170, 145);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(295, 34);
            txtTutar.TabIndex = 5;
            // 
            // lblSonTarih
            // 
            lblSonTarih.Font = new Font("Segoe UI", 12F);
            lblSonTarih.Location = new Point(30, 190);
            lblSonTarih.Name = "lblSonTarih";
            lblSonTarih.Size = new Size(130, 30);
            lblSonTarih.TabIndex = 6;
            lblSonTarih.Text = "Son Ödeme Tarihi";
            // 
            // dtpSonTarih
            // 
            dtpSonTarih.Font = new Font("Segoe UI", 12F);
            dtpSonTarih.Location = new Point(170, 190);
            dtpSonTarih.Name = "dtpSonTarih";
            dtpSonTarih.Size = new Size(295, 34);
            dtpSonTarih.TabIndex = 7;
            // 
            // lblAciklama
            // 
            lblAciklama.Font = new Font("Segoe UI", 12F);
            lblAciklama.Location = new Point(30, 235);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(120, 30);
            lblAciklama.TabIndex = 8;
            lblAciklama.Text = "Açıklama *";
            // 
            // txtAciklama
            // 
            txtAciklama.Font = new Font("Segoe UI", 12F);
            txtAciklama.Location = new Point(170, 235);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(295, 34);
            txtAciklama.TabIndex = 9;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(0, 120, 215);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(170, 285);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(295, 40);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FaturaEkleForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(500, 360);
            Controls.Add(lblTitle);
            Controls.Add(lblZorunlu);
            Controls.Add(lblFaturaTipi);
            Controls.Add(cmbFaturaTipi);
            Controls.Add(lblTutar);
            Controls.Add(txtTutar);
            Controls.Add(lblSonTarih);
            Controls.Add(dtpSonTarih);
            Controls.Add(lblAciklama);
            Controls.Add(txtAciklama);
            Controls.Add(btnKaydet);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FaturaEkleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatura Ekle";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
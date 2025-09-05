namespace WinFormsApp2
{
    partial class FaturaEkleForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbFaturaTipi;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
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
            cmbFaturaTipi = new ComboBox();
            txtTutar = new TextBox();
            dtpSonTarih = new DateTimePicker();
            txtAciklama = new TextBox();
            btnKaydet = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(125, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fatura Ekle";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // cmbFaturaTipi
            // 
            cmbFaturaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaturaTipi.Items.AddRange(new object[] { "Elektrik", "Su", "Doğalgaz", "Aidat", "Kira" });
            cmbFaturaTipi.Location = new Point(190, 59);
            cmbFaturaTipi.Name = "cmbFaturaTipi";
            cmbFaturaTipi.Size = new Size(200, 28);
            cmbFaturaTipi.TabIndex = 1;
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(190, 99);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(200, 27);
            txtTutar.TabIndex = 2;
            // 
            // dtpSonTarih
            // 
            dtpSonTarih.Location = new Point(190, 139);
            dtpSonTarih.Name = "dtpSonTarih";
            dtpSonTarih.Size = new Size(200, 27);
            dtpSonTarih.TabIndex = 3;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(190, 179);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(200, 27);
            txtAciklama.TabIndex = 4;
            txtAciklama.TextChanged += txtAciklama_TextChanged;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumSeaGreen;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.White;
            btnKaydet.Location = new Point(190, 219);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(200, 48);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 62);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 7;
            label1.Text = "Fatura Türü:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 102);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 8;
            label2.Text = "Tutar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 144);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 9;
            label3.Text = "Son Ödeme Tarihi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 182);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Açıklama";
            // 
            // FaturaEkleForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(467, 303);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(cmbFaturaTipi);
            Controls.Add(txtTutar);
            Controls.Add(dtpSonTarih);
            Controls.Add(txtAciklama);
            Controls.Add(btnKaydet);
            Name = "FaturaEkleForm";
            Text = "Fatura Ekle";
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
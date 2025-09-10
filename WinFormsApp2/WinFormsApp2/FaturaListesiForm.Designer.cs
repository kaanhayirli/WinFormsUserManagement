namespace WinFormsApp2
{
    partial class FaturaListesiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvFaturaListesi;
        private System.Windows.Forms.Button btnOdenen;

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
            dgvFaturaListesi = new DataGridView();
            btnOdenen = new Button();
            label1 = new Label();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFaturaListesi).BeginInit();
            SuspendLayout();
            // 
            // dgvFaturaListesi
            // 
            dgvFaturaListesi.AllowUserToAddRows = false;
            dgvFaturaListesi.AllowUserToDeleteRows = false;
            dgvFaturaListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFaturaListesi.ColumnHeadersHeight = 29;
            dgvFaturaListesi.Location = new Point(12, 99);
            dgvFaturaListesi.Name = "dgvFaturaListesi";
            dgvFaturaListesi.ReadOnly = true;
            dgvFaturaListesi.RowHeadersWidth = 51;
            dgvFaturaListesi.Size = new Size(650, 320);
            dgvFaturaListesi.TabIndex = 0;
            // 
            // btnOdenen
            // 
            btnOdenen.BackColor = Color.MediumSeaGreen;
            btnOdenen.Location = new Point(12, 429);
            btnOdenen.Name = "btnOdenen";
            btnOdenen.Size = new Size(220, 40);
            btnOdenen.TabIndex = 1;
            btnOdenen.Text = "Ödendi Olarak İşaretle";
            btnOdenen.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(249, 33);
            label1.Name = "label1";
            label1.Size = new Size(185, 37);
            label1.TabIndex = 2;
            label1.Text = "Fatura Listesi";
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Location = new Point(258, 429);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(220, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // FaturaListesiForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(681, 480);
            Controls.Add(btnSil);
            Controls.Add(label1);
            Controls.Add(dgvFaturaListesi);
            Controls.Add(btnOdenen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FaturaListesiForm";
            Text = "Fatura Listesi";
            ((System.ComponentModel.ISupportInitialize)dgvFaturaListesi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Button btnSil;
    }
}
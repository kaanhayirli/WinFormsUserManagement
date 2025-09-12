namespace WinFormsApp2
{
    partial class FaturaListesiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvFaturaListesi;
        private System.Windows.Forms.Button btnOdenen;
        private System.Windows.Forms.Button btnSil;

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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitle = new Label();
            dgvFaturaListesi = new DataGridView();
            btnOdenen = new Button();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFaturaListesi).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(782, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Fatura Listesi";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvFaturaListesi
            // 
            dgvFaturaListesi.AllowUserToAddRows = false;
            dgvFaturaListesi.AllowUserToDeleteRows = false;
            dgvFaturaListesi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvFaturaListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFaturaListesi.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFaturaListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFaturaListesi.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvFaturaListesi.DefaultCellStyle = dataGridViewCellStyle4;
            dgvFaturaListesi.Location = new Point(30, 70);
            dgvFaturaListesi.Name = "dgvFaturaListesi";
            dgvFaturaListesi.ReadOnly = true;
            dgvFaturaListesi.RowHeadersWidth = 51;
            dgvFaturaListesi.RowTemplate.Height = 32;
            dgvFaturaListesi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFaturaListesi.Size = new Size(721, 320);
            dgvFaturaListesi.TabIndex = 1;
            // 
            // btnOdenen
            // 
            btnOdenen.BackColor = Color.MediumSeaGreen;
            btnOdenen.FlatStyle = FlatStyle.Flat;
            btnOdenen.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOdenen.ForeColor = Color.White;
            btnOdenen.Location = new Point(30, 410);
            btnOdenen.Name = "btnOdenen";
            btnOdenen.Size = new Size(237, 40);
            btnOdenen.TabIndex = 2;
            btnOdenen.Text = "Ödendi Olarak İşaretle";
            btnOdenen.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(285, 410);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(200, 40);
            btnSil.TabIndex = 3;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // FaturaListesiForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(781, 480);
            Controls.Add(lblTitle);
            Controls.Add(dgvFaturaListesi);
            Controls.Add(btnOdenen);
            Controls.Add(btnSil);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(700, 480);
            Name = "FaturaListesiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fatura Listesi";
            ((System.ComponentModel.ISupportInitialize)dgvFaturaListesi).EndInit();
            ResumeLayout(false);
        }
    }
}
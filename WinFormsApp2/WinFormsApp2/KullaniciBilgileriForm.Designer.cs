namespace WinFormsApp2
{
    partial class KullaniciBilgileriForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView kullaniciTablosu;
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
            kullaniciTablosu = new DataGridView();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)kullaniciTablosu).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(607, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kullanıcı Bilgileri";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kullaniciTablosu
            // 
            kullaniciTablosu.AllowUserToAddRows = false;
            kullaniciTablosu.AllowUserToDeleteRows = false;
            kullaniciTablosu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kullaniciTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kullaniciTablosu.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kullaniciTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            kullaniciTablosu.ColumnHeadersHeight = 36;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            kullaniciTablosu.DefaultCellStyle = dataGridViewCellStyle4;
            kullaniciTablosu.Location = new Point(30, 60);
            kullaniciTablosu.MultiSelect = false;
            kullaniciTablosu.Name = "kullaniciTablosu";
            kullaniciTablosu.ReadOnly = true;
            kullaniciTablosu.RowHeadersWidth = 51;
            kullaniciTablosu.RowTemplate.Height = 28;
            kullaniciTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kullaniciTablosu.Size = new Size(545, 220);
            kullaniciTablosu.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.IndianRed;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(210, 295);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(207, 40);
            btnSil.TabIndex = 2;
            btnSil.Text = "Seçili Kullanıcıyı Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // KullaniciBilgileriForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(605, 360);
            Controls.Add(lblTitle);
            Controls.Add(kullaniciTablosu);
            Controls.Add(btnSil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "KullaniciBilgileriForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kullanıcı Bilgileri";
            ((System.ComponentModel.ISupportInitialize)kullaniciTablosu).EndInit();
            ResumeLayout(false);
        }
    }
}
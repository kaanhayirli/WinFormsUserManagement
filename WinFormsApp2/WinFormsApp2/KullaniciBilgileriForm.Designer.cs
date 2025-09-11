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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitle = new Label();
            kullaniciTablosu = new DataGridView();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)kullaniciTablosu).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(605, 40);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            kullaniciTablosu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            kullaniciTablosu.ColumnHeadersHeight = 36;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            kullaniciTablosu.DefaultCellStyle = dataGridViewCellStyle2;
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
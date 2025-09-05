namespace WinFormsApp2
{
    partial class KullaniciBilgileriForm
    {
        private System.ComponentModel.IContainer components = null;
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
            kullaniciTablosu = new DataGridView();
            btnSil = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)kullaniciTablosu).BeginInit();
            SuspendLayout();
            // 
            // kullaniciTablosu
            // 
            kullaniciTablosu.AllowUserToAddRows = false;
            kullaniciTablosu.AllowUserToDeleteRows = false;
            kullaniciTablosu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            kullaniciTablosu.ColumnHeadersHeight = 29;
            kullaniciTablosu.Location = new Point(39, 81);
            kullaniciTablosu.MultiSelect = false;
            kullaniciTablosu.Name = "kullaniciTablosu";
            kullaniciTablosu.ReadOnly = true;
            kullaniciTablosu.RowHeadersWidth = 51;
            kullaniciTablosu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            kullaniciTablosu.Size = new Size(380, 182);
            kullaniciTablosu.TabIndex = 0;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Location = new Point(133, 269);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(180, 35);
            btnSil.TabIndex = 1;
            btnSil.Text = "Seçili Kullanıcıyı Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(111, 24);
            label1.Name = "label1";
            label1.Size = new Size(234, 37);
            label1.TabIndex = 2;
            label1.Text = "Kullanıcı Bilgileri";
            // 
            // KullaniciBilgileriForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(452, 327);
            Controls.Add(label1);
            Controls.Add(kullaniciTablosu);
            Controls.Add(btnSil);
            Name = "KullaniciBilgileriForm";
            ((System.ComponentModel.ISupportInitialize)kullaniciTablosu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
    }
}
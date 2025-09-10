namespace WinFormsApp2
{
    partial class MainPage
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFaturaEkle;
        private System.Windows.Forms.TabPage tabPageFaturaListesi;
        private System.Windows.Forms.TabPage tabPageFaturaTakibi;
        private System.Windows.Forms.TabPage tabPageKullaniciBilgileri;
        private System.Windows.Forms.TabPage tabPageProfil;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPageFaturaEkle = new System.Windows.Forms.TabPage();
            tabPageFaturaListesi = new System.Windows.Forms.TabPage();
            tabPageFaturaTakibi = new System.Windows.Forms.TabPage();
            tabPageKullaniciBilgileri = new System.Windows.Forms.TabPage();
            tabPageProfil = new System.Windows.Forms.TabPage();

            tabControl1.SuspendLayout();
            SuspendLayout();

            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageFaturaEkle);
            tabControl1.Controls.Add(tabPageFaturaListesi);
            tabControl1.Controls.Add(tabPageFaturaTakibi);
            tabControl1.Controls.Add(tabPageKullaniciBilgileri);
            tabControl1.Controls.Add(tabPageProfil);
            tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControl1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            tabControl1.ItemSize = new System.Drawing.Size(140, 35);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.Appearance = TabAppearance.Normal;
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1000, 600);
            tabControl1.TabIndex = 0;
            tabControl1.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // tabPageFaturaEkle
            // 
            tabPageFaturaEkle.BackColor = System.Drawing.Color.White;
            tabPageFaturaEkle.Text = "Fatura Ekle";
            tabPageFaturaEkle.Padding = new Padding(10);

            // 
            // tabPageFaturaListesi
            // 
            tabPageFaturaListesi.BackColor = System.Drawing.Color.White;
            tabPageFaturaListesi.Text = "Fatura Listesi";
            tabPageFaturaListesi.Padding = new Padding(10);

            // 
            // tabPageFaturaTakibi
            // 
            tabPageFaturaTakibi.BackColor = System.Drawing.Color.White;
            tabPageFaturaTakibi.Text = "Fatura Takibi";
            tabPageFaturaTakibi.Padding = new Padding(10);

            // 
            // tabPageKullaniciBilgileri
            // 
            tabPageKullaniciBilgileri.BackColor = System.Drawing.Color.White;
            tabPageKullaniciBilgileri.Text = "Kullanıcı Bilgileri";
            tabPageKullaniciBilgileri.Padding = new Padding(10);

            // 
            // tabPageProfil
            // 
            tabPageProfil.BackColor = System.Drawing.Color.White;
            tabPageProfil.Text = "Profil";
            tabPageProfil.Padding = new Padding(10);

            // 
            // MainPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 600);
            BackColor = System.Drawing.Color.WhiteSmoke;
            Controls.Add(tabControl1);
            Name = "MainPage";
            Text = "Ana Sayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainPage_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}

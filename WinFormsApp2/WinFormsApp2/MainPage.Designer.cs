namespace WinFormsApp2
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Temizleme işlemi
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Designer için gerekli method
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            faturaIslemleriToolStripMenuItem = new ToolStripMenuItem();
            faturaEkleToolStripMenuItem = new ToolStripMenuItem();
            faturaListesiToolStripMenuItem = new ToolStripMenuItem();
            faturaTakibiToolStripMenuItem = new ToolStripMenuItem();
            kullaniciIslemleriToolStripMenuItem = new ToolStripMenuItem();
            kullaniciBilgileriToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıProfiliToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            cmbFaturaTipi = new ComboBox();
            mainPanel = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { faturaIslemleriToolStripMenuItem, kullaniciIslemleriToolStripMenuItem, cikisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(407, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // faturaIslemleriToolStripMenuItem
            // 
            faturaIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { faturaEkleToolStripMenuItem, faturaListesiToolStripMenuItem, faturaTakibiToolStripMenuItem });
            faturaIslemleriToolStripMenuItem.Name = "faturaIslemleriToolStripMenuItem";
            faturaIslemleriToolStripMenuItem.Size = new Size(123, 24);
            faturaIslemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // faturaEkleToolStripMenuItem
            // 
            faturaEkleToolStripMenuItem.Name = "faturaEkleToolStripMenuItem";
            faturaEkleToolStripMenuItem.Size = new Size(176, 26);
            faturaEkleToolStripMenuItem.Text = "Fatura Ekle";
            faturaEkleToolStripMenuItem.Click += faturaEkleToolStripMenuItem_Click;
            // 
            // faturaListesiToolStripMenuItem
            // 
            faturaListesiToolStripMenuItem.Name = "faturaListesiToolStripMenuItem";
            faturaListesiToolStripMenuItem.Size = new Size(176, 26);
            faturaListesiToolStripMenuItem.Text = "Fatura Listesi";
            faturaListesiToolStripMenuItem.Click += faturaListesiToolStripMenuItem_Click;
            // 
            // faturaTakibiToolStripMenuItem
            // 
            faturaTakibiToolStripMenuItem.Name = "faturaTakibiToolStripMenuItem";
            faturaTakibiToolStripMenuItem.Size = new Size(176, 26);
            faturaTakibiToolStripMenuItem.Text = "Fatura Takibi";
            faturaTakibiToolStripMenuItem.Click += faturaTakibiToolStripMenuItem_Click;
            // 
            // kullaniciIslemleriToolStripMenuItem
            // 
            kullaniciIslemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kullaniciBilgileriToolStripMenuItem, kullanıcıProfiliToolStripMenuItem });
            kullaniciIslemleriToolStripMenuItem.Name = "kullaniciIslemleriToolStripMenuItem";
            kullaniciIslemleriToolStripMenuItem.Size = new Size(139, 24);
            kullaniciIslemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // kullaniciBilgileriToolStripMenuItem
            // 
            kullaniciBilgileriToolStripMenuItem.Name = "kullaniciBilgileriToolStripMenuItem";
            kullaniciBilgileriToolStripMenuItem.Size = new Size(203, 26);
            kullaniciBilgileriToolStripMenuItem.Text = "Kullanıcı Bilgileri";
            kullaniciBilgileriToolStripMenuItem.Click += kullaniciBilgileriToolStripMenuItem_Click;
            // 
            // kullanıcıProfiliToolStripMenuItem
            // 
            kullanıcıProfiliToolStripMenuItem.Name = "kullanıcıProfiliToolStripMenuItem";
            kullanıcıProfiliToolStripMenuItem.Size = new Size(203, 26);
            kullanıcıProfiliToolStripMenuItem.Text = "Profil";
            kullanıcıProfiliToolStripMenuItem.Click += profilToolStripMenuItem1_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(53, 24);
            cikisToolStripMenuItem.Text = "Çıkış";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;
            // 
            // cmbFaturaTipi
            // 
            cmbFaturaTipi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFaturaTipi.FormattingEnabled = true;
            cmbFaturaTipi.Items.AddRange(new object[] { "Elektrik", "Su", "Doğalgaz", "Aidat", "Kira" });
            cmbFaturaTipi.Location = new Point(16, 42);
            cmbFaturaTipi.Margin = new Padding(4, 5, 4, 5);
            cmbFaturaTipi.Name = "cmbFaturaTipi";
            cmbFaturaTipi.Size = new Size(160, 28);
            cmbFaturaTipi.TabIndex = 1;
            // 
            // mainPanel
            // 
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 30);
            mainPanel.Margin = new Padding(4, 5, 4, 5);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(407, 225);
            mainPanel.TabIndex = 2;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 255);
            Controls.Add(mainPanel);
            Controls.Add(cmbFaturaTipi);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainPage";
            Text = "Ana Sayfa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem faturaIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaTakibiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullaniciBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifreDegistirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbFaturaTipi;
        private System.Windows.Forms.Panel mainPanel;
        private ToolStripMenuItem kullanıcıProfiliToolStripMenuItem;
    }
}

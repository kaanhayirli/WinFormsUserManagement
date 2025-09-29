using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainPage : Form
    {
        
        public static int AktifKullaniciId { get; set; }

        private FaturaListesiForm faturaListesiForm;
        private FaturaTakibiForm faturaTakibiForm;

        public MainPage()
        {
            InitializeComponent();
            this.FormClosed += MainPage_FormClosed;
        }

        private void MainPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            var faturaEkleForm = new FaturaEkleForm();
            faturaEkleForm.TopLevel = false;
            faturaEkleForm.Dock = DockStyle.Fill;
            tabPageFaturaEkle.Controls.Add(faturaEkleForm);
            faturaEkleForm.Show();

            faturaListesiForm = new FaturaListesiForm();
            faturaListesiForm.TopLevel = false;
            faturaListesiForm.Dock = DockStyle.Fill;
            tabPageFaturaListesi.Controls.Add(faturaListesiForm);
            faturaListesiForm.Show();

            faturaTakibiForm = new FaturaTakibiForm();
            faturaTakibiForm.TopLevel = false;
            faturaTakibiForm.Dock = DockStyle.Fill;
            tabPageFaturaTakibi.Controls.Add(faturaTakibiForm);
            faturaTakibiForm.Show();

            var kullaniciBilgileriForm = new KullaniciBilgileriForm();
            kullaniciBilgileriForm.TopLevel = false;
            kullaniciBilgileriForm.Dock = DockStyle.Fill;
            tabPageKullaniciBilgileri.Controls.Add(kullaniciBilgileriForm);
            kullaniciBilgileriForm.Show();

            var profilForm = new ProfilForm(AktifKullaniciId);
            profilForm.TopLevel = false;
            profilForm.Dock = DockStyle.Fill;
            tabPageProfil.Controls.Add(profilForm);
            profilForm.Show();

            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;
        }
        
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPageFaturaListesi && faturaListesiForm != null)
            {
                faturaListesiForm.LoadFaturalar();
            }
            else if (tabControl1.SelectedTab == tabPageFaturaTakibi && faturaTakibiForm != null)
            {
                faturaTakibiForm.LoadKullaniciBorclari();
            }
        }
    }
}

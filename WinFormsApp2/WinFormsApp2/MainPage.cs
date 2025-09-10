using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainPage : Form
    {
        // Aktif kullanıcı ID'sini burada saklayabilirsin.
        public static int AktifKullaniciId { get; set; }

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

            var faturaListesiForm = new FaturaListesiForm();
            faturaListesiForm.TopLevel = false;
            faturaListesiForm.Dock = DockStyle.Fill;
            tabPageFaturaListesi.Controls.Add(faturaListesiForm);
            faturaListesiForm.Show();

            var faturaTakibiForm = new FaturaTakibiForm();
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
        }
    }
}
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
        }

        private void faturaEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FaturaEkleForm();
            form.ShowDialog();
        }

        private void faturaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FaturaListesiForm();
            form.ShowDialog();
        }

        private void faturaTakibiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FaturaTakibiForm();
            form.ShowDialog();
        }

        private void kullaniciBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new KullaniciBilgileriForm();
            form.ShowDialog();
        }

        private void sifreDegistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aktif kullanıcı ID'sini ProfilForm'a gönderiyoruz.
            var form = new ProfilForm(AktifKullaniciId);
            form.ShowDialog();
        }
        
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void profilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Eğer ayrı bir profil menüsü varsa, burada da ProfilForm açabilirsin.
            var form = new ProfilForm(AktifKullaniciId);
            form.ShowDialog();
        }
    }
}
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ProfilForm : Form
    {
        private int aktifKullaniciId;

        public ProfilForm(int kullaniciId)
        {
            aktifKullaniciId = kullaniciId;
            InitializeComponent();
            LoadProfil();
        }

        private void LoadProfil()
        {
            var servis = new UserService();
            var bilgiler = servis.KullaniciBilgisiGetir(aktifKullaniciId);
            txtUsername.Text = bilgiler.Username;
            txtFullName.Text = bilgiler.FullName;
            txtPhone.Text = bilgiler.Phone;
        }
        
        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text;
            string yeniSifre = txtYeniSifre.Text;

            if (eskiSifre == "" || yeniSifre == "")
            {
                MessageBox.Show("Lütfen eski ve yeni şifreyi girin!");
                return;
            }

            var servis = new UserService();
            bool basarili = servis.SifreDegistir(aktifKullaniciId, eskiSifre, yeniSifre);

            MessageBox.Show(basarili ? "Şifre başarıyla değiştirildi." : "Eski şifre yanlış veya şifre değiştirilemedi.");
            txtEskiSifre.Text = "";
            txtYeniSifre.Text = "";
        }
    }
}
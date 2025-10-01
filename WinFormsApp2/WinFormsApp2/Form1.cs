using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciadi = txtLoginUsername.Text.Trim();
            string sifre = txtLoginPassword.Text;

            if (kullaniciadi == "" || sifre == "")
            {
                MessageBox.Show("Lütfen kullanýcý adý ve þifreyi girin.");
                return;
            }

            var userService = new UserService();
            int bulunanKullaniciId = userService.KullaniciIdGetir(kullaniciadi, sifre);

            if (bulunanKullaniciId > 0)
            {
                MainPage.AktifKullaniciId = bulunanKullaniciId;
                MainPage anaForm = new MainPage();
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ!");
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }
    }
}

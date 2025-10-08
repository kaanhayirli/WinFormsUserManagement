using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace WinFormsApp2
{
    public partial class RegistrationForm : Form
    {
        public static List<User> Users = new List<User>();

        public RegistrationForm()
        {
            InitializeComponent();
        }
        
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string adsoyad = txtFullName.Text;
            string kullaniciadi = txtUsername.Text;
            string tel = txtPhone.Text;
            string sifre = txtPassword.Text;

            if (adsoyad == "" || kullaniciadi == "" || tel == "" || sifre == "")
            {
                MessageBox.Show("Lütfen tüm alanlarý doldurunuz!");
                return;
            }

            var userService = new UserService();
            if (userService.KullaniciAdiVarMi(kullaniciadi))
            {
                MessageBox.Show("Kullanýcý adý var.");
                return;
            }

            bool basarili = userService.KullaniciKaydet(adsoyad, kullaniciadi, tel, sifre);
            if (basarili)
            {
                MessageBox.Show("Kayýt Baþarýlý.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kayýt baþarýsýz.");
            }
        }
    }
 
    public class User
    {
        public string FullName;
        public string Username;
        public string Phone;
        public string Password;
    }
}
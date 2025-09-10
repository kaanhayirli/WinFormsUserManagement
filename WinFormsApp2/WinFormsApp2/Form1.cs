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
                MessageBox.Show("L�tfen kullan�c� ad� ve �ifreyi girin.");
                return;
            }

            using (SqlConnection baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT COUNT(*) FROM Users WHERE Username=@Username AND Password=@Password";
                komut.Parameters.AddWithValue("@Username", kullaniciadi);
                komut.Parameters.AddWithValue("@Password", sifre);

                int sayi = (int)komut.ExecuteScalar();
                if (sayi > 0)
                {
                    // Kullan�c� ID'sini al
                    komut.CommandText = "SELECT Id FROM Users WHERE Username=@Username AND Password=@Password";
                    object sonuc = komut.ExecuteScalar();
                    if (sonuc != null)
                    {
                        int bulunanKullaniciId = Convert.ToInt32(sonuc);
                        MainPage.AktifKullaniciId = bulunanKullaniciId;
                    }

                    // Ana sayfay� a� ve giri� formunu kapat
                    MainPage anaForm = new MainPage();
                    anaForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre yanl��!");
                }
            }
        }
        
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }

    }
}

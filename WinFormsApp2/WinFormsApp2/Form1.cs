using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            //Kullan�c� ad�n� giri� kutusundan al�r ve ba�taki / sondaki bo�luklar� siler.
            string kullaniciadi = txtLoginUsername.Text.Trim();
            string sifre = txtLoginPassword.Text;

            if (kullaniciadi == "" || sifre == "")
            {
                MessageBox.Show("L�tfen kullan�c� ad� ve �ifreyi girin.");
                return;
            }
            
            using (SqlConnection baglanti = new SqlConnection(baglantiString))
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
                    //Ana formu a�madan �nce bulunan kullan�c� ID'sini al
                    komut.CommandText = "SELECT Id FROM Users WHERE Username=@Username AND Password=@Password";
                    object sonuc = komut.ExecuteScalar();
                    if (sonuc != null)
                    {
                        int bulunanKullaniciId = Convert.ToInt32(sonuc);
                        MainPage.AktifKullaniciId = bulunanKullaniciId; // Kullan�c� ID'sini ana forma aktar
                    }
                    
                    var anaForm = new MainPage();
                    anaForm.ShowDialog();
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

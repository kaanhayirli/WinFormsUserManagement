using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                MessageBox.Show("Boþ býrakma!");
                return;
            }

            bool varMi = false;
            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";

            using (SqlConnection baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();
                SqlCommand kontrolKomut = new SqlCommand();
                kontrolKomut.Connection = baglanti;
                kontrolKomut.CommandText = "SELECT COUNT(*) FROM Users WHERE Username=@Username";
                kontrolKomut.Parameters.AddWithValue("@Username", kullaniciadi);

                int sayi = (int)kontrolKomut.ExecuteScalar();
                if (sayi > 0)
                {
                    varMi = true;
                }
            }

            if (varMi)
            {
                MessageBox.Show("Kullanýcý adý var.");
                return;
            }
            
            using (SqlConnection baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();

                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into Users (FullName, Username, Phone, Password) values (@FullName,@Username,@Phone,@Password)";
                komut.Parameters.AddWithValue("@FullName", adsoyad);
                komut.Parameters.AddWithValue("@Username", kullaniciadi);
                komut.Parameters.AddWithValue("@Phone", tel);
                komut.Parameters.AddWithValue("@Password", sifre);

                komut.ExecuteNonQuery();
            }

            User yeni = new User();
            yeni.FullName = adsoyad;
            yeni.Username = kullaniciadi;
            yeni.Phone = tel;
            yeni.Password = sifre;
            Users.Add(yeni);

            MessageBox.Show("Kayýt Baþarýlý.");
            this.Close();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

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
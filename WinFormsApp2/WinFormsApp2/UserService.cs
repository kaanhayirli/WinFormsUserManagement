using System;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public class UserService
    {
        public int KullaniciIdGetir(string username, string password)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT Id FROM Users WHERE Username=@Username AND Password=@Password";
                komut.Parameters.AddWithValue("@Username", username);
                komut.Parameters.AddWithValue("@Password", password);

                object sonuc = komut.ExecuteScalar();
                return sonuc != null ? Convert.ToInt32(sonuc) : -1;
            }
        }


        public DataTable KullaniciListesiGetir()
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand("SELECT Id AS [Id], FullName AS [Ad Soyad], Phone AS [Telefon] FROM Users", baglanti);
                var dataAdapter = new SqlDataAdapter(komut);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public bool KullaniciSil(int id)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand("DELETE FROM Users WHERE Id=@Id", baglanti);
                komut.Parameters.AddWithValue("@Id", id);
                return komut.ExecuteNonQuery() > 0;
            }
        }

        public (string Username, string FullName, string Phone) KullaniciBilgisiGetir(int id)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand("SELECT Username, FullName, Phone FROM Users WHERE Id=@Id", baglanti);
                komut.Parameters.AddWithValue("@Id", id);
                var veriOkuyucu = komut.ExecuteReader();
                if (veriOkuyucu.Read())
                {
                    return (
                        veriOkuyucu["Username"].ToString(),
                        veriOkuyucu["FullName"].ToString(),
                        veriOkuyucu["Phone"].ToString()
                    );
                }
                return (null, null, null);
            }
        }

        public bool SifreDegistir(int id, string eskiSifre, string yeniSifre)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Id=@Id AND Password=@OldPassword", baglanti);
                kontrolKomut.Parameters.AddWithValue("@Id", id);
                kontrolKomut.Parameters.AddWithValue("@OldPassword", eskiSifre);
                int count = (int)kontrolKomut.ExecuteScalar();
                if (count == 0)
                    return false;

                var guncelleKomut = new SqlCommand("UPDATE Users SET Password=@NewPassword WHERE Id=@Id", baglanti);
                guncelleKomut.Parameters.AddWithValue("@NewPassword", yeniSifre);
                guncelleKomut.Parameters.AddWithValue("@Id", id);
                return guncelleKomut.ExecuteNonQuery() > 0;
            }
        }

        public bool KullaniciAdiVarMi(string username)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@Username", baglanti);
                komut.Parameters.AddWithValue("@Username", username);
                int sayi = (int)komut.ExecuteScalar();
                return sayi > 0;
            }
        }

        public bool KullaniciKaydet(string fullName, string username, string phone, string password)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand("INSERT INTO Users (FullName, Username, Phone, Password) VALUES (@FullName, @Username, @Phone, @Password)", baglanti);
                komut.Parameters.AddWithValue("@FullName", fullName);
                komut.Parameters.AddWithValue("@Username", username);
                komut.Parameters.AddWithValue("@Phone", phone);
                komut.Parameters.AddWithValue("@Password", password);
                return komut.ExecuteNonQuery() > 0;
            }
        }
    }
}
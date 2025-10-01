using System;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public class FaturaService
    {
        public bool FaturaEkle(string tur, decimal tutar, DateTime sonOdemeTarihi, string aciklama)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Faturalar (Tur, Tutar, SonOdemeTarihi, Aciklama, OdendiMi) VALUES (@Tur, @Tutar, @SonOdemeTarihi, @Aciklama, 0)";
                komut.Parameters.AddWithValue("@Tur", tur);
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@SonOdemeTarihi", sonOdemeTarihi);
                komut.Parameters.AddWithValue("@Aciklama", aciklama);

                return komut.ExecuteNonQuery() > 0;
            }
        }

        public DataTable FaturaListesiGetir()
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT Id AS [Id], Tur AS [Fatura Türü], Tutar AS [Tutar], SonOdemeTarihi AS [S.Ö.T], Aciklama AS [Açýklama], OdendiMi AS [Durum] FROM Faturalar";
                var dataAdapter = new SqlDataAdapter(komut);
                var dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public bool FaturaOde(string tur, decimal tutar, DateTime sonOdemeTarihi)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Faturalar SET OdendiMi=1 WHERE Tur=@Tur AND Tutar=@Tutar AND SonOdemeTarihi=@SonOdemeTarihi";
                komut.Parameters.AddWithValue("@Tur", tur);
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@SonOdemeTarihi", sonOdemeTarihi);
                return komut.ExecuteNonQuery() > 0;
            }
        }

        public bool FaturaSil(int id)
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM Faturalar WHERE Id=@Id";
                komut.Parameters.AddWithValue("@Id", id);
                return komut.ExecuteNonQuery() > 0;
            }
        }

        public DataTable KullaniciBorclariGetir()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("Ad Soyad", typeof(string));
            dataTable.Columns.Add("Toplam Borç", typeof(string));

            int kullaniciSayisi = 0;
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();

                var komutKullanici = new SqlCommand("SELECT COUNT(*) FROM Users", baglanti);
                kullaniciSayisi = (int)komutKullanici.ExecuteScalar();

                var komutFatura = new SqlCommand("SELECT SUM(Tutar) FROM Faturalar WHERE OdendiMi=0", baglanti);
                decimal toplamFatura = komutFatura.ExecuteScalar() != DBNull.Value ? Convert.ToDecimal(komutFatura.ExecuteScalar()) : 0;
                decimal kisiBorcu = kullaniciSayisi > 0 ? toplamFatura / kullaniciSayisi : 0;

                var komutListe = new SqlCommand("SELECT FullName FROM Users", baglanti);
                var veriOkuyucu = komutListe.ExecuteReader();
                while (veriOkuyucu.Read())
                {
                    dataTable.Rows.Add(veriOkuyucu["FullName"].ToString(), kisiBorcu.ToString("C2"));
                }
            }
            return dataTable;
        }
    }
}
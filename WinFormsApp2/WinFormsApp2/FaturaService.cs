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
    }
}
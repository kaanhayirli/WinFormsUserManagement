using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FaturaTakibiForm : Form
    {
        public FaturaTakibiForm()
        {
            InitializeComponent();
            LoadKullaniciBorclari();
        }

        private void LoadKullaniciBorclari()
        {
            dgvFaturaTakibi.Rows.Clear();//sor burayı
            dgvFaturaTakibi.Columns.Clear();//sor burayı
            dgvFaturaTakibi.Columns.Add("FullName", "Ad Soyad");
            dgvFaturaTakibi.Columns.Add("TotalDebt", "Toplam Borç");

            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";

            int kullaniciSayisi = 0;
            using (var baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();
                
                var komutKullanici = new SqlCommand();
                komutKullanici.Connection = baglanti;
                komutKullanici.CommandText = "SELECT COUNT(*) FROM Users";
                kullaniciSayisi = (int)komutKullanici.ExecuteScalar();

                var komutFatura = new SqlCommand();
                komutFatura.Connection = baglanti;
                komutFatura.CommandText = "SELECT SUM(Tutar) FROM Faturalar WHERE OdendiMi=0";
                decimal toplamFatura = komutFatura.ExecuteScalar() != DBNull.Value ? Convert.ToDecimal(komutFatura.ExecuteScalar()) : 0;//

                decimal kisiBorcu = kullaniciSayisi > 0 ? toplamFatura / kullaniciSayisi : 0;

                var komutListe = new SqlCommand();
                komutListe.Connection = baglanti;
                komutListe.CommandText = "SELECT FullName FROM Users";
                var veriOkuyucu = komutListe.ExecuteReader();
                while (veriOkuyucu.Read())
                {
                    dgvFaturaTakibi.Rows.Add(veriOkuyucu["FullName"].ToString(), kisiBorcu.ToString("C2"));
                }
            }
        }
    }
}
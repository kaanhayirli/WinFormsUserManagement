using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FaturaEkleForm : Form
    {
        
        public FaturaEkleForm()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbFaturaTipi.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTutar.Text) || string.IsNullOrWhiteSpace(txtAciklama.Text)) 
            { 
                MessageBox.Show("Lütfen tüm alanları doldurun!"); 
                return;
            }

            string faturaTipi = cmbFaturaTipi.SelectedItem.ToString();
            decimal tutar;
            DateTime sonTarih = dtpSonTarih.Value;
            string aciklama = txtAciklama.Text;

            if (!decimal.TryParse(txtTutar.Text, out tutar))
            {
                MessageBox.Show("Tutar sayısal olmalıdır!");
                return;
            }

            // Parametreleri kontrol et
            MessageBox.Show($"Tur: {faturaTipi}\nTutar: {tutar}\nSon Tarih: {sonTarih}\nAçıklama: {aciklama}\nUserId: {MainPage.AktifKullaniciId}");

            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";
            using (var baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();
                var komut = new SqlCommand();

                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Faturalar (Tur, Tutar, SonOdemeTarihi, Aciklama, OdendiMi, UserId) " + "VALUES (@Tur, @Tutar, @SonOdemeTarihi, @Aciklama, 0, @UserId); SELECT SCOPE_IDENTITY();";
                komut.Parameters.AddWithValue("@Tur", faturaTipi);
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@SonOdemeTarihi", sonTarih);
                komut.Parameters.AddWithValue("@Aciklama", aciklama);
                komut.Parameters.AddWithValue("@UserId", MainPage.AktifKullaniciId);

                object idObj = komut.ExecuteScalar();
                if (idObj == null || idObj == DBNull.Value)
                {
                    MessageBox.Show("Fatura ID alınamadı, işlem iptal edildi.");
                    return;
                }
                int yeniFaturaId = Convert.ToInt32(idObj);

                // Tüm kullanıcıları çek
                List<int> kullaniciIdList = new List<int>();
                using (var komut3 = new SqlCommand("SELECT Id FROM Users", baglanti))
                using (var dr = komut3.ExecuteReader())
                {
                    while (dr.Read())
                        kullaniciIdList.Add(Convert.ToInt32(dr["Id"]));
                }

                // Kişi başı borç
                decimal kisiBasiBorc = tutar / kullaniciIdList.Count;

                // Her kullanıcı için KullaniciFaturaBorcu tablosuna kayıt ekle
                foreach (var userId in kullaniciIdList)
                {
                    using (var komut4 = new SqlCommand("INSERT INTO KullaniciFaturaBorcu (FaturaId, UserId, Borc, OdendiMi) VALUES (@FaturaId, @UserId, @Borc, 0)", baglanti))
                    {
                        komut4.Parameters.AddWithValue("@FaturaId", yeniFaturaId);
                        komut4.Parameters.AddWithValue("@UserId", userId);
                        komut4.Parameters.AddWithValue("@Borc", kisiBasiBorc);
                        komut4.ExecuteNonQuery();
                    }
                }
            }

            cmbFaturaTipi.SelectedIndex = -1;
            txtTutar.Text = "";
            dtpSonTarih.Value = DateTime.Now;
            txtAciklama.Text = "";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAciklama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
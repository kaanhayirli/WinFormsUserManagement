using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class ProfilForm : Form
    {
        private int aktifKullaniciId;

        public ProfilForm(int kullaniciId)
        {
            aktifKullaniciId = kullaniciId;
            InitializeComponent();
            LoadProfil();
            LoadFaturalar();
        }

        private void LoadProfil()
        {
            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";
            using (var baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT FullName, Phone FROM Users Where Id=@Id";
                komut.Parameters.AddWithValue("@Id", aktifKullaniciId);
                var veriOkuyucu = komut.ExecuteReader();
                if (veriOkuyucu.Read())
                {
                    lblFullName.Text = "Ad Soyad: " + veriOkuyucu["FullName"].ToString();
                    lblPhone.Text = "Telefon: " + veriOkuyucu["Phone"].ToString();
                }
            }
        }

        private void LoadFaturalar()
        {
            dgvOdenen.Rows.Clear();
            dgvOdenen.Columns.Clear();
            dgvOdenen.Columns.Add("Tur", "Fatura Tipi");
            dgvOdenen.Columns.Add("Tutar", "Tutar");
            dgvOdenen.Columns.Add("SonOdemeTarihi", "Son Tarih");
            dgvOdenen.Columns.Add("Aciklama", "Açıklama");

            dgvOdenmemis.Rows.Clear();
            dgvOdenmemis.Columns.Clear();
            dgvOdenmemis.Columns.Add("Tur", "Fatura Tipi");
            dgvOdenmemis.Columns.Add("Tutar", "Tutar");
            dgvOdenmemis.Columns.Add("SonOdemeTarihi", "Son Tarih");
            dgvOdenmemis.Columns.Add("Aciklama", "Açıklama");

            decimal toplamBorc = 0;
            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";
            using (var baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();

                // Ödenen faturalar
                var komutOdenen = new SqlCommand();
                komutOdenen.Connection = baglanti;
                komutOdenen.CommandText = "SELECT Tur, Tutar, SonOdemeTarihi, Aciklama FROM Faturalar WHERE UserId=@UserId AND OdendiMi=1";
                komutOdenen.Parameters.AddWithValue("@UserId", aktifKullaniciId);
                var veriOkuyucuOdenen = komutOdenen.ExecuteReader();
                while (veriOkuyucuOdenen.Read())
                {
                    dgvOdenen.Rows.Add(
                        veriOkuyucuOdenen["Tur"].ToString(),
                        veriOkuyucuOdenen["Tutar"].ToString(),
                        Convert.ToDateTime(veriOkuyucuOdenen["SonOdemeTarihi"]).ToShortDateString(),
                        veriOkuyucuOdenen["Aciklama"].ToString());
                }
                veriOkuyucuOdenen.Close();

                // Ödenmemiş faturalar ve toplam borç
                var komutOdenmemis = new SqlCommand();
                komutOdenmemis.Connection = baglanti;
                komutOdenmemis.CommandText = "SELECT Tur, Tutar, SonOdemeTarihi, Aciklama FROM Faturalar WHERE UserId=@UserId AND OdendiMi=0";
                komutOdenmemis.Parameters.AddWithValue("@UserId", aktifKullaniciId);
                var veriOkuyucuOdenmemis = komutOdenmemis.ExecuteReader();
                while (veriOkuyucuOdenmemis.Read())
                {
                    dgvOdenmemis.Rows.Add(
                        veriOkuyucuOdenmemis["Tur"].ToString(),
                        veriOkuyucuOdenmemis["Tutar"].ToString(),
                        Convert.ToDateTime(veriOkuyucuOdenmemis["SonOdemeTarihi"]).ToShortDateString(),
                        veriOkuyucuOdenmemis["Aciklama"].ToString());
                    toplamBorc += Convert.ToDecimal(veriOkuyucuOdenmemis["Tutar"]);
                }
                veriOkuyucuOdenmemis.Close();
            }

            lblOdenmemis.Text = $"Ödenmemiş Faturalar (Toplam Borç: {toplamBorc:C2})";
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            string eskiSifre = txtEskiSifre.Text;
            string yeniSifre = txtYeniSifre.Text;

            if (eskiSifre == "" || yeniSifre == "")
            {
                MessageBox.Show("Lütfen eski ve yeni şifreyi girin!");
                return;
            }

            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";
            using (var baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();
                var kontrolKomut = new SqlCommand();
                kontrolKomut.Connection = baglanti;
                kontrolKomut.CommandText = "SELECT COUNT(*) FROM Users WHERE Id=@Id AND Password=@OldPassword";
                kontrolKomut.Parameters.AddWithValue("@Id", aktifKullaniciId);
                kontrolKomut.Parameters.AddWithValue("@OldPassword", eskiSifre);

                int count = (int)kontrolKomut.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("Eski şifre yanlış!");
                    return;
                }

                var guncelleKomut = new SqlCommand();
                guncelleKomut.Connection = baglanti;
                guncelleKomut.CommandText = "UPDATE Users SET Password=@NewPassword WHERE Id=@Id";
                guncelleKomut.Parameters.AddWithValue("@NewPassword", yeniSifre);
                guncelleKomut.Parameters.AddWithValue("@Id", aktifKullaniciId);

                int result = guncelleKomut.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                else
                    MessageBox.Show("Şifre değiştirilemedi.");
            }
            txtEskiSifre.Text = "";
            txtYeniSifre.Text = "";
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Telefon labelına tıklandı.");
        }

        private void lblOdenmemis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödenmemiş Faturalar labelına tıklandı.");
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
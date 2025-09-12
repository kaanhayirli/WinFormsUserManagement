using System;
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

            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Faturalar (Tur, Tutar, SonOdemeTarihi, Aciklama, OdendiMi) VALUES (@Tur, @Tutar, @SonOdemeTarihi, @Aciklama, 0)";
                komut.Parameters.AddWithValue("@Tur", faturaTipi);
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@SonOdemeTarihi", sonTarih);
                komut.Parameters.AddWithValue("@Aciklama", aciklama);

                int sonuc = komut.ExecuteNonQuery();
                if (sonuc > 0)
                {
                    MessageBox.Show("Fatura başarıyla eklendi.");
                }
                else
                {
                    MessageBox.Show("Fatura eklenemedi.");
                }
            }

            cmbFaturaTipi.SelectedIndex = -1;
            txtTutar.Text = "";
            dtpSonTarih.Value = DateTime.Now;
            txtAciklama.Text = "";
        }
    }
}
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

            // cmbFaturaTipi.SelectedIndex = -1; txtAciklama.Text = ""; txtTutar.Text = ""; 
            if (cmbFaturaTipi.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTutar.Text) || string.IsNullOrWhiteSpace(txtAciklama.Text)) 
            { 
                MessageBox.Show("Lütfen tüm alanları doldurun!"); 
                return;
            }

            //if (txtTutar.Text == "")
            //{
            //    MessageBox.Show("Tutar giriniz!");
            //    return;
            //}
            //else
            //{
            //    tutar = decimal.Parse(txtTutar.Text);
            //} bu satırlar hata verdi chatten aldım 

            string faturaTipi = cmbFaturaTipi.SelectedItem.ToString();
            decimal tutar;
            DateTime sonTarih = dtpSonTarih.Value;
            string aciklama = txtAciklama.Text;

            if (!decimal.TryParse(txtTutar.Text, out tutar))

            {
                MessageBox.Show("Tutar sayısal olmalıdır!");
                return;
            }

            

            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";
            using (var baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO Faturalar (Tur, Tutar, SonOdemeTarihi, Aciklama, OdendiMi, UserId) VALUES (@Tur, @Tutar, @SonOdemeTarihi, @Aciklama, 0, @UserId)";
                komut.Parameters.AddWithValue("@Tur", faturaTipi);
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@SonOdemeTarihi", sonTarih);
                komut.Parameters.AddWithValue("@Aciklama", aciklama);
                komut.Parameters.AddWithValue("@UserId", MainPage.AktifKullaniciId);

                int result = komut.ExecuteNonQuery();
                if (result > 0)
                    MessageBox.Show("Fatura başarıyla eklendi.");
                else
                    MessageBox.Show("Fatura eklenemedi.");
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
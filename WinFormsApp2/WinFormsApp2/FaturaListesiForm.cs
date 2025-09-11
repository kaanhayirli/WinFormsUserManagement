using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FaturaListesiForm : Form
    {
        public FaturaListesiForm()
        {
            InitializeComponent();
            LoadFaturalar();
            btnOdenen.Click += btnOdenen_Click;
            btnSil.Click += btnSil_Click;
        }

        private void LoadFaturalar()
        {
            //dgvFaturaListesi.Rows.Clear();//sor burayı
            //dgvFaturaListesi.Columns.Clear();//sor burayı
            //dgvFaturaListesi.Columns.Add("Id", "Id");
            //dgvFaturaListesi.Columns.Add("Tur", "Fatura Tipi");
            //dgvFaturaListesi.Columns.Add("Tutar", "Tutar");
            //dgvFaturaListesi.Columns.Add("SonOdemeTarihi", "Son Tarih");
            //dgvFaturaListesi.Columns.Add("Aciklama", "Açıklama");
            //dgvFaturaListesi.Columns.Add("OdendiMi", "Ödendi mi?");

            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT Id, Tur, Tutar, SonOdemeTarihi, Aciklama, OdendiMi FROM Faturalar";
                var adapter = new SqlDataAdapter(komut);
                var dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);
                dgvFaturaListesi.DataSource = dataTable;
                var veriOkuyucu = komut.ExecuteReader();

                while (veriOkuyucu.Read())
                {
                    string odendiMiText = "Hayır";
                    if (veriOkuyucu["OdendiMi"] != null && Convert.ToBoolean(veriOkuyucu["OdendiMi"]) == true)
                    {
                        odendiMiText = "Evet";
                    }
                }
            }
        }

        private void btnOdenen_Click(object sender, EventArgs e)
        {
            if (dgvFaturaListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir fatura seçin!");
                return;
            }
            var row = dgvFaturaListesi.SelectedRows[0];
            string faturaTipi = row.Cells["Tur"].Value.ToString();
            decimal tutar = Convert.ToDecimal(row.Cells["Tutar"].Value);
            string sonTarih = row.Cells["SonOdemeTarihi"].Value.ToString();

            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE Faturalar SET OdendiMi=1 WHERE Tur=@Tur AND Tutar=@Tutar AND SonOdemeTarihi=@SonOdemeTarihi";
                komut.Parameters.AddWithValue("@Tur", faturaTipi);
                komut.Parameters.AddWithValue("@Tutar", tutar);
                komut.Parameters.AddWithValue("@SonOdemeTarihi", DateTime.Parse(sonTarih));
                komut.ExecuteNonQuery();
            }
            MessageBox.Show("Fatura ödendi olarak işaretlendi.");
            LoadFaturalar();
        }
        private void btnSil_Click(Object sender, EventArgs e)
        {
            if (dgvFaturaListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir fatura seçin!");
                return;
            }

            var seciliSatir = dgvFaturaListesi.SelectedRows[0];
            int seciliFatura = Convert.ToInt32(seciliSatir.Cells["Id"].Value);
            var sonuc = MessageBox.Show("Faturayı silmek istediğinize emin misiniz?", "Fatura Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (sonuc != DialogResult.Yes)
                return;

            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();

                // Önce ilişkili FaturaOdeme kayıtlarını sil
                var komutFaturaOdeme = new SqlCommand();
                komutFaturaOdeme.Connection = baglanti;
                komutFaturaOdeme.CommandText = "DELETE FROM FaturaOdeme WHERE FaturaId=@FaturaId";
                komutFaturaOdeme.Parameters.AddWithValue("@FaturaId", seciliFatura);
                komutFaturaOdeme.ExecuteNonQuery();

                // Sonra faturayı sil
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM Faturalar WHERE Id=@Id";
                komut.Parameters.AddWithValue("@Id", seciliFatura);
                int result = komut.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Fatura başarıyla silindi.");
                    LoadFaturalar();
                }
                else
                {
                    MessageBox.Show("Fatura silinirken bir hata oluştu.");
                }
            }
        }
    }
}
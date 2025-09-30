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

        public void LoadFaturalar()
        {

            var servis = new FaturaService();
            dgvFaturaListesi.DataSource = servis.FaturaListesiGetir();

        }

        private void btnOdenen_Click(object sender, EventArgs e)
        {
            if (dgvFaturaListesi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir fatura seçin!");
                return;
            }
            var row = dgvFaturaListesi.SelectedRows[0];
            string faturaTipi = row.Cells["Fatura Türü"].Value.ToString();
            decimal tutar = Convert.ToDecimal(row.Cells["Tutar"].Value);
            string sonTarih = row.Cells["S.Ö.T"].Value.ToString();

            var servis = new FaturaService();
            bool basarili = servis.FaturaOde(faturaTipi, tutar, DateTime.Parse(sonTarih));
            MessageBox.Show(basarili ? "Fatura ödendi olarak işaretlendi." : "Fatura işaretlenemedi.");
 
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

            var servis = new FaturaService();
            bool basarili = servis.FaturaSil(seciliFatura);

            if (basarili)
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

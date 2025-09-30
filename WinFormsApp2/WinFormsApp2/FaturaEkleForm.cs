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

            var servis = new FaturaService();
            bool basarili = servis.FaturaEkle(faturaTipi, tutar, sonTarih, aciklama);
            
            if (basarili)
            
            {
                MessageBox.Show("Fatura başarıyla eklendi.");
            }
            else
            {
                MessageBox.Show("Fatura eklenemedi.");
            }
            
            cmbFaturaTipi.SelectedIndex = -1;
            txtTutar.Text = "";
            dtpSonTarih.Value = DateTime.Now;
            txtAciklama.Text = "";
        }
    }
}
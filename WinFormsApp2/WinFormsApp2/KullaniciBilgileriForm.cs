using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class KullaniciBilgileriForm : Form
    {
        public KullaniciBilgileriForm()
        {
            InitializeComponent();
            LoadKullaniciBilgileri();
        }

        private void LoadKullaniciBilgileri()
        {
            var servis = new UserService();
            kullaniciTablosu.DataSource = servis.KullaniciListesiGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kullaniciTablosu.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kullanıcı seçin!");
                return;
            }

            var seciliSatir = kullaniciTablosu.SelectedRows[0];
            int seciliKisiId = Convert.ToInt32(seciliSatir.Cells["Id"].Value);

            var sonuc = MessageBox.Show("Kullanıcıyı silmek istediğinize emin misiniz?", "Kullanıcı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc != DialogResult.Yes)
                return;

            var servis = new UserService();
            bool silindi = servis.KullaniciSil(seciliKisiId);

            MessageBox.Show(silindi ? "Kullanıcı başarıyla silindi." : "Kullanıcı silinemedi.");
            LoadKullaniciBilgileri();
        }
    }
}

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
            kullaniciTablosu.Rows.Clear();
            kullaniciTablosu.Columns.Clear();
            kullaniciTablosu.Columns.Add("Id", "Id");
            kullaniciTablosu.Columns.Add("FullName", "Ad Soyad");
            kullaniciTablosu.Columns.Add("Phone", "Telefon");

            string baglantiString = "Server=KAAN-PC;Database=UserDB;User Id=sa;Password=Aa123456!;TrustServerCertificate=True;";
            using (var baglanti = new SqlConnection(baglantiString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT Id, FullName, Phone FROM Users";
                var veriOkuyucu = komut.ExecuteReader();

                while (veriOkuyucu.Read())
                {
                    kullaniciTablosu.Rows.Add(veriOkuyucu["Id"], veriOkuyucu["FullName"], veriOkuyucu["Phone"]);
                }
            }
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

            bool silindi = false;

            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();

                var komut1 = new SqlCommand();
                komut1.Connection = baglanti;
                komut1.CommandText = "DELETE FROM FaturaOdeme WHERE UserId=@Id";
                komut1.Parameters.AddWithValue("@Id", seciliKisiId);
                komut1.ExecuteNonQuery();

                var komut2 = new SqlCommand();
                komut2.Connection = baglanti;
                komut2.CommandText = "DELETE FROM Users WHERE Id=@Id";
                komut2.Parameters.AddWithValue("@Id", seciliKisiId);
                silindi = komut2.ExecuteNonQuery() > 0;
            }

            if (silindi)
                MessageBox.Show("Kullanıcı başarıyla silindi.");
            else
                MessageBox.Show("Kullanıcı silinemedi.");

            LoadKullaniciBilgileri();
        }

        private void kullaniciTablosu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kullaniciTablosu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

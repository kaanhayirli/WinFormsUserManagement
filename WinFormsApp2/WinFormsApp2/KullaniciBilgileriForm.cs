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
            //kullaniciTablosu.Rows.Clear();
            //kullaniciTablosu.Columns.Clear();
            //kullaniciTablosu.Columns.Add("Id", "Id");
            //kullaniciTablosu.Columns.Add("FullName", "Ad Soyad");
            //kullaniciTablosu.Columns.Add("Phone", "Telefon");

            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT Id AS [Id], FullName AS [Ad Soyad], Phone AS [Telefon] FROM Users";
                var dataTable = new System.Data.DataTable();
                var dataAdapter = new SqlDataAdapter(komut);
                dataAdapter.Fill(dataTable);
                kullaniciTablosu.DataSource = dataTable;
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
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM Users WHERE Id=@Id";
                komut.Parameters.AddWithValue("@Id", seciliKisiId);
                silindi = komut.ExecuteNonQuery() > 0;
            }

            if (silindi)
                MessageBox.Show("Kullanıcı başarıyla silindi.");
            else
                MessageBox.Show("Kullanıcı silinemedi.");

            LoadKullaniciBilgileri();
        }
    }
}

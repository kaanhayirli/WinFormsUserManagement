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
        }

        private void LoadProfil()
        {
            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
            {
                baglanti.Open();
                var komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "SELECT Username, FullName, Phone FROM Users Where Id=@Id";
                komut.Parameters.AddWithValue("@Id", aktifKullaniciId);
                var veriOkuyucu = komut.ExecuteReader();
                if (veriOkuyucu.Read())
                {
                    txtUsername.Text = veriOkuyucu["Username"].ToString();
                    txtFullName.Text = veriOkuyucu["FullName"].ToString();
                    txtPhone.Text = veriOkuyucu["Phone"].ToString();
                }
            }
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

            using (var baglanti = new SqlConnection(DatabaseConnection.ConnectionString))
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

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FaturaTakibiForm : Form
    {
        public event Action FaturaEklendi;
        public FaturaTakibiForm()
        {
            InitializeComponent();
            LoadKullaniciBorclari();
        }

        public void LoadKullaniciBorclari()
        {
            var servis = new FaturaService();
            dgvFaturaTakibi.DataSource = servis.KullaniciBorclariGetir();
        }

    }
}
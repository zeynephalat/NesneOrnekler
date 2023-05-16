using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneProjesi
{
    public partial class formKitapTur : Form
    {
        public formKitapTur()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtislemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;
        
        private void formKitapTur_Load(object sender, EventArgs e)
        {
            TurleriListele();
        }

        private void TurleriListele()
        {
            try
            {
                baglanti = vtislemleri.baglan();
                komutSatiri = "Select * Form kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri,baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitapTur.DataSource = dataTable;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

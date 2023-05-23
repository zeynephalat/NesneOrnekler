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
                komutSatiri = "Select * FROM kitap_turleri";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri,baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                gridKitapTur.DataSource = dataTable;
                gridKitapTur.Columns["tur_id"].HeaderText = "ID";
                gridKitapTur.Columns["tur_id"].Width = 100;
                gridKitapTur.Columns["tur_adi"].HeaderText = "tur_adi";
                gridKitapTur.Columns["tur_adi"].Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "INSERT INTO kitap_turleri (tur_adi) VALUES (@tur_adi)";
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("işlem başarılı ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand(komutSatiri,baglanti);
                komut.Connection = baglanti;
                komut.CommandText = "DELETE FROM kitap_turleri WHERE tur_id = @tur_id";
                komut.Parameters.AddWithValue("tur_id", gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                TurleriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
             
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "UPDATE kitap_turleri SET tur_adi=@tur_adi where tur_id=@tur_id";
                komut.Parameters.AddWithValue("@tur_id", int.Parse(gridKitapTur.CurrentRow.Cells["tur_id"].Value.ToString()));
                komut.Parameters.AddWithValue("@tur_adi", txtTurAdi.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                txtTurAdi.Clear(); MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); MessageBox.Show("işlem başarılı");
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message, "hata oluştu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void gridKitapTur_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtTurAdi.Text = gridKitapTur.CurrentRow.Cells["tur_adi"].Value.ToString();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "hata oluştu ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}

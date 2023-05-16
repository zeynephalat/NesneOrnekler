using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneProjesi
{
    public partial class formOgrenci : Form
    {
        
        public formOgrenci()
        {
            InitializeComponent();
        }
        VeriTabaniIslemleri vtIslemleri = new VeriTabaniIslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;

        private void formOgrenci_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM ogrenciler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                GridOgrenci.DataSource = dataTable;
                GridOgrenci.Columns["ogrenci_no"].HeaderText = "Öğrenci Numarası";
                GridOgrenci.Columns["ad"].HeaderText = "Ad";
                GridOgrenci.Columns["soyad"].HeaderText = "soyad";
                GridOgrenci.Columns["sinif"].HeaderText = "sinifı";
                GridOgrenci.Columns["cinsiyet"].HeaderText = "cinsiyet";
                GridOgrenci.Columns["telefon"].HeaderText = "telefon";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
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
                komutSatiri = "INSERT INTO ogrenciler (ogrenci_no,ad,soyad,sinif,cinsiyet,telefon) values (@no,@ad,@soyad,@sinif,@cinsiyet,@telefon)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(txtNo.Text));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(combosınıf.SelectedIndex.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", int.Parse(combocinsiyet.SelectedIndex.ToString()));
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();
            txtTelefon.Clear();

        }

        private void GridOgrenci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNo.Text = GridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtAd.Text = GridOgrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtSoyad.Text = GridOgrenci.CurrentRow.Cells["soyad"].Value.ToString();
                txtTelefon.Text = GridOgrenci.CurrentRow.Cells["telefon"].Value.ToString();
                combosınıf.Text = GridOgrenci.CurrentRow.Cells["sinif"].Value.ToString();
                combocinsiyet.Text = GridOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("hata oluştu", "mesaj",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komutSatiri = "DELETE FORM ogrenciler WHERE ogrenci_no = @no";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(GridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString()));
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
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
                komutSatiri = "UPDATE ogrenciler SET ad=@ad,soyad=@soyad,sinif=@sinif,cinsiyet=@cinsiyet,telefon=@telefon where ogrenci_no=@no";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@no", int.Parse(GridOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString()));
                komut.Parameters.AddWithValue("@ad", txtAd.Text);
                komut.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(combosınıf.SelectedIndex.ToString()));
                komut.Parameters.AddWithValue("@cinsiyet", int.Parse(combocinsiyet.SelectedIndex.ToString()));
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                Temizle();
                MessageBox.Show("işlem başarılı", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            OgrenciArama(txtArama.Text);
        }

        private void OgrenciArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select * from ogrenciler where ad like '" + aranacakKelime + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                GridOgrenci.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
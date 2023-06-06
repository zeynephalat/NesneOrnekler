using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SinavProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeriTabaniİslemleri vtIslemleri = new VeriTabaniİslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "SELECT * FROM urun";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                GridUrun.DataSource = dataTable;
                GridUrun.Columns["urun_adi"].HeaderText = "urun_adi";
                GridUrun.Columns["fiyat"].HeaderText = "fiyat";
                GridUrun.Columns["adet"].HeaderText = "adet";
                
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
                komutSatiri = "INSERT INTO urun (urun_adi,fiyat,adet) values (@urun_adi,@fiyat,@adet)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@adet", int.Parse(txtAdet.Text));
                komut.Parameters.AddWithValue("@urun_adi", txtUrunAdi.Text);
                komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                

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
            txtFiyat.Clear();
            txtUrunAdi.Clear();
            txtAdet.Clear();
        }

        private void GridUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtAdet.Text = GridUrun.CurrentRow.Cells["adet"].Value.ToString();
                txtUrunAdi.Text = GridUrun.CurrentRow.Cells["urun_adi"].Value.ToString();
                txtFiyat.Text = GridUrun.CurrentRow.Cells["fiyat"].Value.ToString();
                
            }
            catch (Exception)
            {
                MessageBox.Show("hata oluştu", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                komutSatiri = "DELETE FROM urun WHERE id = @id";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", int.Parse(GridUrun.CurrentRow.Cells["id"].Value.ToString()));
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
                komutSatiri = "UPDATE urun SET fiyat=@fiyat,urun_adi=@urun_adi,adet=@adet WHERE id=@id";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", int.Parse(GridUrun.CurrentRow.Cells["id"].Value.ToString()));
                komut.Parameters.AddWithValue("@adet", int.Parse(GridUrun.CurrentRow.Cells["adet"].Value.ToString()));
                komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
                komut.Parameters.AddWithValue("@urun_adi", txtUrunAdi.Text);
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
            UrunArama(txtArama.Text);
        }

        private void UrunArama(string aranacakUrun)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }
                komut = new MySqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "select * FROM urun WHERE urun_adi like '" + aranacakUrun + "%'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                GridUrun.DataSource = dataTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

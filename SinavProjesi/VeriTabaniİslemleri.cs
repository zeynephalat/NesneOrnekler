using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinavProjesi
{
    class VeriTabaniİslemleri
    {
        string baglantiCumlesi = ConfigurationManager.ConnectionStrings["urun"].ConnectionString;

        public MySqlConnection baglan()
        {
            MySqlConnection baglanti = new MySqlConnection(baglantiCumlesi);

            MySqlConnection.ClearPool(baglanti);
            return baglanti;
        }
    }
}

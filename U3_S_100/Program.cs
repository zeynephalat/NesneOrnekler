using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_S_100
{
    class OkulPersoneli
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
    class Ogretmen : OkulPersoneli
    {

        public string Brans { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

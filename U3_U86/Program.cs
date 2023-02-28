using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U3_U86
{
    class SayiBulucu
    {
        public int BuyukOlaniBul(int sayi1, int sayi2)
        {
            int sonuc;
            if (sayi1 < sayi2)
            {
                sonuc = sayi2;
            }
            else
            {
                sonuc = sayi1;
            }
            return sonuc;

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            SayiBulucu sb = new SayiBulucu();
            int a = 100;
            int b = 25;
            int sonuc = sb.BuyukOlaniBul(a, b);
            Console.WriteLine("buyuk olan sayı:{0}", sonuc);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U32_S81
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 3;
            ucgen.B = 4;
            ucgen.C = 5;
            Console.WriteLine(" üçgenin A kenarı uzunluğu:{0}", ucgen.A);
            Console.WriteLine(" üçgenin B kenarı uzunluğu:{0}", ucgen.B);
            Console.WriteLine(" üçgenin C kenarı uzunluğu:{0}", ucgen.C);

            Console.ReadLine();                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   
        }
    }
    public class Ucgen
    {
        int a;
        int b;
        int c;

        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı bilgi");
                }
                else
                {
                    a = value;
                }
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı bilgi");
                }
                else
                {
                    b = value;
                }
            }
        }



        public int C
        {
            get { return c; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("hatalı bilgi");
                }
                else
                {
                    c = value;

                }

            }
        }
    }
}




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Op06SmaaMetoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);
            Udskriv();
            Udskriv("Dette er en test");
            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);
            double res4 = BeregnMoms(100.35, 25);
            Console.WriteLine(res4);
            int[] løn= { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);

        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }

        static void Udskriv (string txt = "")
        {
            Console.WriteLine(txt);
        }

        static double BeregnMoms(double beløb, double momsPct = 25)
        {
            return beløb * momsPct / 100;
        }

        static double Gennemsnit(int[] månedsløn)
        {
            double lønSum =0;
            foreach (var item in månedsløn)
            {
                lønSum += item;
            }
            return lønSum / månedsløn.Length;
        }
    }
}

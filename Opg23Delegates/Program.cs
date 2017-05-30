using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg23Delegates
{
    public delegate int BeregnDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Beregner(2, 3, Plus));
            Console.WriteLine(Beregner(2, 3, Minus));
            Console.WriteLine(Beregner(10, 5, Divider));
            Console.WriteLine(Beregner(2, 2, Gange));
        }
        public static int Beregner(int a, int b, BeregnDelegate funktion)
        {
            return funktion(a, b);
        }
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a,int b)
        {
            return a / b;
        }
        public static int Gange(int a,int b)
        {
            return a * b;
        }
    }
}

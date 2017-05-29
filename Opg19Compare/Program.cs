using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg19Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund();
            h1.Alder = 5;
            h1.Navn = "Plet";
            Hund h2 = new Hund();
            h2.Alder = 7;
            h2.Navn = "Fido";
            Hund h3 = new Hund();
            h3.Alder = 2;
            h3.Navn = "Pluto";
            Hund[] a = new Hund[3];
            a[0] = h1;
            a[1] = h2;
            a[2] = h3;

            Hund[] a2 = new Hund[2] { new Hund() { Alder = 10, Navn = "Bulder" }, new Hund() { Alder = 5, Navn = "Frodo" } };

            foreach (var h in a2)
            {
                Console.WriteLine("{0} {1} år", h.Navn, h.Alder);
            }
            Array.Sort(a2);
            Console.WriteLine("Sorteret efter alder");
            foreach (var h in a2)
            {
                Console.WriteLine("{0} {1} år", h.Navn, h.Alder);
            }

        }
    }
}

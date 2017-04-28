using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {

        enum FilTyper
        { csv,pdf,txt}

        struct Person
        {
            public int Id;
            public string Navn;           
        }


        static void Main(string[] args)
        {
            int helTal32 = 10;
            Console.WriteLine("helTal32 = " + helTal32);
            helTal32++;
            Console.WriteLine("helTal32 = " + helTal32);
            helTal32--;
            Console.WriteLine("helTal32 = " + helTal32);
            helTal32 += 20;
            Console.WriteLine("helTal32 = " + helTal32);

            double kommaTal = 12.5;
            Console.WriteLine("kommaTal = " + kommaTal);
            kommaTal++;
            Console.WriteLine("kommaTal = " + kommaTal);
            kommaTal--;
            Console.WriteLine("kommaTal = " + kommaTal);
            kommaTal *= 20;
            Console.WriteLine("kommaTal = " + kommaTal);

            FilTyper ft = FilTyper.csv;
            Console.WriteLine("Filtype " + ft);
            Console.WriteLine("Filtype nummer " + (int) ft);
            ft = FilTyper.txt;
            Console.WriteLine("Filtype " + ft);
            Console.WriteLine("Filtype nummer " + (int)ft);

            DateTime dato = DateTime.Now;
            Console.WriteLine("Dagsdato " + dato.ToString("ddMMyy"));
            Console.WriteLine("Dagsdato " + dato.ToString("dMMy"));
            Console.WriteLine("Dagsdato " + dato.ToString("d.MMM yyyy"));
            Console.WriteLine("Dagsdato " + dato.ToLongDateString());

            Person p;
            p.Id = 1;
            p.Navn = "Anker";

            Console.WriteLine("Person Id " + p.Id + " navn " + p.Navn);


        }


    }
}


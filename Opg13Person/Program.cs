using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg13Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Anker";
            p1.Efternavn = "Møller";
            Console.WriteLine(p1.FuldtNavn());
            Elev e1 = new Elev();
            e1.Fornavn = "Hans";
            e1.Efternavn = "Hansen";
            Console.WriteLine(e1.FuldtNavn());
            Instruktør i1 = new Instruktør();
            i1.Fornavn = "Peter";
            i1.Efternavn = "Petersen";
            Console.WriteLine(i1.FuldtNavn());
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    class Instruktør : Person
    {
        public string NøgleId { get; set; }
    }

}

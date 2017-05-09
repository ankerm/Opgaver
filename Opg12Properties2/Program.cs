using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg12Properties2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Anker";
            p1.Efternavn = "Møl";
            Console.WriteLine(p1.FuldtNavn());
            
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {
                if (value.Length > 3)
                    efternavn = value;
                else
                    efternavn = "";

                 }
        }
        public string FuldtNavn ()
        {
            return Fornavn + " " + efternavn;
        }

    }
}

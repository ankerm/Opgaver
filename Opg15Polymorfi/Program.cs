using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Anker";
            p.Efternavn = "Møller";
            p.Skriv();
            Elev e = new Elev();
            e.Fornavn = "Hans";
            e.Efternavn = "Hansen";
            e.Klasselokale = "c1";
            e.Skriv();
            Instruktør i = new Instruktør();
            i.Fornavn = "Jørgen";
            i.Efternavn = "Jørgensen";
            i.NøgleID = 5;
            i.Skriv();
            Person[] lst = new Person[3];
            lst[0] = p;
            lst[1] = e;
            lst[2] = i;
            foreach (var item in lst)
            {
                item.Skriv();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg20List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> pl = new List<Person>();
            pl.Add(new Person { Navn = "Anker", Id = 3 });
            pl.Add(new Person { Navn = "Henny", Id = 2 });
            pl.Add(new Person { Navn = "Laurits", Id = 3 });

            foreach (var p in pl)
            {
                Console.WriteLine("{0}", p.Navn);
            }

            Dictionary<int, Person> dd = new Dictionary<int, Person>();
            dd.Add(31, pl[0]);
            dd.Add(32, pl[1]);
            dd.Add(33, pl[2]);

            Console.WriteLine(dd[32].Navn);
        }
    }
}

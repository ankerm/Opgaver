using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg22Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort { Kulør = "Ruder", Værdi = 3 });
            b.Vis();

            var k = b.FjernKort();
            Console.WriteLine();
            b.Vis();
            Console.WriteLine();
            Console.WriteLine(k.ToString());

        }
    }
}

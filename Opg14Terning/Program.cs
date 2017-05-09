using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t1 = new Terning(2);
            //t1.Ryst();
            //t1.Skriv();

            LudoTerning l1 = new LudoTerning();
            l1.Ryst();
            Console.WriteLine("Er globus " + l1.ErGoblus());
            Console.WriteLine("Er stjerne " + l1.ErStjerne());
            l1.Skriv();

        }
    }
}

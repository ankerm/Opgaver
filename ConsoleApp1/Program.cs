using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg01HelloWorld

{
    class Program
    {
        static void Main(string[] args)
        {
            string navn;
            string navnMedStort;

            Console.WriteLine("Indtast navn");
            navn = Console.ReadLine();
            navnMedStort = navn.ToUpper();
            Console.WriteLine("Velkommen " + navnMedStort);
            Console.WriteLine("Tryk en tast");
            Console.ReadKey();
        }
    }
}

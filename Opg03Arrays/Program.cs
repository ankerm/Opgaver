using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg03Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] loeninger = new int[6];
            loeninger[0] = 18000;
            loeninger[1] = 21000;
            loeninger[2] = 17700;
            loeninger[3] = 57000;
            loeninger[4] = 43000;
            loeninger[5] = 34000;

            Array.Sort(loeninger);

            int loenTotal = 0;
            for(int i=0; i < loeninger.Length; i++)
            {
                Console.WriteLine("Løn " + i + " = " + loeninger[i]);
                loenTotal += loeninger[i];
            }
            Console.WriteLine("Snit = " + loenTotal / loeninger.Length);

            loenTotal = loeninger.Sum();

            Console.WriteLine("Snit = " + loenTotal / loeninger.Length);

            Console.WriteLine("Snit = " + (int) loeninger.Average());

        }
    }
}

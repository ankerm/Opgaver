using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg07BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);
            Console.WriteLine(res.sum);
            Console.WriteLine(res.gennemsnit);
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }

        }

        static ArrayResultat BeregnOgSorterArray(int[] a)
        {
            ArrayResultat r;

            r.sum = a.Sum();
            r.gennemsnit = a.Average();
            Array.Sort(a);
            return r;
        }

        struct ArrayResultat
        {
            public double sum;
            public double gennemsnit;

        }
    }
}

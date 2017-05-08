using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            SkrivTal(1);
        }
        static void SkrivTal(int i)
        {
            Console.WriteLine(i);
            if (i < 10)
            {
                SkrivTal(i + 1);
            }
        }
    }
}

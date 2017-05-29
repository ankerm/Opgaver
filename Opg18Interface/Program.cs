using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg18Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] a = new IDbFunktioner[4];
            a[0] = new Ubåd();
            a[1] = new Hund();
            a[2] = new Hund();
            a[3] = new Ubåd();

            foreach (var item in a)
            {
                item.gem();
            }

            
        }
    }
}

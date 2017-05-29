using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg18Interface
{
    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }
        public void gem() {
            Console.WriteLine("Gemmer hund");
        }
    }
}

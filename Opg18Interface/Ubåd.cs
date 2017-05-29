using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg18Interface
{
    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }
        public void gem() {
            Console.WriteLine("Gemmer ubåd {0}", this.Nummer);
        }

    }
}

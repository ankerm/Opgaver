using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Polymorfi
{
    class Elev : Person { 
        public string Klasselokale { get; set; }
        public override void Skriv()
        {
            Console.WriteLine("{0} {1} klasselokale {2}", this.Fornavn, this.Efternavn, Klasselokale);

        }
    }
}

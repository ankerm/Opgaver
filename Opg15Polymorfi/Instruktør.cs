using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Polymorfi
{
    class Instruktør : Person

    {
        public int NøgleID { get; set; }
        public override void Skriv()
        {
            Console.WriteLine("{0} {1} nøgle-id {2}", this.Fornavn, this.Efternavn, NøgleID);
        }
    }
}

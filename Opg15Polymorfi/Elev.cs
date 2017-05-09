using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Polymorfi
{
    class Elev : Person
    {
        public string Klasselokale { get; set; }
        public override string Skriv()
        {
            return base.Skriv() + " klasselokale " + this.Klasselokale;
        }
    }
}

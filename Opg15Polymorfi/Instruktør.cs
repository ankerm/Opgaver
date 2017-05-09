using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Polymorfi
{
    class Instruktør : Person

    {
        public string NøgleID { get; set; }
        public override string Skriv()
        {
            return base.Skriv() + " NøgleID " + NøgleID;
        }
    }
}

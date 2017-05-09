using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg15Polymorfi
{
    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual string Skriv ()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}

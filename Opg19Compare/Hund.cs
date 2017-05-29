using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg19Compare
{
    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund a = obj as Hund;
            if (this.Alder > a.Alder)
                return 1;
            else if (this.Alder < a.Alder)
                return -1;
            else
                return 0;
        }
    }
}

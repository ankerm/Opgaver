using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg14Terning
{
    class Terning
    {
        private static Random rnd = new Random();
        private int værdi;

        public int Værdi
        {
            get {
                Console.WriteLine("Terning læses som " + this.værdi);
                return værdi; }
            set {
                Console.WriteLine("Terning sættes til " + value);
                if (value < 1 || value > 6)
                    værdi = 1;
                else
                    værdi = value;
                }
        }

        public int Ryst ()
        {
            Værdi = rnd.Next(1, 7);
            return Værdi;

        }
        public void Skriv()
        {
            Console.WriteLine("[" + Værdi + "]");
        }
        public Terning()
        {
            Værdi = 1;
        }
        public Terning(int værdi)
        {
            Værdi = værdi;
        }
    }
}

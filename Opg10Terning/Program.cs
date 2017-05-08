using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Terning t1;
            //t1 = new Terning();
            //Console.WriteLine(t1.Værdi);

            //Terning t2;
            //t2 = new Terning();
            //Console.WriteLine(t2.Værdi);

            //t2 = t1;
            //Console.WriteLine(t1.Værdi);
            //Console.WriteLine(t2.Værdi);

            //t1.Værdi = 5;
            //Console.WriteLine(t1.Værdi);
            //Console.WriteLine(t2.Værdi);

            //t1.Værdi = 3;
            //Console.WriteLine(t1.Værdi);
            //Console.WriteLine(t2.Værdi);

            Terning t3 = new Terning();
            t3.Skriv();
            t3.Ryst();
            t3.Skriv();

            Terning t4 = new Terning(true);
            t4.Skriv();
            t4.Ryst();
            t4.Skriv();

        }
    }

    class Terning
    {
        private static Random rnd = new Random();
        public int Værdi;
        private bool snyd;

        public void Skriv ()
        {
            Console.WriteLine(this.Værdi);
        }

        public void Ryst ()
        {
            if (snyd)
            {
                this.Værdi = 6;
            }
            else
            {
                this.Værdi = rnd.Next(1, 7);
            }

        }
        public Terning()
        {
            this.Værdi = 1;
            this.snyd = false;
        }
        public Terning(int a) : this()
        {
            this.Værdi = a;
        }
        public Terning(bool b) : this()
        {
            this.snyd = b;
        }
        public Terning(int a, bool b) : this(a)

        {
            this.snyd = b;
        }
   }
}

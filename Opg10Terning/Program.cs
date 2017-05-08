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
            Terning t1;
            t1 = new Terning();
            Console.WriteLine(t1.Værdi);

            Terning t2;
            t2 = new Terning();
            Console.WriteLine(t2.Værdi);

            t2 = t1;
            Console.WriteLine(t1.Værdi);
            Console.WriteLine(t2.Værdi);

            t1.Værdi = 5;
            Console.WriteLine(t1.Værdi);
            Console.WriteLine(t2.Værdi);

            t1.Værdi = 3;
            Console.WriteLine(t1.Værdi);
            Console.WriteLine(t2.Værdi);

        }
    }

    class Terning
    {
        public int Værdi;

        public Terning()
        {
            this.Værdi = new Random().Next(1, 7);
        }
        public Terning(int a)
        {
            this.Værdi = a;
        }


    }
}

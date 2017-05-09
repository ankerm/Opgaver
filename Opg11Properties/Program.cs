using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg11Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare b1 = new Vare();
            b1.Navn = "Samsung skærm";
            b1.Pris = 3000.0;
            Console.WriteLine(b1.PrisMedMoms());

        }


    }

    class Vare
    {
        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Get navn " + this.Navn);
                return navn; }
            set {
                Console.WriteLine("Set navn " + value);
                navn = value;
            }
        }
        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Get pris " + this.Pris);
                return pris; }
            set {
                Console.WriteLine("Set pris " + value);
                pris = value; }
        }
        public Vare()
        {
            this.Navn = "";
            this.Pris = 0;
        }
        public Vare(string navn) : this()
        {
            this.Navn = navn;
        }
        public Vare(double pris) : this()
        {
            this.Pris = pris;
        }
        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
        public double PrisMedMoms ()
        {
            return this.pris *= 1.25;
        }


    }
}

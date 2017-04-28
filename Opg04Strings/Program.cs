using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg04Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string forNavn = "Anker";
            string efterNavn = "Møller";
            string fuldNavn = forNavn + " " + efterNavn;
            Console.WriteLine(fuldNavn);
            string stortNavn = fuldNavn.ToUpper();
            Console.WriteLine(stortNavn);
            string lilleNavn = fuldNavn.ToLower();
            Console.WriteLine(lilleNavn);
            string partNavn = fuldNavn.Substring(6, 6);
            Console.WriteLine(partNavn);
            string[] navne = fuldNavn.Split(' ');
            string nytNavn = "";
            foreach (var item in navne)
            {
                Console.WriteLine(item);
                nytNavn = nytNavn + item.Substring(0, 1).ToUpper() + item.Substring(1).ToLower() + " ";
            }
            Console.WriteLine(nytNavn);

        }
    }
}

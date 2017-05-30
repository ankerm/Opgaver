using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Opg21Using
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader stream = System.IO.File.OpenText("dyrenavne.txt"))
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);

                }
            }
        }
    }
}

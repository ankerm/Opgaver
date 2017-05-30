using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg22Collection
{
    class Bunke
    {
        private Stack<Kort> b = new Stack<Kort>();

        public void TilføjKort(Kort k)
        {
            b.Push(k);
        }
        public Kort FjernKort()
        {
            return b.Pop();
        }

        public void Vis ()
        {
            foreach (var k in b)
            {
                Console.WriteLine(k.ToString());
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegari_cu_tipuri_de_retur
{
    delegate int DelTest();

    class Test
    {
        private int x = 0;
        public int F()
        {
            x += 2;
            return x;
        }

        public int G()
        {
            x += 6;
            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();

            DelTest d;

            d = t.F;
            d += t.G;
            d += t.F;

            Console.WriteLine(d());
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner_class
{
    class Exterior
    {
        private int x;
        public Exterior(int val)
        {
            x = val;
        }

        public class Interior
        {
            public void Scrie(Exterior s)
            {
                Console.WriteLine(s.x);
            }
        }
    }

    class Motor
    { }

    class Caroserie
    { }

    class Masina
    {
        private string marca;
        private Caroserie c;
        private Motor m;
        public Masina(Caroserie c, Motor m, string marca)
        {
            this.c = c;
            this.m = m;
            this.marca = marca;
        }
    }

    class Test_nested_class_continere
    {
        static void Main()
        {
            Exterior o1 = new Exterior(100);
            Exterior.Interior o2 = new Exterior.Interior();
            o2.Scrie(o1);

            Caroserie C = new Caroserie();
            Motor M = new Motor();
            Masina masina = new Masina(C, M, "BMW");
        }
    }
}

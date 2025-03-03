using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    class Baza
    {
        public void Metoda()
        {
            Console.WriteLine("Baza.Metoda()");
        }
    }

    class Derivat : Baza
    {
        new public void Metoda()
        {
            Console.WriteLine("Derivat.Metoda()");
        }
    }

    class Polimorfism
    {
        static void Main()
        {
            Derivat d = new Derivat();
            d.Metoda();

            Baza b = (Baza)d;
            b.Metoda();
        }
    }
}

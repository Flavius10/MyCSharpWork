using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorii_claselor_derivate_MembriiAscunsi
{
    class Baza
    {
        public Baza()
        {
            Console.WriteLine("Constructor Baza");
        }
    }

    class Derivat : Baza
    {
        public Derivat() : base()
        {
            Console.WriteLine("Constructor Derivat");
        }
    }


    class Baza1
    {
        protected int x;
        public Baza1(int y)
        {
            x = y;
        }

    }

    class Derivat1 : Baza1
    {
        public char c;

        public Derivat1(char a, int b) : base(b)
        {
            c = a;
        }

    }

    class Baza2
    {
        public int camp = 10;

        public Baza2()
        { }
        
        public void Metoda()
        {
            Console.WriteLine("Baza.Metoda()");
        }

    }

    class Derivat2 : Baza2
    {
        new public int camp = 20;

        public Derivat2()
        { }
        new public void Metoda()
        {
            base.Metoda();
            Console.WriteLine("Derivat.Metoda() " + base.camp);
        }
    }

    class Test
    {
        static void Main()
        {
            Derivat d = new Derivat();
            Derivat1 d1 = new Derivat1('T', 10);

            Console.WriteLine();

            Derivat2 d2 = new Derivat2();
            d2.Metoda();
        }
    }
}

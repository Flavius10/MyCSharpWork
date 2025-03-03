using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proprietati_Indexatori
{
    class Intreg
    {
        private int n;

        public int N
        {
            get { return n; }

            set
            {
                if (value > 1000)
                    n = 1000;
             else
                if (value < 0)
                    n = 0;
                else n = value;
            }
        }
    }

    //Proprietati statice
    class Numar
    {
        private static int nr;
        public static int Nr
        {
            get { return nr; }
            set { nr = value; }
        }
    }

    //Proprietati implementate in mod automat
    class X
    {
        public int Valoare
        {
            get; set;
        }
    }

    //indexatori
    class Tablou
    {
        private int[] a;
        private int n;
        private const int MAX = 1000;

        public Tablou(int dim)
        {
            n = dim;
            a = new int[n];
        }

        public int this[int index]
        {
            get
            {
                if (index < 0)
                    return a[0];
                else
                if (index > MAX)
                    return a[MAX];
                else
                    return a[index];
            }
            set
            {
                if (index < 0)
                    a[0] = value;
                else
                if (index > MAX)
                    a[MAX] = value;
                else
                    a[index] = value;
            }
        }
    }

    //OPERATORI DE CONVERSIE
    class Bancnota
    {
        private int valoare;

        public Bancnota(int v)
        {
            valoare = v; 
        }

        public static explicit operator Bancnota(int v)
        {
            return new Bancnota(v);
        }

        public static explicit operator int(Bancnota b)
        {
            return b.valoare;
        }
    }

    class Bancnota1
    {
        private int valoare1;

        public Bancnota1(int v)
        {
            valoare1 = v;
        }

        public static implicit operator Bancnota1(int v)
        {
            return new Bancnota1(v);
        }

        public static implicit operator int(Bancnota1 b)
        {
            return b.valoare1;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            
               Intreg intr = new Intreg();
               intr.N = 1200;
               Console.WriteLine(intr.N);
               intr.N = -10;
               Console.WriteLine(intr.N);

            Console.WriteLine();

            Numar.Nr = 100;
            Console.WriteLine(Numar.Nr);

            Console.WriteLine();

            X x = new X();
            x.Valoare = 10;
            Console.WriteLine(x.Valoare);
            

            Tablou t = new Tablou(100);
            for (int i = 0; i < 10; ++i)
                t[i] = i;
            t[-1] = 10;
            

            for (int i = 0; i < 10; ++i)
                Console.Write(t[i] + " ");

            Console.WriteLine();

            int val = 100;
            Bancnota b = (Bancnota)val;
            Console.WriteLine((int)b);

            Console.WriteLine();

            int val1 = 100;
            Bancnota1 b1 = val;
            Console.WriteLine(b1);
        }
    }
}

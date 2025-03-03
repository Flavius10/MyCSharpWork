using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegari
{
    class Simplu
    {
        public void F(string s)
        {
            Console.WriteLine(s + "F()");
        }

        public static void G(string s)
        {
            Console.WriteLine(s + "G()");
        }
    }

    delegate void Del(string d);

    class Program
    {
        static void Main(string[] args)
        {
            Del d;

            Simplu s = new Simplu();

            d = s.F;
            d += Simplu.G;
            d += Simplu.G;

            d("Prima invocare: ");

            d -= s.F;
            d("A doua invocare: ");

        }
    }
}



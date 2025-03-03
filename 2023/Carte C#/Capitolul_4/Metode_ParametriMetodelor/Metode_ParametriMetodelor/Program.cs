using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Metode_ParametriMetodelor
{
        class Parametrii_valoare
        {
            public void Pv(int x, int y)
            {
                int aux;
                aux = x; x = y; y = aux;
            }
        }

        class Parametrii_referinta
        {
            public void Pr(ref int x, ref int y)
            {
                int aux;
                aux = x; x = y; y = aux;
            }
        }

        class Parametrii_iesire
        {
            public void Pi(out int x)
            {
                 x = 100;
                 x++;
            }
        }

        class Parametrii_tablou
        {
            public void Pt(params int[] x)
            {
                foreach (int i in x)
                    Console.Write(i + " ");
                Console.WriteLine();
            }
        }

        class Overloading
        {
            void F(int a) 
            {
            
            }
            
            void F(double b)
            {
                  
            }

            void F(char c, int a)
            {

            }

         }

        class MembriiStatici
        {
            public static int x;
            public static void Flavius()
            {
                
            }
        }


    class Test
    {

        static int x;
        static void F()
        {

        }

        int y = 100;
        void G()
        {

        }
        static void Main(string[] args)
        {
            Parametrii_valoare valoare = new Parametrii_valoare();
            int a = 10, b = 20;
            valoare.Pv(a, b);
            Console.WriteLine("a = {0} b = {1}", a, b);

            Parametrii_referinta referinta = new Parametrii_referinta();
            int c = 10, d = 20;
            referinta.Pr(ref c, ref d);
            Console.WriteLine("c = {0} d = {1}", c, d);

            Parametrii_iesire iesire = new Parametrii_iesire();
            int z;
            iesire.Pi(out z);
            Console.WriteLine(z);

            Parametrii_tablou pt = new Parametrii_tablou();
            pt.Pt(1, 2);
            pt.Pt(3, 4, 5, 6);
            int[] a1 = { 10, 20, 30 };

            pt.Pt(a1);


            //!!!MEMBRII STATICI A UNEI CLASE

            x = 10;
            F();

            Test.x = 20;
            Test.F();

            Test t = new Test();
            t.y = 30;
            t.G();

            MembriiStatici.x = 10;
            MembriiStatici.Flavius();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constante_Constructori_Desctructori
{
    class Constanta
    {
        //Metode statice
        static int Metoda(int a)
        {
            const int x = 100;
            a = x;

            return a;
        }
        //Metode ne-statice
        int Metoda1(int a)
        {
            const int x = 200;
            a = x;

            return a;
        }

        //Constantele membre
        class C
        {
            public const int F = 5500;
        }

        static void Main(string[]args)
        {
            //Metoda ne-statica
            Constanta metoda = new Constanta();
            Console.WriteLine(metoda.Metoda1(500));

            //Meotda statica
            int b = 200;
            int c = Constanta.Metoda(b);
            Console.WriteLine(c);

            //Constante Membre
            Console.WriteLine(C.F);
        }
    }
}

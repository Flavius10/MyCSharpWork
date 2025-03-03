using System;
using System.Data.SqlTypes;

namespace Tipuri_de_referinta
{
    class C
    {

    }

    struct S
    {

    }

    enum Saptamana
    {
        Luni = 1, Marti = 2, Miercuri = 3, Joi = 4,
        Vineri = 5, Samabata = 6, Duminica = 7
    }

    enum Note
    {
        Info = 10,
        Mate = 9,
        Romana = 10
    }

    class StackHeap
    {
       static void Main(string[] args)
        {
            S s = new S();
            int x = 10;

            C r;
            r = new C();


            short a = 40;
            int n = a;

            int a2 = 2000;
            char c = 'T';

            a2 = c;
            Console.WriteLine(a2);

            //CCONVERSIE DIN LONG IN INT(se poate)

            long b = 10000;
            int a1 = 10;
            b = a1;

            Console.WriteLine(b);

           // GRESIT(nu se face conversie, pierdere de memorie)
           // int m = 100001;
           //short s1 = n;

           //CORECT
           //short s2 = (short) n;

            Console.WriteLine(n);

            Console.WriteLine(r);
            Console.WriteLine(s);

            Saptamana zile = Saptamana.Luni;

            if (zile == Saptamana.Luni)
                Console.Write("Luni e {0}\nMarti e {1}",
                    (int)Saptamana.Luni,  (int)Saptamana.Marti);

            Console.WriteLine();

            Console.Write("mate: {0}\ninfo: {1}\nromana:{2}",
                (int)Note.Mate, (int)Note.Info, (int)Note.Romana);

        }

    }
}
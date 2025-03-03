using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using X.Y;

namespace X
{
    namespace Y
    {
        public class A 
        {

        }
    }

    class Tab_bidim_4l_3c
    {
        static void Main(string[] args)
        {
            
            // exercitiul 4 pag 53
            int[,] a = new int[4, 3] { { 1, 2, 3 }, {4, 5, 6}, {7, 8, 9}, {10, 11, 12} };

            for (int i = 0; i < 4; ++i, Console.WriteLine())
                for (int j = 0; j < 3; ++j)
                    Console.Write(a[i, j] + " ");

            Console.WriteLine();

            //exercitiul 5 pag 53
            var tab_ner = new[]
            {
                new[] {1, 2, 3, 4},
                new[] {5, 6, 7},
                new[] {8, 9}
            };

            for (int i = 0; i < tab_ner.Length; ++i, Console.WriteLine())
                for (int j = 0; j < tab_ner[i].Length; ++j)
                {
                    Console.Write(tab_ner[i][j] + " ");
                }

            //exercitiul 6 pag 53

            //calificarea completa a numelui
            X.Y.A ob = new X.Y.A();

            Console.WriteLine(ob.ToString());

            //utilizarea directivei using X.Y;
            A ob1 = new A();

            Console.WriteLine(ob1.ToString());
        }
    }
}

/*
1 2 3 
4 5 6 
7 8 9
3 2 1


 */
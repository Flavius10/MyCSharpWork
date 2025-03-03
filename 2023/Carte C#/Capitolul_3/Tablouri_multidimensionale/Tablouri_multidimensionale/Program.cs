using System;
using System.Linq.Expressions;

namespace Tablouri_multidimensionale
{
    class Tab_mult
    {
    }

    class Tab_neregulate
    {
        static void Main(string[] args)
        {
            //Tablouri multidimensionale
            int[,] x = new int[,] { { 1, 2, 3 }, { 2, 3, 0 } };

            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < 3; ++j)
                    Console.Write(x[i, j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine();

            //Prima varianta de initializare
            int[][] a = new int[3][];

            a[0] = new int[] { 2, 7, 3, 8 };
            a[1] = new int[] { -1, 0, 1 };
            a[2] = new int[] { 1, 2, 3, 4, 5 };
            
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < a[i].Length; ++j)
                    Console.Write(a[i][j] + " ");
                Console.WriteLine();
            }

            Console.WriteLine();

            //A doua varianta de initializare
            string[][] s = new string[][]
            {
                new string[] {"Fla", "vius" },
                new string[] {"Lu", "ca"},
                new string[] {"Ma", "ma"},
                new string[] {"Ta", "ta"}
            };

            for (int i = 0; i < s.Length; ++i, Console.WriteLine())
            {
                for (int j = 0; j < s[j].Length; ++j)
                    Console.Write(s[i][j]);
            }

            Console.WriteLine();

            // A treia varianta de initializare
            ulong[][] b =
            {
                new ulong[] {1, 2 , 3},
                new ulong[] {4, 5, 6},
                new ulong[] {7, 8, 9},
                new ulong[] {8, 9, 10}
            };

            for (int i = 0; i < b.Length; ++i, Console.WriteLine())
            {
                for (int j = 0; j < b[j].Length; ++j)
                    Console.Write(b[i][j] + " ");
            }

            Console.WriteLine();

            //A patra metoda de initializare

            var d = 3.5;
            var s1 = "Flavius";

            var a1 = new[] {1, 2, 3};

            var q = new[]
            {
                new[] {7, 4},
                new[] {2, 0, -4, 8}
            };

            for (int i = 0; i < q.Length; ++i, Console.WriteLine())
            {
                for (int j = 0; j < q[i].Length; ++j)
                    Console.Write(q[i][j] + " ");
            }

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Tab_nereg
    {
        static void Main(string[] args)
        {
            
                int[][,] a = new int[3][,]
                {
                    new int[,] { {2, 9 }, { 4, 7 }, {5, 0} },
                    new int[,] { { 1, 5 }, { 3, 12 } },
                    new int[,] { {8, 6},{2, 9 },{0, 6 }, {3, -1 } }
                };
                int k = 0;

                for (int i = 0; i < a.Length; ++i)
                {
                    for (int j = 0; j < a[j].Length; ++j)
                        Console.WriteLine(a[i][j, k] + " ");
                }
            
            int j = 0;
            switch (j)
            {
                case 0:
                    Console.WriteLine("cazul 0");

                goto case 1;

                case 1:

                case 2:
                    Console.WriteLine("cazul 1 si 2");
                    break;
            }

            string s = Console.ReadLine();

            int x = int.Parse(s);

            Console.WriteLine(x);



        }
    }
}
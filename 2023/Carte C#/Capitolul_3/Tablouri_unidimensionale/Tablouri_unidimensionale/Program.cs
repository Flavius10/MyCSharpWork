using System;

namespace Tablouri_unidimensionale
{

    class A
    {
    }

    class Tab_uni
    {
        static void Main(string[] args)
        {
            int[] a;
            a = new int[5];

            for (int i = 0; i < a.Length; ++i)
                a[i] = i + 1;

            for (int i = 0; i < a.Length; ++i)
                Console.Write("a[{0}] = {1}\n", i, a[i]);


            double[] b = new double[1000];
            char[] c = new char[1000];
            string[] s = new string[1000];

            A[] z = new A[7];

            for (int i = 0; i < z.Length; ++i)
                if (z[i] == null)
                    Console.Write("NULL" + " ");

            Decimal[] d = new Decimal[10];

            for (int i = 0; i < d.Length; ++i)
                Console.Write(d[i] + " ");

        }
    }
}
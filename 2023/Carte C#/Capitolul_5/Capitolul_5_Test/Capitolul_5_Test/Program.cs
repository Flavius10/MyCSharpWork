using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Capitolul_5_Test
{
    class Test_Cap5
    {
        static void Main(string[] args)
        {
            string fin = @"C:\Folders\Info\C#\Capitolul_5\Capitolul_5_Test\Capitolul_5_Test\matrice.in";
            string fout = @"C:\Folders\Info\C#\Capitolul_5\Capitolul_5_Test\Capitolul_5_Test\matrice.out";

            StreamReader sr = new StreamReader(fin);
            StreamWriter sw = new StreamWriter(fout);

            string[,] s = null;
            string linie = null;

            int x = 0;

            while((linie = sr.ReadLine()) != null)
            {
                for (int i = 0; i < s.Length; i++)
                    for (int j = 0; j < s.Length;++j)
                    s[i, j] = linie.Split(' ');

                foreach(string nr in s)
                {
                    x = int.Parse(nr);
                    sw.Write("{0, -5}", x * x);
                }

                sw.WriteLine();
            }

            sr.Close();
            sw.Close();
        }
    }
}

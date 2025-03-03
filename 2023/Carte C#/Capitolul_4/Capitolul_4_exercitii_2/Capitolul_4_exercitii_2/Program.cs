using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitolul_4_exercitii_2
{
    class BigNumber
    {
        private int nr_1;
        private int nr_2;

        public BigNumber(int nr_1, int nr_2)
        {
            this.nr_1 = nr_1;
            this.nr_2 = nr_2;
        }

        public static BigNumber operator + (BigNumber n1, BigNumber n2)
        {
            int T = n1.nr_1 + n2.nr_2;
            int T_1 = n1.nr_1 * n2.nr_2;
            return new BigNumber(T, T_1);
        }

        public static BigNumber operator - (BigNumber nr1, BigNumber nr2)
        {
                int A = nr1.nr_1 - nr2.nr_2;
                int B = nr2.nr_2 - nr1.nr_1;

            if (A < B)
                return new BigNumber(B, A);
            else
                return new BigNumber(A, B);
        }

        public static BigNumber operator *(BigNumber a, BigNumber b)
        {
            int A = a.nr_1 * b.nr_2;
            if (A <= 0)
                return new BigNumber(0, A);
            else
                return new BigNumber(A * b.nr_1, A);
        }

        public override string ToString()
        {
            String s = nr_1.ToString() + " " + nr_2.ToString();
            return s;
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            BigNumber bgn = new BigNumber(10, 20);
            
            Console.WriteLine("bgn = {0}", bgn.ToString());

            BigNumber a = new BigNumber(80, 31);
            Console.WriteLine(bgn + a);
        }
    }
}

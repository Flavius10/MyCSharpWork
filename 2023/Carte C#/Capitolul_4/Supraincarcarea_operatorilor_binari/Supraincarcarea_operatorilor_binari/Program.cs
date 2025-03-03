using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supraincarcarea_operatorilor_binari
{
    public class Fractie
    {
        private int numarator;
        private int numitor;

        private static int Cmmdc(int a, int b)
        {
            if (b == 0) return a;
            return Cmmdc(b, a % b);
        }

        public Fractie(int numarator, int numitor)
        {
            int div = Cmmdc(numarator, numitor);
            numarator /= div;
            numitor /= div;
            this.numarator = numarator;
            this.numitor = numitor;
        }

        public static Fractie operator +(Fractie f1, Fractie f2)
        {
            int A = f1.numarator * f2.numitor +
                f1.numitor * f2.numarator;

            int B = f1.numitor * f2.numitor;
            int cmmdc = Cmmdc(A, B);
            A /= cmmdc;
            B /= cmmdc;
            return new Fractie(A, B);
        }

        public static bool operator ==(Fractie f1, Fractie f2)
        {
            if (f1.numitor == f2.numitor &&
                f1.numarator == f2.numarator)
                return true;
            return false;
        }

        public static bool operator != (Fractie f1, Fractie f2)
        {
            return !(f1 == f2);
        }

        public override string ToString()
        {
            String s = numarator.ToString() + "/" +
                numitor.ToString();

            return s;
        }
    }


    class TestFractie
    {
        static void Main()
        {
            Fractie a = new Fractie(3, 4);
            Console.WriteLine("a = {0}", a.ToString());

            Fractie b = new Fractie(2, 4);
            Console.WriteLine("b = {0}", b.ToString());

            Fractie c = a + b;
            Console.WriteLine("c = a + b = {0}",
                                c.ToString());

            Fractie d = new Fractie(2, 4);
            
            if (d == b)
                Console.WriteLine("d = b = {0}", d);

            if (a != b)
                Console.WriteLine(a + " != " + b);

            a += b;

            Console.WriteLine("a = " + a);
        }
    }
}

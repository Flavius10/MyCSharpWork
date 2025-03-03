using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori_unari_structuri
{
    public class Intreg
    {
        private int n;

        public Intreg(int i)
        {
            n = i;
        }

        public static Intreg operator ++(Intreg x)
        {
            return new Intreg(++x.n);
        }

        public static Intreg operator -(Intreg x)
        {
            return new Intreg(-x.n);
        }

        public override string ToString()
        {
            String s = string.Format("{0}", n);
            return s;
        }


    }

    struct Punct
    {
        private double x;
        private double y;

        public Punct(double _x, double _y)
        {
            x = _x;
            y = _y;
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }

    class Test_OU_Str
    {
        static void Main()
        {
            Intreg x = new Intreg(10);
            x++;
            Console.WriteLine(x + " " + -x);


            Punct pct = new Punct(2.4, 3.5);

            Console.WriteLine("x = {0}, y = {1}", pct.X, pct.Y);
        }
    }
}

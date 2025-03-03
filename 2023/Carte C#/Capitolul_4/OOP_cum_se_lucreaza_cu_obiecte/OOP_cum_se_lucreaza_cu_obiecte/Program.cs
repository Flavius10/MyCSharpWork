using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_cum_se_lucreaza_cu_obiecte
{
    //Exemplul 1 
    class X
    {

    public
        int obiect;
    }
    class Test
    {
        private int x;

        public int GetX()
        {
            return x;
        }

        public void SetX(int n)
        {
            x = n;
        }
    }

        class Program
        {
            int x = 100;
            static void Main(string[] args)
            {
                //Exemplul 1
                X r = new X();
                r.obiect = 10;
                Console.WriteLine(r.obiect);

                //Exemplul 2
                Program f;
                f = new Program();
                f.x = 20;

                Console.WriteLine(f.x);

                //Exemplul 3
                Test a;
                a = new Test();
                a.SetX(5000);
            Console.WriteLine(a.GetX());
                

            }
        }
}

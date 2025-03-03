using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evenimente
{
    public delegate void Timp();

    public class Publisher
    {
        public event Timp eveniment;
        public void Declanseaza()
        {

            while (true)
            {
                System.Threading.Thread.Sleep(1500);

                if (eveniment != null)
                    eveniment();
            }
        }
    }

    class A
    {   
        public void HandlerA()
        {
            Console.WriteLine("Obiect A, notificat la {0}", DateTime.Now);
        }
    }

    class B
    {
        public void HandlerB()
        {
            Console.WriteLine("Obiect B, notificat la {0}", DateTime.Now);
        }
    }


    class Test
    {
        static void Main()
        {
            Publisher p = new Publisher();

            A a = new A();
            B b = new B();

            p.eveniment += a.HandlerA;
            p.eveniment += b.HandlerB;

            p.Declanseaza();
        }
    }

}

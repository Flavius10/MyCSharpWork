using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Evenimente_Model_.Net
{
    public class MyEventArgs : EventArgs
    {
        private DateTime date;

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
    }

    public delegate void Timp(object sender, MyEventArgs a);

    public class Publisher
    {
        public event Timp eveniment;

        public void Declanseaza()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(3000);

                if (eveniment != null)
                {
                    MyEventArgs mea = new MyEventArgs();
                    mea.Date = DateTime.Now;
                    eveniment(this, mea);
                }
            }
        }
    }

    class A
    {
        public void HandlerA(object sender, MyEventArgs ev)
        {
            Console.WriteLine("Obiect A , notificat la {0}", ev.Date);
        }
    }

    class B
    {
        public void HandlerB(object sender, MyEventArgs a)
        {
            Console.WriteLine("Obiectul B notificat la {0}", a.Date);
        }
    }

    class main
    {
        static void Main()
        {
            Publisher m = new Publisher();

            A a = new A();
            B b = new B();

            m.eveniment += a.HandlerA;
            m.eveniment += b.HandlerB;

            m.Declanseaza();
        }
    }
}

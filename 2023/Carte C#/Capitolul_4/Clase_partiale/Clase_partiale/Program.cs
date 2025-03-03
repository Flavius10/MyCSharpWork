using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_partiale
{
    partial class A
    {
        public void F()
        {
            Console.WriteLine("F()");
        }
    }

    partial class A
    {
        public void G()
        {
            Console.WriteLine("G()");
        }
    }

    class TestPartialClass
    {
        static void Main()
        {
            A a = new A();
            a.F();
            a.G();
        }
    }
}

//CLASE SIGILATE: sealed opreste alte clase sa mosteneasca clasa careia ii este atribuita sealed

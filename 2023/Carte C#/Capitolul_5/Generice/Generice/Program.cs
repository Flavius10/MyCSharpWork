using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generice
{
    public class Stiva<T>
    {
        private T[] a;
        private int n;

        public Stiva(int n)
        {
            a = new T[n];
        }

        public void Push(T b)
        {
            a[n++] = b;
        }

        public T Pop()
        {
            return a[--n];
        }
    }

    public class A<T1, T2>
    {
        private T1 a;
        private T2 b;
        public A(T1 a, T2 b)
        {
            this.a = a;
            this.b = b;
        }

        public void Print()
        {
            Console.WriteLine(a + " " + b);
        }
    }

    public class U<T>
    {
        private T u;

        public U(T u)
        {
            this.u = u;
        }

        public void F<T1, T2>(T1 a, T2 b)
        {
            Console.WriteLine(a.ToString() + " " + u.ToString() + " " + b.ToString());
        }

    }

    class TesteazaGenerice
    {
        static void Main(string[] args)
        {
            //PRIMUL EXEMPLU CU UN SINGUR PARAMETRU GENERIC

            Stiva<int> s = new Stiva<int>(100);

            s.Push(2);
            s.Push(4);
            s.Push(6);

            Console.WriteLine(s.Pop() + " " + s.Pop() + " " + s.Pop());

            Stiva<string> s2 = new Stiva<string>(100);

            s2.Push("Marcel");
            s2.Push("Ionel");
            s2.Push("Alin");

            Console.WriteLine(s2.Pop() + " " + s2.Pop() + " " + s2.Pop());

            Console.WriteLine();

            //AL DOILEA EXEMPLU CU DOI PARAMETRII GENERICI

            A<string, int> a = new A<string, int>("Alin", 18);
            a.Print();

            A<string, string> b = new A<string, string>("UNU", "DOI");
            b.Print();

            A<double, char> c = new A<double, char>(2.34, 'F');
            c.Print();

            Console.WriteLine();
            //AL TREILEA EXEMPLU(METODE GENERICE)

            U<int> u1 = new U<int>(104);
            u1.F<string, string>("Sa traiti", "ani!");

            U<char> u2 = new U<char>('F');
            u2.F<string, int>("Iulia", 8);
        }
    }
}

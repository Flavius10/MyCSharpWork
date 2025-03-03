using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructori_Destructori
{
    class Masina
    {
        public string marca;
        public int pret;

        public Masina()
        {
            marca = "Fiat";
            pret = 10000;
        }

        public Masina(string m)
        {
            marca = m;
            pret = 20000;
        }

        public Masina(int p)
        {
            marca = "BMW";
            pret = p;
        }

        public Masina(string m , int p)
        {
            marca = m;
            pret = p;
        }

        ~Masina()
        {
            
        }
   
    }

    class C
    {
        private int x;

        public C(int a)
        {
            x = a;
        }

        public C(C ob)
        {
            x = ob.x;
        }

        public int GetX()
        {
            return x;
        }

        ~C()
        {

        }
    }

    class Copil
    {
        private string nume;
        private int ani;
        
        public Copil(string nume, int ani)
        {
            this.nume = nume;
            this.ani = ani;
        }

        public Copil Modificare(int ani)
        {
            this.ani = ani;
            return this;
        }

        public void Afiseaza()
        {
            Console.WriteLine(nume + " " + ani);
        }

        ~Copil()
        {

        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            //Constructori(implicit constructor, constructori de instanta)
            // Masina mas = new Masina(); GRESIT!!!(daca nu ti-ai facut constructor fara parametrii)
            Masina m4 = new Masina("Audi", 50000);
            Console.WriteLine(m4.marca + " " + m4.pret);
            Masina m1 = new Masina();
            Console.WriteLine(m1.marca + " " + m1.pret);
            Masina m2 = new Masina("Opel");
            Console.WriteLine(m2.marca + " " + m2.pret);
            Masina m3 = new Masina(30000);
            Console.WriteLine(m3.marca + " " + m3.pret);

            Console.WriteLine();

            //Copy constructor(Constructor de copiere)
            C c1 = new C(10);
            C c2 = new C(c1);
            Console.WriteLine(c2.GetX());

            Console.WriteLine();

            //Cuvantul cheie THIS
            Copil copil = new Copil("Alin", 17);
            copil.Afiseaza();
            copil.Modificare(18);
            copil.Afiseaza();

        }
    }
}

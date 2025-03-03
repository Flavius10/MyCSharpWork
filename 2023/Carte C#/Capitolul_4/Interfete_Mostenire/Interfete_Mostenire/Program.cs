using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfete_Mostenire
{
    
    /// INTERFETE
    interface IPrintable
    {
        void Print(string s);
    }

    public class Mail: IPrintable
    {
        private string a;

        public Mail(string a)
        {
            this.a = a;
        }

        public Mail()
        {

        }

        public void Print(string s)
        {
            Console.WriteLine(a + s);
        }
    }

    /// Mostenire
    public class Animal
    {
        private string hrana;
        protected int speranta_viata;

        public string Hrana
        {
            set
            {
                hrana = value;
            }
            get
            {
                return hrana;
            }
        }

        protected void SeHraneste()
        {
            Console.WriteLine("Animalul se hraneste");
        }

    }

    class Pisica: Animal
    {
        private string rasa;

        public string Rasa
        {
            set
            {
                rasa = value;
            }
            get
            {
                return rasa;
            }
        }
        public void Toarce()
        {
            //hrana = "lapte";
            speranta_viata = 13;
            Hrana = "lapte";
            SeHraneste();
            Console.WriteLine("Pisica toarce");
        }
    }


    public class Test_Interfate_AccesMembrii
    {
        static void Main()
        {
           Mail m = new Mail("Prietenilor mei ");
         //   Mail m = new Mail();
            m.Print("Salut!");

           // Animal a = new Animal();
            // a.hrana = "lapte";
            //a.speranta_viata = 12;
          //  a.Hrana = "lapte";

            Pisica p = new Pisica();
            p.Hrana = "lapte";
            p.Rasa = "Birmaneza";
            p.Toarce();

        }
    }
}

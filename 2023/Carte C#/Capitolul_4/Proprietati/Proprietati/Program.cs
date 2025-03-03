using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proprietati
{
    class Copil
    {
        private string nume;
        private int varsta;

        public Copil(string nume, int varsta)
        {
            this.nume = nume;
            this.varsta = varsta;
        }

        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
            }
        }

        public int Varsta
        {
            get
            {
                return varsta;
            }
            set
            {
                varsta = value;
            }
        }
    }

    class TestProprietati
    {
        static void Main(string[] args)
        {
            Copil c = new Copil("Valentin", 18);
            Console.WriteLine(c.Nume +  " " + c.Varsta);
            c.Nume = "Andrei";
            c.Varsta = 20;

            Console.WriteLine(c.Nume + " " + c.Varsta);

        }
    }
}

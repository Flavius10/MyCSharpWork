using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Capitolul_4_exercitii
{

    class Persoana
    {
        private int ani;
        private string nume;

        public  Persoana()
        {

        }

        public Persoana(int ani)
        {
            this.ani = ani;
        }

        public Persoana(string nume)
        {
            this.nume = nume;
        }

        public Persoana(int ani, string nume)
        {
            this.ani = ani;
            this.nume = nume;
        }

        public int Ani
        {
            get
            {
                return ani;
            }
            set
            {
                ani = value;
            }
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

        ~Persoana() {}
    }

    class Elev : Persoana
    {
        private int ani;
        private string nume;

        public Elev(int ani, string nume)
        {
            this.ani = ani;
            this.nume = nume;
        }
        public Elev(int ani)
        {
            this.ani = ani;
        }
        public Elev()
        {}

        public Elev( string nume)
        { 
            this.nume = nume;
        }

        public int Ani
        {
            get
            {
                return ani;
            }
            set
            {
                ani = value;
            }
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

        ~Elev() { }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Persoana elev = new Elev();

            elev.Ani = 17;
            elev.Nume = "Alin";

            Console.WriteLine(elev.Ani + " " + elev.Nume);
        }
    }
}

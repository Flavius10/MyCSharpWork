using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Capitolul3_Tipuri
{
    class Tipuri
        {

        struct Om
        {
            public string Name;
            public string Description;
            public ulong Ani;
        }

        class Mancare
        {
            public string Nume;
            public uint Pret;
            public string raport_pret_calitate;
        }
        
        static void Main(string[] args)
            {
            System.Int32 a = 10;
            System.Int32 b = 2022;
            ulong x = 2L;

            Console.Write("Data: " + x + "/" + a + "/" + b);
            Console.WriteLine();



            Om o = new Om();
            o.Name = "Flavius";
            o.Description = "trist";
            o.Ani = 17;

            Console.Write("Numele: {0}\nDescriere: {1}\nAni: {2}",
                            o.Name, o.Description, o.Ani);
            Console.WriteLine();


            Mancare man = new Mancare();
            man.Pret = 100;
            man.Nume = "Sushi";
            man.raport_pret_calitate = "1/2";

            Console.Write("Numele: {0}\nPret: {1}\nraport_pret_calitate: {2}",
                            man.Nume, man.Pret, man.raport_pret_calitate);
            Console.WriteLine();



            for (int i = 0; i < args.Length; i++)
                Console.Write(args[i] + " ");

            Console.WriteLine();   
                
            }


        }

}

using System;

namespace ProgramCapitol2
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "Flavius";
            string l = "Luca";
            string t = "Tata";
            string m = "Mama";

            Console.WriteLine(f + " ");
            Console.WriteLine(l + " ");
            Console.WriteLine(t + " ");
            Console.WriteLine(m + " ");


            for (int i = 0; i < args.Length; i++)
                Console.Write(args[i] + " ");
        }
    }
}
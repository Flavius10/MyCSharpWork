using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasa_generica_Stack
{
    class Stack
    {
        static void Main(string[] args)
        {
            Stack<string> st = new Stack<string>();

            st.Push("UNU");
            st.Push("DOI");
            st.Push("TREI");
            st.Push("PATRU");

            Console.WriteLine("Nr. de elemente: {0}", st.Count);

            foreach(string s in st)
                Console.WriteLine(s);

            Console.WriteLine("Scoate {0}", st.Pop());

            Console.WriteLine("Varful stivei: {0}", st.Peek());

            st.Clear();
        }
    }
}

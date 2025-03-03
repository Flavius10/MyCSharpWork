using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N = N1.N2.N3;
using F = System.Windows.Forms;

namespace N1
{
    namespace N2
    {
        namespace N3
        {
            public class C { }
        }
    }
}

public class Alias
{
    static void Main()
    {

#if DEPANARE
        N.C ob = new N.C();

#elif MAXIM
        Console.WriteLine(ob.ToString());
#endif
        F.ComboBox comb = new F.ComboBox();

    }
}



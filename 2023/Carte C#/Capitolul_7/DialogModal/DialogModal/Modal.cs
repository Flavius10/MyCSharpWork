using System;
using System.Windows.Forms;

class Forma: Form
{

}


class Program
{
    public static void Main()
    {
        Forma f = new Forma();

        f.Text = "Dialog Modal";

        f.ShowDialog();

        Application.Run();
    }
}
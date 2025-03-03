using System;
using System.Windows.Forms;

class Forma : Form
{

}

class Program
{
    public static void Main()
    {
        Forma f = new Forma();

        f.Text = "DialogNemodal";

        f.Show();

        Application.Run();
    }
}
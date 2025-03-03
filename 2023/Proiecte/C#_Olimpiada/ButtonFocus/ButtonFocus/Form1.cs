using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonFocus
{
    public partial class Form1 : Form
    {
        int[] array = new int[]{ 1, 3,4,7,9,10,2,6,5, 8};
        List<int> list = new List<int>();

        public Form1()
        {   
            InitializeComponent();
            
            
            list.Add(10);
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(8);
            list.Add(7);
            list.Add(9);

            Array.Sort(array);

            list.Sort();

            foreach(int i in list)
            {
                richTextBox1.Text += i.ToString() + ' ';
                
            }

            for(int i = 0; i < array.Length; i++)
            {
                richTextBox2.Text += array[i].ToString() + ' ';
            }
            
        }
    }
}

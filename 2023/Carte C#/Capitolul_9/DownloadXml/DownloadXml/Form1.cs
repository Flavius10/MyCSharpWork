using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace DownloadXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xml = new
                WebClient().DownloadString("http://news.google.com/" + "?output=rss");

            XmlDocument doc = new XmlDocument();

            doc.LoadXml(xml);

            doc.Save("continut.xml");
        }
    }
}

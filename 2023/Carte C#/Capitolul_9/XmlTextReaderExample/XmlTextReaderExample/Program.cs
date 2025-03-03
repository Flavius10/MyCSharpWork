using System.Xml;
using System;

class Program
{
    static void Main(string[] args)
    {
        XmlTextReader reader = new XmlTextReader("carti.xml");

        while(reader.Read())
        {
            switch(reader.NodeType)
            {
                case XmlNodeType.Element:
                    Console.Write("<" + reader.Name);
                    Console.Write(">");
                    break;

                case XmlNodeType.Text:
                    Console.Write(" " + reader.Value);
                    break;

                    case XmlNodeType.EndElement:
                    Console.Write("</" + reader.Name);
                    Console.Write(">");
                    break;
            }
        }
    }
}
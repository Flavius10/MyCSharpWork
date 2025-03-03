using System;
using System.IO;
using System.Xml;

public class Program
{
    
    private string filename = "continut.xml";
    public static void Main()
    {
       
        XmlTextWriter writer = new XmlTextWriter(filename, null);

        writer.Formatting = Formatting.Indented;

        writer.WriteComment("Creeare fisier XML");

        writer.WriteStartElement("librarie");

        writer.WriteStartElement("carte");

        writer.WriteAttributeString("ISBN", "186-383-523");

        writer.WriteStartElement("Titlu");
        writer.WriteString("Amintiri din copilarie");
        writer.WriteEndElement();

        writer.WriteElementString("Pret", "13.20");
        writer.WriteString("Autor");
        writer.WriteString("Ion Creanga");

        writer.WriteEndElement();

        writer.WriteEndElement();


        writer.Flush();
        writer.Close();

        XmlDocument xmlDoc = new XmlDocument();

        xmlDoc.PreserveWhitespace = true;
        xmlDoc.Load(filename);

        Console.Write(xmlDoc.InnerXml);

        Console.ReadLine();


    }
}
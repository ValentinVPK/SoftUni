using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var xml = File.ReadAllText("../../../Data.xml");
            Console.WriteLine(xml);

            XDocument document = XDocument.Parse(xml);
            //XDocument docFromFile = XDocument.Load("../../../Data.xml");

            //Console.WriteLine(document.Root.ToString());

            Console.WriteLine(document.Root.Element("title").Value.ToString());
        }
    }
}

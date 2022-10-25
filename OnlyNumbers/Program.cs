using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OnlyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String String = "./DOC1/XMLFile1.xml";
            XmlTextReader reader = new XmlTextReader(String);

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);

                        while (reader.MoveToNextAttribute())
                            Console.Write(" " + reader.Value + "'");
                        Console.Write(">");
                        Console.WriteLine(">");
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine();
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine();
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

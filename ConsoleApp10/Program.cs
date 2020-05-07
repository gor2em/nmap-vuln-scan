using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmldoc = new XmlDocument();
            string dosya = @"output.xml";
            xmldoc.Load(dosya);
            xmldoc.Save(Console.Out);
            Console.ReadKey();
        }
    }
}

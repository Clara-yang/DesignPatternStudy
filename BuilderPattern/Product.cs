using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BuilderPattern
{
    internal class Product
    {
        List<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("\n 产品创建----");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}

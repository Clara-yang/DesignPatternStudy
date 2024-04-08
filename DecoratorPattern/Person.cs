using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Person
    {
        public Person() { }
        private string name;
        public Person(string name)
        {
            this.name = name;
        }
        public virtual void Show()
        {
            Console.WriteLine("被装扮的" + name);
        }
    }
}

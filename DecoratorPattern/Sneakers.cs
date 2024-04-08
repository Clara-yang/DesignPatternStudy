using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Sneakers : FineryDecorator
    {
        public override void Show()
        {
            Console.WriteLine("穿球鞋");
            base.Show();
        }
    }
}

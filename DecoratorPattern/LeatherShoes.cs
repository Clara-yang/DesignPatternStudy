using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class LeatherShoes : FineryDecorator
    {
        public override void Show()
        {
            Console.WriteLine("穿皮鞋");
            base.Show();
        }
    }
}

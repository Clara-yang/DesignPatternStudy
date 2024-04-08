using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Tie : FineryDecorator
    {
        public override void Show()
        {
            Console.WriteLine("打领带");
            base.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class BigTrouser:FineryDecorator
    {
        public override void Show()
        {
            Console.WriteLine("穿垮裤");
            base.Show();
        }
    }
}

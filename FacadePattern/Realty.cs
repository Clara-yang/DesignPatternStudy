using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Realty
    {
        public void Buy()
        {
            Console.WriteLine("买入房地产");
        }

        public void Sell()
        {
            Console.WriteLine("卖出房地产");
        }

    }
}

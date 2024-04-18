using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Stock
    {
        public void Buy()
        {
            Console.WriteLine("买入股票");
        }

        public void Sell()
        {
            Console.WriteLine("卖出股票");
        }
    }
}

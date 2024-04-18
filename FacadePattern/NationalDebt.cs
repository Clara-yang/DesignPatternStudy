using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class NationalDebt
    {
        public void Buy()
        {
            Console.WriteLine("买入国债");
        }

        public void Sell()
        {
            Console.WriteLine("卖出国债");
        }
    }
}

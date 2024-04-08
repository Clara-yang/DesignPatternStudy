using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CashRebate : CashSuper
    {
        private double rebate = 1;
        public CashRebate(string moneyRebate)
        {
            rebate = double.Parse(moneyRebate);
        }
        public override double acceptCash(double money)
        {
            return money * rebate;
        }
    }
}

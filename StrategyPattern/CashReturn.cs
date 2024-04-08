using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CashReturn : CashSuper
    {
        private double returnCon = 0.0;
        private double returnMon = 0.0;
        public CashReturn(string returnCondition, string returnMoney)
        {
            returnCon = double.Parse(returnCondition);
            returnMon = double.Parse(returnMoney);
        }

        public override double acceptCash(double money)
        {
            double result = money;
            if (money >= returnCon)
            {
                result = money - Math.Floor(money / returnCon) * returnMon;
            }
            return result;
        }
    }
}

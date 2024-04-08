using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class CashContext
    {
        CashSuper? cs = null;
        public CashContext(string cashType)
        {
            switch (cashType)
            {
                case "正常收费":
                    CashNormal normal = new CashNormal();
                    cs = normal;
                    break;
                case "打8折":
                    CashRebate rebate = new CashRebate("0.8");
                    cs = rebate;
                    break;
                case "满300返50":
                    CashReturn re = new CashReturn("300", "50");
                    cs = re;
                    break;
            }
        }

        public double GetResult(double moeny)
        {
            return cs.acceptCash(moeny);
        }
    }
}

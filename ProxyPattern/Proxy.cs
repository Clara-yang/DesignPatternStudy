using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Proxy : IGiveGift
    {
        Pursuit pur;
        public Proxy(SchoolGirl girl)
        {
            this.pur = new Pursuit(girl);
        }

        public void GiveChocolate()
        {
            pur.GiveChocolate();
        }

        public void GiveDolls()
        {
            pur.GiveDolls();
        }

        public void GiveFlower()
        {
            pur.GiveFlower();
        }
    }
}

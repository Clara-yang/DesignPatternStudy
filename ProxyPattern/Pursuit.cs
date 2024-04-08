using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    internal class Pursuit : IGiveGift
    {
        SchoolGirl gril;
        public Pursuit(SchoolGirl mm)
        {
            gril = mm;
        }

        public void GiveChocolate()
        {
            Console.WriteLine("送巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine("送洋娃娃");
        }

        public void GiveFlower()
        {
            Console.WriteLine("送花");
        }
    }
}

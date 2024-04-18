using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAndThisDifferent
{
    internal class BaseMethodTest
    {
        public BaseMethodTest()
        {
            Console.WriteLine("BaseMethodTest has no parameter");
        }

        public BaseMethodTest(int a)
        {
            Console.WriteLine("BaseMethodTest has one parameter a=" + a);
        }
        public BaseMethodTest(int a, string str)
        {
            Console.WriteLine("BaseMethodTest has two parameters a=" + a + ",str=" + str);
        }

        void Start()
        {

        }
        void Update()
        {

        }

    }
}

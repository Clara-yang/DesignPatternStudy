using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAndThisDifferent
{
    internal class BaseMethod:BaseMethodTest
    {
        public BaseMethod() : base()
        {
            Console.WriteLine("====BaseMethod has no parameter");
        }

        public BaseMethod(int A) : base(A)
        {
            Console.WriteLine("====BaseMethod has one parameter A=" + A);
        }

        public BaseMethod(int A, string str1) : base(A,str1)
        {
            Console.WriteLine("====BaseMethod has two parameters A=" + A + ",str1=" + str1);
        }

        void Start()
        {

        }

        void Update()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAndThisDifferent
{
    internal class ThisMethod : BaseMethodTest
    {
        public ThisMethod() : base()
        {
            Console.WriteLine("====ThisMethod has no parameter");
        }

        public ThisMethod(int A) : this()
        {
            Console.WriteLine("====ThisMethod has one parameter A=" + A);
        }

        public ThisMethod(int A, string str1) : this(A)
        {
            Console.WriteLine("====ThisMethod has two parameters A=" + A + ",str1=" + str1);
        }

        void Start()
        {

        }

        void Update()
        {

        }

    }
}

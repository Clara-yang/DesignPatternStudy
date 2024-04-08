using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class CollegeStudentFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new CollegeStudent();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("Access中根据ID在Department表获取一条记录");
            return null;
        }

        public void Insert(Department dep)
        {
            Console.WriteLine("Access中在Department表添加一条记录");
        }
    }
}

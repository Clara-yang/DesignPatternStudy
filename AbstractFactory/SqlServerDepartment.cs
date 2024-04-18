using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class SqlServerDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("SqlServer中根据ID在Department表获取一条记录");
            return null;
        }

        public void Insert(Department dep)
        {
            Console.WriteLine("SqlServer中在Department表添加一条记录");
        }
    }
}

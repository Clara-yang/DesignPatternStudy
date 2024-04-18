using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class SqlServerUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("SQLserver中根据id得到user表的一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("SQLserver中在user表添加一条记录");
        }
    }
}

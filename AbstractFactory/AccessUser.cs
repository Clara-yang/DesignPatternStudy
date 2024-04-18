using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("Access中根据ID获取user表的一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("Access中在user表添加一条记录");
        }
    }
}

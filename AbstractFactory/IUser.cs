using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal interface IUser
    {
        // 添加user
        void Insert(User user);

        // 根据ID获取用户
        User GetUser(int id);
    }
}

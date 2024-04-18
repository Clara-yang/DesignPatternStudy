using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class ForeignCenter
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public void 进攻()
        {
            Console.WriteLine("外籍中锋{0}进攻", Name);
        }

        public void 防守()
        {
            Console.WriteLine("外籍中锋{0}防守", Name);
        }
    }
}

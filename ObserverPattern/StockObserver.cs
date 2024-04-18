using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class StockObserver
    {
        private string name;
        private ISubject sub;
        public StockObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStock()
        {
            Console.WriteLine("{0},{1}关闭股票行情，继续工作", sub.SubjectState, name);
        }
    }
}

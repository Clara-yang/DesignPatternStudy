using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class NBAObserver
    {
        private string name;
        private ISubject sub;
        public NBAObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNBA()
        {
            Console.WriteLine("{0},{1}关闭NBA，继续工作", sub.SubjectState, name);
        }

    }
}

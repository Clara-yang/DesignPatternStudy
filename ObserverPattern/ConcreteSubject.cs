using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // 委托跟类、接口是一个层级，所以在类外定义
    delegate void EventHandler();

    internal class ConcreteSubject : ISubject
    {
        public event EventHandler Update;

        private string subjectState;
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }

        public void Notify()
        {
            Update();
        }
    }
}

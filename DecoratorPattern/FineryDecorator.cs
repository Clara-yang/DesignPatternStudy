using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FineryDecorator : Person
    {
        protected Person? component;
        public void Decorator(Person com)
        {
            this.component = com;
        }
        public override void Show()
        {
            if (component != null)
            {
                component.Show();
            }

        }
    }
}

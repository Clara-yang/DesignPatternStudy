using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class WorkExperience : ICloneable
    {
        private string _workDate;
        public string WorkDate
        {
            get { return _workDate; }
            set { _workDate = value; }
        }

        private string _company;
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
}

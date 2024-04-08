using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;
        //private string timeArea;
        //private string company;

        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }
        private Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        public void SetPersonInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string tiemArea, string company)
        {
            work.WorkDate = tiemArea;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            Console.WriteLine("工作经历：{0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            Resume obj = new Resume(this.work);
            obj.name = name;
            obj.sex = sex;
            obj.age = age;
            return obj;
        }
    }
}

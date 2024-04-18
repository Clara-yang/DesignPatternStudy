using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class DateBase
    {
        // 程序集名称
        private static readonly string AssemblyName = "AbstractFactory";

        // 数据库类型
        //private static readonly string db = "SqlServer";
        //private string readonly string db = "Access";

        private static string db = ConfigurationManager.AppSettings["DB"].ToString();
        public static IUser CreateUser()
        {
            //IUser user = null;
            //switch (db)
            //{
            //    case "SqlServer":
            //        user = new SqlserverUser();
            //        break;
            //    case "Access":
            //        user = new AccessUser();
            //        break;
            //}
            //return user;

            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }

        public static IDepartment CreateDepartment()
        {
            //IDepartment department = null;
            //switch (db)
            //{
            //    case "SqlServer":
            //        department = new SqlServerDepartment();
            //        break;
            //    case "Access":
            //        department = new AccessDepartment();
            //        break;
            //}
            //return department;
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }

    }
}

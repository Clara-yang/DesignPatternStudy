using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    // 饿汉式单例类
    // public sealed class Singleton
    //   // sealed 阻止发生派生，因为派生可能会增加实例
    // {
    //   // 在第一次引用类的任何成员时创建实例，公共语言运行库负责处理变量初始化
    //   private static readonly Singleton instance=new Singleton();
    //   private Singleton(){}
    //   public static Singleton GetInstance()
    //   {
    //      return instance;
    //   }
    // }

    // 懒汉式单例类
    internal class Singleton
    {
        private static Singleton instance;

        // 程序运行时创建一个静态只读的进程辅助对象
        private static readonly object syncRoot = new object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            // 先判断实例是否存在，不存在再加锁处理
            if (instance == null)
            {
                lock (syncRoot)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}

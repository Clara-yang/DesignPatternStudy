// See https://aka.ms/new-console-template for more information

using SingletonPattern;

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();
if (s1 == s2)
{
    Console.WriteLine("两个对象是相同的实例");
}

Console.WriteLine("Hello, World!");
Console.ReadLine();
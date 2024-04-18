// See https://aka.ms/new-console-template for more information

using AdapterPattern;

Player a = new Forwards("前锋小前");
a.Attack();
Player b = new Translator("中锋姚明");
b.Defense();
b.Attack();
Player c = new Guards("后卫小后");
c.Attack();

Console.WriteLine("Hello, World!");

Console.ReadLine();

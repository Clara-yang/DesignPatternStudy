// See https://aka.ms/new-console-template for more information

using ObserverPattern;

ConcreteSubject s = new ConcreteSubject();
//s.Attach(new ConcreteObserver(s, "X"));
//s.Attach(new ConcreteObserver(s, "Y"));
//s.Attach(new ConcreteObserver(s, "Z"));

//int i = 10;
//var method = new GetAsString(i.ToString);

//Console.WriteLine($"method方法{method()}");
//Console.WriteLine($"method.Invoke方法{method.Invoke()}");

StockObserver stock = new StockObserver("小关", s);
NBAObserver nba = new NBAObserver("小赵", s);

s.Update += new ObserverPattern.EventHandler(stock.CloseStock);
s.Update += new ObserverPattern.EventHandler(nba.CloseNBA);
 
s.SubjectState = "老板回来了";
s.Notify();
Console.WriteLine("Hello, World!");
Console.ReadLine();

//delegate string GetAsString();




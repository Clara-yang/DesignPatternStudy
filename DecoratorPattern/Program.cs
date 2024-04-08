// See https://aka.ms/new-console-template for more information

using DecoratorPattern;

Person person = new Person("Alice");

Console.WriteLine("\n第一种装扮：");
TShirts tx = new TShirts();
BigTrouser kk = new BigTrouser();
Sneakers qx = new Sneakers();
tx.Decorator(person);
kk.Decorator(tx);
qx.Decorator(kk);
qx.Show();

Console.WriteLine("\n第二种装扮：");
Suit xz = new Suit();
Tie ld = new Tie();
BigTrouser kk2 = new BigTrouser();
LeatherShoes px = new LeatherShoes();
xz.Decorator(person);
ld.Decorator(xz);
kk2.Decorator(ld);
px.Decorator(kk2);
px.Show();

Console.ReadLine();

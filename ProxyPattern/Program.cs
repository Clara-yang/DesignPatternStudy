// See https://aka.ms/new-console-template for more information

using ProxyPattern;

SchoolGirl schoolGirl = new SchoolGirl();
Proxy proxy = new Proxy(schoolGirl);
proxy.GiveFlower();
proxy.GiveChocolate();
proxy.GiveDolls();  


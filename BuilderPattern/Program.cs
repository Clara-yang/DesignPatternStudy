﻿// See https://aka.ms/new-console-template for more information

using BuilderPattern;

Director director = new Director();
Builder b1 = new ConcreteBuilder1();
Builder b2 = new ConcreteBuilder2();

director.Construct(b1);
Product p1 = b1.GetResult();
p1.Show();

director.Construct(b2);
Product p2 = b2.GetResult();
p2.Show();

Console.WriteLine("Hello, World!");

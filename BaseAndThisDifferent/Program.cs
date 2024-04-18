// See https://aka.ms/new-console-template for more information

using BaseAndThisDifferent;

ThisMethod thisMethodNo = new ThisMethod();
ThisMethod thisMethodOne = new ThisMethod(1);
ThisMethod thisMethodTwo = new ThisMethod(3, "Hello thisMethod");

BaseMethod baseMethodNo = new BaseMethod();
BaseMethod baseMethodOne = new BaseMethod(2);
BaseMethod baseMethodTwo = new BaseMethod(4,"Hello baseMethod");

Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information

using TemplateMethod;

Console.WriteLine("学生A抄的试卷：");
TestPaper paperA = new TestPaperA();
paperA.TestQuestion1();
paperA.TestQuestion2();
paperA.TestQuestion3();

Console.WriteLine("学生B抄的试卷：");
TestPaper paperB = new TestPaperB();
paperB.TestQuestion1();
paperB.TestQuestion2();
paperB.TestQuestion3();

Console.WriteLine("Hello, World!");

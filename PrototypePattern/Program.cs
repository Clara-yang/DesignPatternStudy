// See https://aka.ms/new-console-template for more information

using PrototypePattern;

Resume a = new Resume("小菜");
a.SetPersonInfo("男", "26");
a.SetWorkExperience("2019-2022", "xx公司");

Resume b = (Resume)a.Clone();
b.SetWorkExperience("2020-2022", "yy公司");

Resume c = (Resume)a.Clone();
c.SetPersonInfo("女", "25");
a.Display();
b.Display();
c.Display();

Console.ReadLine();

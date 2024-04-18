// See https://aka.ms/new-console-template for more information

using AbstractFactory;

//User user = new User();
//IFactory factory = new SqlserverFactory();
//IUser iu = factory.CreateUser();
//iu.insert(user);
//iu.GetUser(1);

//Console.WriteLine("Hello, World!");

//Department dep = new Department();
//IFactory fac = new AccessFactory();
//IDepartment id = fac.CreateDepartment();
//id.Insert(dep);
//id.GetDepartment(1);

User user = new User();
IUser iu = DateBase.CreateUser();
iu.Insert(user);
iu.GetUser(1);

Department dep = new Department();
IDepartment idep = DateBase.CreateDepartment();
idep.Insert(dep);
idep.GetDepartment(1);

Console.ReadLine();



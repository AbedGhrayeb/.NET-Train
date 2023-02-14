// See https://aka.ms/new-console-template for more information
using EnumeratorIterators;

Console.WriteLine("Hello, World!");

var emp1 = new Employee { Age = 20, Id = 1, Name = "Abed", Salary = 900m };
var emp2 = new Employee { Age = 20, Id = 1, Name = "Abed", Salary = 900m };
var emp3 = emp1;

//by defualt [==, Equels] compare by refrence
//so we override its to make compre by content
Console.WriteLine(emp1==emp2);
Console.WriteLine(emp2==emp3);  
Console.WriteLine(emp1.Equals(emp2));

////////////////////////////////
Console.WriteLine("*****************");
var someInts = new SomeInt(10, 30, 5, 40, 1);

foreach (var item in someInts)
{
    Console.WriteLine(item);
}
////////////////////////////////////
Console.WriteLine("***********Compare***************");
var temps= new List<Temp>();

var random= new Random();
for (int i = 0; i < 100; i++)
    temps.Add(new Temp(random.Next(-10, 40)));
temps.Sort();
foreach (var temp in temps)
{
    Console.WriteLine(temp.Value);
}
Console.ReadKey();
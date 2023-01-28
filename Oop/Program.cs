// See https://aka.ms/new-console-template for more information
using Oop;

Console.WriteLine("Hello, World!");
/*
var emps = new Employee[2];

Console.WriteLine("-----------------First Employee----------------------");
var emp1 = new Employee();
Console.Write("First Name: ");
emp1.FName = Console.ReadLine();
Console.Write("Last Name: ");
emp1.LName = Console.ReadLine();
Console.Write("Wage: ");
emp1.Wage = double.TryParse(Console.ReadLine(), out double wage) ? wage : 0d;
Console.Write("Loged Hours: ");
emp1.LoggedHours = double.TryParse(Console.ReadLine(), out double hours) ? hours : 0d;
Console.WriteLine("-----------------Second Employee----------------------");

var emp2 = new Employee();
Console.Write("First Name: ");
emp2.FName = Console.ReadLine();
Console.Write("Last Name: ");
emp2.LName = Console.ReadLine();
Console.Write("Wage: ");
emp2.Wage = double.TryParse(Console.ReadLine(), out double wage2) ? wage2 : 0d;
Console.Write("Loged Hours: ");
emp2.LoggedHours = double.TryParse(Console.ReadLine(), out double hours2) ? hours2 : 0d;

emps[0] = emp1;
emps[1] = emp2;

foreach (var emp in emps)
{
    //var netSalary = emp.Wage * emp.LoggedHours - (emp.Wage * emp.LoggedHours * Employee.TAX);
    //Console.WriteLine($"first name: {emp.FName}");
    //Console.WriteLine($"last name: {emp.LName}");
    //Console.WriteLine($"wage: {emp.Wage}");
    //Console.WriteLine($"loged hours: {emp.LoggedHours}");
    //Console.WriteLine($"net salary: {netSalary}");
    //Console.WriteLine("---------------------");
    Console.WriteLine(emp.PritSlip());
    Console.WriteLine("---------------------");

}
*/
/*

Demo _demo = new Demo();
//ref:
//must be use ref keyword in caller & callee & muste argumanent have value (already intinlaze)
//out:
//must use out keyword in caller & callee & not care about argument value
var age = 15;
int num = 5;
Console.WriteLine($"age befor call method: {age}");
_demo.DoSomethingRef(ref age);
Console.WriteLine($"age after call method using ref: {age}");
Console.WriteLine($"num befor call method: {num}");
_demo.DoSomethingOut(out num);
Console.WriteLine($"num after call method using ref: {num}");

_demo.Promote(100, "Kanada", "Helton");
//if (_demo.IsEven(12))
//    Console.WriteLine("even number");
//else
//    Console.WriteLine("odd number");


var numArr = new int[] { 5, 10, 15, 12, 50 };

_demo.PrintEvens(numArr);
*/

var date = new Date(29, 2, 2000);
var da = new Date();
var dat = new Date(12, 2022);
var dda = new Date(2023);
Console.WriteLine(date.GetDate());
Console.WriteLine(dat.GetDate());
Console.WriteLine(dda.GetDate());
Console.WriteLine("-------------------");
var employee = Employees.Ini(100, "Abood", "Gh");
Console.WriteLine(employee.DisplayName());
Console.WriteLine("-------------------");
Dolar _dolar = new Dolar(20.2356m);
_dolar.Amount=30;
if(_dolar.IsZero)
    Console.WriteLine("zero ammount value");
Console.WriteLine(_dolar.ToString());
Console.WriteLine("-------------------");
var ip = new IP(124, 25, 33, 1);
var segment1= ip[0];
var segment2 = ip[1];
Console.WriteLine(ip.Addres);
Console.WriteLine(segment1);
Console.WriteLine(segment2);
var ip2 = new IP("10.20.30.40");
Console.WriteLine(ip2.Addres);
Console.ReadLine();

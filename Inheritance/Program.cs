// See https://aka.ms/new-console-template for more information
using Inheritance.Models;
using static Inheritance.Models.SimpleClass;

Console.WriteLine("Hello, World!");
Manager manager = new Manager(1, "Ali", 192.75m, 5.19m);
Maintanence maintanence = new Maintanence(2, "Ahmed", 166, 3.77m);
Sales sales = new Sales(3, "Saad", 166, 5.55m, 30000m, 0.02m);
Developer developer = new Developer(4, "Abed", 195.5m, 7.52m, true);

var employees = new Employee[] { manager, maintanence, sales, developer };
foreach (var emp in employees)
{
    Console.WriteLine(emp.ToString());
    Console.WriteLine("----------------------------------------------------------");

}
var nameValue = new SubClass();
Console.WriteLine(nameValue.Name);
Console.ReadLine();

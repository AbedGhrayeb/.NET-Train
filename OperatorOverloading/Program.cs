// See https://aka.ms/new-console-template for more information
using OperatorOverloading;

Console.WriteLine("Hello, World!");
var money1 = new Money(20m);
var money2 = new Money(10m);
var money=money1+ money2;
Console.WriteLine($"amount +: {money.Amount}");

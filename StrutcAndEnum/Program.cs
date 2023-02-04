// See https://aka.ms/new-console-template for more information
using StrutcAndEnum;

Console.WriteLine("Hello, World!");
DigitalSize size=new DigitalSize(25621740d);
Console.WriteLine(size.Bit);
Console.WriteLine(size.Byte);
Console.WriteLine(size.KB);
Console.WriteLine(size.MB);
Console.WriteLine(size.GB);
Console.WriteLine(size.TB);

Console.WriteLine("*************************");
var newSize = size.AddBit(500d);
//newSize is new struct value with new value, not last value + new value
Console.WriteLine(newSize.Bit);
Console.WriteLine(newSize.Byte);
Console.WriteLine(newSize.KB);
Console.WriteLine(newSize.MB);
Console.WriteLine(newSize.GB);
Console.WriteLine(newSize.TB); 
Console.WriteLine("*************************");
Age _age= new Age(1987,2,9);
Console.WriteLine(_age.ToString());
Console.WriteLine(_age.YourAge());
Console.ReadLine();
//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//int intNumber = 100;
////implcit: from low to high (no proplem)
//long longNumber = intNumber;

//long longNumber2 = 1000000000;
//if (longNumber2 <= int.MaxValue)
//{
//    //explict: from high to low (my be proplems)
//    int intNumber2 = (int)longNumber2;
//}
//else
//    Console.WriteLine("can't convert long to int");


////boxing: convert from data type value to data type refrence

//int num = 10;
//object obj = num;
//string str =num.ToString();
////unboxing: convert from data type refrence to data type value
//string stringVal = "w102";
////int testNum=int.Parse(stringVal);//exception

//if (int.TryParse(stringVal,out int testNum2))
//{
//    Console.WriteLine(testNum2);

//}

//int testNum3 = Convert.ToInt32(stringVal);//exception


var number = 2500;
var bytes= BitConverter.GetBytes(number);

foreach (var by in bytes)
{
    Console.Write(by.ToString("8:0"));
    Console.WriteLine("-------------------");
    Console.Write(Convert.ToString(by, 2).PadLeft(8, '0'));
}
Console.ReadLine();
// See https://aka.ms/new-console-template for more information
using Events;

Console.WriteLine("Hello, World!");
var stock = new Stock("Amazon");
stock.Price = 100m;

//Console.WriteLine($"{stock.Name} stock price befor change: ${stock.Price}");
//stock.ChangeStockPriceBy(0.05m);
//Console.WriteLine($"{stock.Name} stock price after change: ${stock.Price}");
//subscribe to event
stock.OnStockChanged += Stock_OnStockChanged;
//stock.OnStockChanged += (Stock stock, decimal oldPrice) =>
//{
//    Console.ForegroundColor = ConsoleColor.Black;

//    var result = "";
//    if (stock.Price > oldPrice)
//    {


//        Console.ForegroundColor = ConsoleColor.Green;
//        result = "Up";
//    }
//    else if (stock.Price < oldPrice)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        result = "Down";
//    }
//    else
//        Console.ForegroundColor = ConsoleColor.Gray;
//    Console.WriteLine($"{stock.Name} stock price : ${stock.Price} - {result}");

//};

stock.ChangeStockPriceBy(0.05m);
stock.ChangeStockPriceBy(-0.02m);
stock.ChangeStockPriceBy(0.00m);

//unsubscribe
stock.OnStockChanged -= Stock_OnStockChanged;

void Stock_OnStockChanged(Stock stock, decimal oldPrice)
{
    Console.ForegroundColor = ConsoleColor.Black;

    var result = "";
    if (stock.Price > oldPrice)
    {


        Console.ForegroundColor = ConsoleColor.Green;
        result = "Up";
    }
    else if (stock.Price < oldPrice)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        result = "Down";
    }
    else
        Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"{stock.Name} stock price : ${stock.Price} - {result}");
}

Console.ReadKey();
// See https://aka.ms/new-console-template for more information
using ListDictionary.Classes;

Console.WriteLine("Hello, World!");
var egypt = new Country { ISOCode = "EGY", Name = "Egypt" };
var jordan = new Country { ISOCode = "JOR", Name = "Jordan" };
var iraq = new Country { ISOCode = "IRQ", Name = "Iraq" };

Country[] countriesArray =
{
                egypt,
                jordan,
                iraq
            };

// Constructors
//List<Country> countries = new List<Country>();
// List<Country> countries = new List<Country>(3);
List<Country> countries = new List<Country>(countriesArray);

// Methods
countries.Add(new Country { ISOCode = "BRA", Name = "Brasil" }); // O(1)
                                                                 //countries.AddRange(countriesArray);


countries.Insert(1, new Country { ISOCode = "FRA", Name = "France" }); // O(n)

Country.Print(countries);
countries.RemoveAt(4);

countries.RemoveAll(x => x.Name.EndsWith("ce"));
//by default not remove {iraq} 2 refrance, but when override (Gethashcode & Equel) function remove it 
countries.Remove(new Country { ISOCode = "IRQ", Name = "Iraq" });

Country.Print(countries);
/******************Dictionary*******************************/
var article =
    "Dot NET is a free cross-platform and open source developer platform" +
    "for building many different types of applications" +
    "With Dot NET you can use multiple languages and libraries" +
    "to build for web and IoT";

var lettersDictionary = new Dictionary<char, List<string>>();
foreach (var word in article.Split())
{
    var wordLetters=word.ToLower();
    foreach (var ch in wordLetters)
    {
        if (!lettersDictionary.ContainsKey(ch))
            lettersDictionary.Add(ch, new List<string> { wordLetters});
        else
            lettersDictionary[ch].Add(wordLetters);
    }
}

foreach (var entry in lettersDictionary)
{
    Console.Write($"'{entry.Key}'");
    foreach (var word in entry.Value)
    Console.WriteLine($"\t\t \'{word}\'");
    Console.WriteLine();
}

Console.WriteLine("/**********************************/");
var emps = new List<Employee>
            {
                new Employee {Id = 100, Name = "Reem S.", ReportTo = null},
                new Employee {Id = 101, Name = "Raed M.", ReportTo = 100 },
                new Employee {Id = 102, Name = "Ali B.", ReportTo = 100 },
                new Employee {Id = 103, Name = "Abeer S.", ReportTo = 102 },
                new Employee {Id = 104, Name = "Radwan N.", ReportTo = 102 },
                new Employee {Id = 105, Name = "Nancy R.", ReportTo = 101 },
                new Employee {Id = 106, Name = "Saleh A.", ReportTo = 104 }
            };

//var managers = emps.GroupBy(x => x.ReportTo);
var managers = emps.ToLookup(x => x.ReportTo).ToDictionary(x => x.Key ?? -1, x => x.ToList());

foreach (var entry in managers)
{
    //top manager
    if (entry.Key == -1)
        continue;
    var manager = emps.FirstOrDefault(x => x.Id == entry.Key);

    Console.WriteLine($"{manager}");

    foreach (var emp in entry.Value)
    {
        Console.WriteLine($"\t\t\"{emp}\"");
    }
}
Console.ReadKey();

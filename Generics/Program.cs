Helper.Print(1);
//only take intger
Helper.Print<int>(10);
Helper.Print("Hello world!");
Helper.Print(new { FName = "Abed", LName = "Ghrayeb" });
Helper.Print(new Person("Abed", "Ghrayeb"));



var persons = new Any<Person>();
persons.Add(new Person("Abed", "Ghrayeb"));
persons.Add(new Person("Ahmed", "Mousa"));

Console.WriteLine(persons.Count);
persons.Display();
var intValues = new int[] { 20, 30, 5, 7, 15, 3, 111, 60, 7, 13, 9 };
Console.WriteLine("Values > 20");
Helper.PrinValues(intValues, i => i > 20);
Console.WriteLine("Values < 50");
Helper.PrinValues(intValues, i => i < 20);
Console.WriteLine("Even values");
Helper.PrinValues(intValues, i => i % 2 == 0);
//*********use microsoft delegate*********
Console.WriteLine("Values > 20");
Helper.PrinValuesByPredicate(intValues, i => i > 20);
Console.WriteLine("Values < 50");
Helper.PrinValuesByFun(intValues, i => i < 20);
Helper.PrinValuesByFuncAction(intValues, i => i % 2 == 0, () => Console.WriteLine("Even Values..."));
Console.ReadLine();
public static class Helper
{
    //function take T as a parameter and return true or false
    public delegate bool Filter<in T>(T value);
    public static void Print(object obj)
    {
        Console.WriteLine(obj);
    }
    //genric method
    public static void Print<T>(T val)
    {
        Console.WriteLine($"Data Type: {typeof(T).ToString()}");
        Console.WriteLine($"Data Value: {val}");
    }

    public static void PrinValues<T>(IEnumerable<T> values, Filter<T> filter)
    {
        foreach (var item in values)
        {
            if (filter(item))
                Console.WriteLine(item);
        }
    }
    public static void PrinValuesByPredicate<T>(IEnumerable<T> values, Predicate<T> filter)
    {
        foreach (var item in values)
        {
            if (filter(item))
                Console.WriteLine(item);
        }
    } 
    public static void PrinValuesByFun<T>(IEnumerable<T> values, Func<T,bool> filter)
    {
        foreach (var item in values)
        {
            if (filter(item))
                Console.WriteLine(item);
        }
    }
    public static void PrinValuesByFuncAction<T>(IEnumerable<T> values, Func<T,bool> filter,Action action)
    {
        action();
        foreach (var item in values)
        {
            if (filter(item))
                Console.WriteLine(item);
        }
    }
}
public class Person
{
    public Person()
    {

    }
    public Person(string fname, string lname)
    {
        FName = fname;
        LName = lname;
    }
    private string FName;
    private string LName;

    public override string ToString()
    {
        return $"{FName} {LName}";
    }
}
//T must be class & contains parametrless cons
class Any<T> where T : class, new()
{
    private T[] _items;

    public void Add(T item)
    {
        if (_items is null)
        {
            _items = new T[] { item };
        }
        else
        {
            var length = _items.Length;
            var dest = new T[length + 1];
            for (int i = 0; i < _items.Length; i++)
            {
                dest[i] = _items[i];
            }
            dest[length] = item;
            _items = dest;
        }
    }
    public void RemoveAt(int index)
    {
        if (index < 0 || index > _items.Length - 1)
            return;
        var position = 0;
        var dest = new T[_items.Length - 1];
        for (int i = 0; i < _items.Length; i++)
        {
            if (i == index)
                continue;
            dest[position++] = _items[i];
        }
        _items = dest;
    }
    public bool IsEmpty => _items.Length == 0 || _items is null;
    public int Count => _items is not null ? _items.Length : 0;

    public void Display()
    {
        if (_items is not null && _items.Length > 0)
        {
            Console.Write("[ ");

            for (int i = 0; i < _items.Length; i++)
            {
                var item = i < _items.Length - 1 ? $"{_items[i]} , " : $"{_items[i]}";
                Console.Write(item);
            }
            Console.Write(" ]");

        }
        else
            Console.WriteLine("Empty!!");
        Console.WriteLine();

    }
}




static IEnumerable<int> GenerateRandomIntArray(int length)
{
    var random = new Random();
    for (int i = 0; i < length; i++)
        yield return random.Next(i, length);


}
var numbers = GenerateRandomIntArray(100).ToArray();
Console.WriteLine("Enter your guess number: ");
string input = Console.ReadLine();
Console.WriteLine($"Geuss index: {GuestGeBinarySearch(numbers, int.Parse(input))}");
Console.WriteLine("cc");
string GuestGeBinarySearch(int[] list, int item)
{
    var low = 0;
    var high = list.Count() - 1;
    int mid = 0;
    int guess;
    while (low <= high)
    {
        mid = (int)Math.Ceiling((low + high) / 2M);
        guess = list[mid];
        if (guess == item)
            return mid.ToString();
        if (!list.Contains(item))
            return "not exist";
        if (guess > item)
            high = mid - 1;
        else
            low = mid - 1;

    }
    return "not exist";
}
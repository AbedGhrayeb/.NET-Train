namespace Oop
{
    internal class Demo
    {
        public void DoSomethingRef(ref int age)
        {
            age += 3;
        }
        public void DoSomethingOut(out int num)
        {
            num = 10;
            num += 3;
        }

        //method signiture (Name + parm type + parms order)

        // method overloading (a common way of implementing Polymorphism)
        public void DoSomething(int x, double y)
        {
            return;
        }
        public void DoSomething(double x, int y)
        {
            return;
        }

        public void Promote(double amount)
        {
            Console.WriteLine($"You've got a promote of ${amount}");
        }
        public void Promote(double amount, string trip)
        {
            Console.WriteLine($"You've got a promote of ${amount} and a trip {trip}");
        }
        public void Promote(double amount, string trip, string hotel)
        {
            Console.WriteLine($"You've got a promote of ${amount} and a trip {trip} with {hotel}");
        }
        public void PrintEvens(int[] numbers)
        {
            if (numbers.Any())
            {
                foreach (var item in numbers)
                {
                    var text = IsEven(item) ? $"{item} is even." : $"{item} is odd.";
                    Console.WriteLine(text);
                }
                //local method
                 bool IsEven(int num) => num % 2 == 0;
            }
            else
                Console.WriteLine("numbers array is empty");
        }
        //public bool IsEven(int num) => num % 2 == 0;
    }
}


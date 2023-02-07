using Interfaces.Abstract;

namespace Interfaces.Concrete
{
    public class PayMethod
    {
        internal class Cash : IPay
        {
            public void Pay(decimal amount) => Console.WriteLine($"Cash payment: ${Math.Round(amount, 2):N0}");

        }
        internal class Depit : IPay
        {
            public void Pay(decimal amount) => Console.WriteLine($"Depit payment: ${Math.Round(amount, 2):N0}");

        }
        internal class MasterCard : IPay
        {
            public void Pay(decimal amount) => Console.WriteLine($"MasterCard payment: ${Math.Round(amount, 2):N0}");
        }
    }
}

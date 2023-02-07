using Interfaces.Abstract;

namespace Interfaces.Concrete
{
    internal class Cashier
    {
        private readonly IPay _pay;

        public Cashier(IPay pay)
        {
            _pay = pay;
        }

        public void Checkout(decimal amount)
        {
            _pay.Pay(amount);
        }
    }
}

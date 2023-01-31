namespace OperatorOverloading
{
    internal class Money
    {
        private decimal _amount;
        public decimal Amount { get { return _amount; } }

        public Money(decimal amount)
        {
            _amount = amount;
        }
        public static Money operator +(Money money1, Money money2)
        {
            var result = money1.Amount + money2.Amount;
            return new Money(result);
        }
        public static Money operator -(Money money1, Money money2)
        {
            var result = money1.Amount - money2.Amount;
            return new Money(result);
        }
        public static Money operator *(Money money1, Money money2)
        {
            var result = money1.Amount * money2.Amount;
            return new Money(result);
        }
        public static Money operator /(Money money1, Money money2)
        {
            var result = money1.Amount / money2.Amount;
            return new Money(result);
        }
        public static bool operator >(Money money1, Money money2) => money1.Amount > money2.Amount;
        public static bool operator <(Money money1, Money money2) => money1.Amount < money2.Amount;
        public static bool operator >=(Money money1, Money money2) => money1.Amount >= money2.Amount;
        public static bool operator <=(Money money1, Money money2) => money1.Amount <= money2.Amount;
        public static bool operator ==(Money money1, Money money2) => money1.Amount == money2.Amount;
        public static bool operator !=(Money money1, Money money2) => money1.Amount != money2.Amount;
        public static Money operator ++(Money money)
        {
            var result = money.Amount;
            return new Money(++result);
        }
        public static Money operator --(Money money)
        {
            var result= money.Amount;
            return new Money(--result);

        }
    }
}

namespace Oop
{
    internal class Dolar
    {
        //field must be privet
        //to set value on field use contructer
        private decimal _amount;
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = ProccesValue(value); }
        }
        //public method to set Amount Value
        public decimal SetAmount(decimal value)=> Amount=value;
        //use constuctor to set value to field
        public Dolar(decimal amount)
        {
            _amount = ProccesValue(amount);
        }
        public bool IsZero=> _amount==0;
        public decimal ConversionFactor{get;}=1.99M;
        public decimal AoutmaticProperty { get; set; }
        private decimal ProccesValue(decimal value) => value <= 0 ? 0M : Math.Round(value, 2);
        public override string ToString() { return $" Amount value : {_amount.ToString()}$"; }
    }
}

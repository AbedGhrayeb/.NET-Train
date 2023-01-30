namespace Events
{
    internal class Stock
    {

        public delegate void StockChangeHandler(Stock stock, decimal oldPrice);
        //event type like delegate name
        public event StockChangeHandler OnStockChanged;
        private string _name;
        private decimal _price;

        public string Name => this._name;
        public decimal Price { get { return this._price; } set { this._price = value; } }

        public Stock(string name) => this._name = name;

        public void ChangeStockPriceBy(decimal percent)
        {
            var oldPrice = this._price;
            this._price += Math.Round(this._price * percent);
            if (OnStockChanged != null)//make sure subscriber exist
            {
                OnStockChanged(this, oldPrice);//fire event
            }
        }

    }
}
/*
 * 1- delegate with void return take class type & parameters you need to change
 * 2-public event with type of delgate;
 * 3-make sure there is subscriber exist
 * 4-on method you need to fire event fire event
 * */

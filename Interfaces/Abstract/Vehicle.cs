namespace Interfaces.Abstract
{
    internal abstract class Vehicle
    {
        protected string Brand;
        protected string Model;
        protected int Year;
        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
    }
}


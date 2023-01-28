namespace Oop
{
    public class Employee
    {
        //constant;
        public const double TAX = 0.03d;
        //fileds
        public string FName;
        public string LName;
        public double Wage;
        public double LoggedHours;

        private double Calculate() => Wage * LoggedHours;
        private double CalculateTax() => Calculate() * TAX;
        private double CalculateNet() => Calculate() - CalculateTax();
        public string PritSlip()
        {
            return $"\nfirst name: {FName}" +
             $"\nlast name: {LName}" +
             $"\nwage: {Wage}" +
             $"\nloged hours: {LoggedHours}" +
             $"\nnet salary: {CalculateNet()}";
        }

    }
}

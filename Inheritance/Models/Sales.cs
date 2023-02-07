namespace Inheritance.Models
{
    internal class Sales : Employee
    {
        public Sales(int id, string name, decimal loggedHours, decimal wage, decimal salesVolume, decimal commission) : base(id, name, loggedHours, wage)
        {
            SalesVolume = salesVolume;
            Commission = commission;
        }

        protected decimal SalesVolume { get; set; }
        protected decimal Commission { get; set; }
        protected override decimal CalculateSalary() => base.CalculateSalary() + CalculatBouns();
        private decimal CalculatBouns() => SalesVolume * Commission;
        public override string ToString()
        {
            return base.ToString() +
                $"\nCommition: {Math.Round(CalculatBouns()):N0}" +
                $"\nBouns: {Math.Round(CalculatBouns()):N0}" +
                $"\nNet Salary: {Math.Round(this.CalculateSalary(), 2):N0}";
        }
    }
}

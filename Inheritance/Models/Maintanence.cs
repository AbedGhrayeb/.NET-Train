namespace Inheritance.Models
{
    internal class Maintanence : Employee
    {
        private const decimal Hardship = 100M;

        public Maintanence(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }

        protected override decimal CalculateSalary() => base.CalculateSalary() + CalculatHardship();
        private decimal CalculatHardship() => base.CalculateSalary() * Hardship;
        public override string ToString()
        {
            return base.ToString() +
                $"\nHardship: {Math.Round(CalculatHardship()):N0}" +
                $"\nNet Salary: {Math.Round(this.CalculateSalary(), 2):N0}";
        }
    }
}

namespace Inheritance.Models
{
    internal class Manager : Employee
    {
        private const decimal AllowanceRate = 0.05M;

        public Manager(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        {
        }

        protected override decimal CalculateSalary() => base.CalculateSalary() + CalculatAllownace();
        private decimal CalculatAllownace() => base.CalculateSalary() * AllowanceRate;
        public override string ToString()
        {
            return base.ToString() +
                $"\nAllownace: {Math.Round(CalculatAllownace()):N0}" +
                $"\nNet Salary: {Math.Round(this.CalculateSalary(), 2):N0}";
        }
    }
}

namespace Inheritance.Models
{
    internal class Employee
    {
        private const int MinimumLoggedHours = 176;
        private const decimal OverTimeRate = 1.25M;

        public Employee(int id, string name, decimal loggedHours, decimal wage)
        {
            Id = id;
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        }

        protected int Id { get; set; }
        protected string Name { get; set; }
        protected decimal LoggedHours { get; set; }
        protected decimal Wage { get; set; }
        //virtual to allow other classes(by inheritance) override this functions
        protected virtual decimal CalculateSalary() => CalculateBaseSalray() + CalculateOverTimeSalary();

        protected virtual decimal CalculateBaseSalray() => Wage * MinimumLoggedHours;
        protected virtual decimal CalculateOverTimeSalary()
        {
            var additinalHours = (LoggedHours - MinimumLoggedHours) > 0 ? (LoggedHours - MinimumLoggedHours) : 0;
            return additinalHours * Wage * OverTimeRate;
        }

        public override string ToString()
        {
            return 
                $"{GetType().Name}"+
                $"\nId: {Id}" +
                $"\nName: {Name}" +
                $"\nLogged Hours: {Math.Round(LoggedHours, 2):N0} hrs" +
                $"\nWage: {Math.Round(Wage, 2)} $/hr" +
                $"\nBase Salary: {Math.Round(CalculateBaseSalray(), 2):N0}" +
                $"\nOverTime Salary: {Math.Round(CalculateOverTimeSalary(), 2):N0}" +
                $"\nTotal Salary: {Math.Round(CalculateBaseSalray() + CalculateOverTimeSalary(), 2):N0}";
        }
    }
}

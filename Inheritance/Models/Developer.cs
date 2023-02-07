namespace Inheritance.Models
{
    internal class Developer : Employee
    {
        private const decimal Commission = 0.03M;

        public Developer(int id, string name, decimal loggedHours, decimal wage, bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            TaskCompleted = taskCompleted;
        }

        protected bool TaskCompleted { get; set; }
        protected override decimal CalculateSalary() => base.CalculateSalary() + CalculatBouns();
        private decimal CalculatBouns()
        {
            if (TaskCompleted)
                return base.CalculateSalary() * Commission;
            return 0;
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nTask Completed: {(TaskCompleted ? "Yes" : "No")}" +
                $"\nCommition: {Math.Round(CalculatBouns()):N0}" +
                $"\nBouns: {Math.Round(CalculatBouns()):N0}" +
                $"\nNet Salary: {Math.Round(this.CalculateSalary(), 2):N0}";
        }
    }
}

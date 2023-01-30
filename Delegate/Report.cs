namespace Delegate
{
    internal class Report
    {
        public delegate bool illegibleSale(Employee employee);
        public void ProcessEmpoyee(Employee[] employees, string title, illegibleSale isIllegibleSale)
        {
            Console.WriteLine(title);
            Console.WriteLine("------------------------------------------");
            foreach (var emp in employees)
            {
                if (isIllegibleSale(emp))
                {
                    Console.WriteLine($"{emp.Id} | {emp.Name} | {emp.Gender.ToString()} | ${emp.TotalSalels}");
                }
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = Extentions.Employees.ToArray();
            Report report = new Report();


            //report.ProcessEmpoyee(employees, "Sales more than $60,000", delegate (Employee emp) { return emp.TotalSalels > 60000; });
            //report.ProcessEmpoyee(employees, "Sales less than $30,000", delegate (Employee emp) { return emp.TotalSalels < 30000; });
            //report.ProcessEmpoyee(employees, "Slaes between 30,000 & 60,000", delegate (Employee emp) { return emp.TotalSalels > 30000 && emp.TotalSalels < 60000; });

            //report.ProcessEmpoyee(employees, "Sales more than $60,000", (Employee emp) => emp.TotalSalels > 60000);
            //report.ProcessEmpoyee(employees, "Sales less than $30,000", (Employee emp) => emp.TotalSalels < 30000);
            //report.ProcessEmpoyee(employees, "Slaes between 30,000 & 60,000", (Employee emp) => emp.TotalSalels > 30000 && emp.TotalSalels < 60000);

            report.ProcessEmpoyee(employees, "Sales more than $60,000", emp => emp.TotalSalels > 60000);
            report.ProcessEmpoyee(employees, "Sales less than $30,000", emp => emp.TotalSalels < 30000);
            report.ProcessEmpoyee(employees, "Slaes between 30,000 & 60,000", emp => emp.TotalSalels > 30000 && emp.TotalSalels < 60000);
            //Console.ReadLine();
        }
    }
}

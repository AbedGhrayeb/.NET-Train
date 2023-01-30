namespace Delegate
{
    public static class Extentions
    {
        public static readonly IEnumerable<Employee> Employees = new Employee[]
        {
            new Employee { Id = 1,Name="Abdulrahman", Gender= Gender.Male,TotalSalels=65000m},
            new Employee { Id = 2,Name="Hosam", Gender= Gender.Male,TotalSalels=50000},
            new Employee { Id = 3,Name="Mohamad", Gender= Gender.Male,TotalSalels=65000m},
            new Employee { Id = 4,Name="Mahmoud", Gender= Gender.Male,TotalSalels=40000},
            new Employee { Id = 5,Name="Ismail", Gender= Gender.Male,TotalSalels=42000m},
            new Employee { Id = 6,Name="Ola", Gender= Gender.Female,TotalSalels=30000m},
            new Employee { Id = 7,Name="Safa", Gender= Gender.Female,TotalSalels=16000m},
            new Employee { Id = 8,Name="Asma", Gender= Gender.Female,TotalSalels=15000m},
        };
    }
}

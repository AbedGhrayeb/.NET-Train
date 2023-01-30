namespace Delegate
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal TotalSalels { get; set; }
        public Gender Gender { get; set; }
    }
    public enum Gender
    {
        Male = 1,
        Female = 2,
    }
}
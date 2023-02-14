using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorIterators
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Employee)) return false;

                var emp = obj as Employee;
            return this.Id == emp.Id && this.Name == emp.Name && this.Age == emp.Age;

        }

        public override int GetHashCode()
        {
            var hash = 17;
            hash=(hash*7)+Id.GetHashCode();
            hash=(hash*7)+Name.GetHashCode();
            hash=(hash*7)+Age.GetHashCode();

            return hash;
        }

        public static bool operator ==(Employee left, Employee right)=> left.Equals(right);
        public static bool operator !=(Employee left, Employee right) => !left.Equals(right);
    }
}

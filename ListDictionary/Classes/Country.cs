using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary.Classes
{
    internal class Country
    {
        public string ISOCode { get; set; }
        public string Name { get; set; }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 19;
                hash=hash*397+Name.GetHashCode();
                hash=hash*397+ISOCode.GetHashCode();

                return hash;
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var country= obj as Country;
            if (country == null) return false;
            return this.Name.Equals(country.Name,StringComparison.OrdinalIgnoreCase) && this.ISOCode.Equals(country.ISOCode,StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"{Name}  {ISOCode}";
        }

        public static void Print(List<Country> list)
        {
            foreach (var country in list) 
            Console.WriteLine(country);

            Console.WriteLine(list.Count);//actual count
            Console.WriteLine(list.Capacity); //initial capacity for inner data structure

        }
    }
}

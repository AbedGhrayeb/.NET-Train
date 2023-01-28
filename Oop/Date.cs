namespace Oop
{
    public class Date
    {
        private readonly int[] DaysToMonth365 = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private readonly int[] DaysToMonth366 = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //readonly can assige value here or in constructor onyl;
        private readonly int _day = 1;
        private readonly int _month = 1;
        private readonly int _year = 1;
        public Date()
        {

        }
        //use the constracture accept 3 params
        public Date(int month, int year) : this(1, month, year) { }
        public Date(int year) : this(1, 1, year) { }
        public Date(int day, int month, int year)
        {
            var isLeap = year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
            if (year >= 1 && year <= 9999 && month >= 1 && month <= 12)
            {
                int[] days = isLeap ? DaysToMonth366 : DaysToMonth365;
                if (day >= 1 && day <= days[month - 1])
                {
                    _day = day;
                    _month = month;
                    _year = year;
                }

            }
        }
    

        public string GetDate()
        {
            return $"{_day.ToString().PadLeft(2, '0')}/{_month.ToString().PadLeft(2, '0')}/{_year.ToString("0000")}";
        }
    }
}

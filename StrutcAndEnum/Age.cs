using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrutcAndEnum
{
    internal readonly struct Age
    {
        // becuse is read only struct, must be all struct members shud be readonly
        private readonly int _year;
        private  readonly int _month;
        private readonly int _day;

        public Age(int year,int month,int day)
        {
            _year= year;
            _month= month;
            _day= day;
        }
        private DateTime GetDate=> new DateTime(_year, _month, _day);
        public override string ToString() => GetDate.ToString("yyy-MM-dd");
        //not correct way but for simple
        public string YourAge()
        {
            var years = (DateTime.Today.Year - GetDate.Year);
            var months = (DateTime.Today.Month - GetDate.Month);
            var days = (DateTime.Today.DayOfYear - GetDate.Month);
            return $"years: {years}, month: {months}, days: {days}";
        }
    }
}

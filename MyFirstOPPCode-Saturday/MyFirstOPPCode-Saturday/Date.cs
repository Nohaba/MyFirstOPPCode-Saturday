using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOPPCode_Saturday
{
    public class Date
    {
        #region Fields

        private int _year;
        private int _month;
        private int _day;

        #endregion

        #region Methods
        public Date(int year, int month, int day)
        { 
            _year = ValidateYear(year);
            _month = ValidateMonth(month);
            _day = ValidateDay(day, month, year);
        }

        
        private int ValidateYear(int year)
        {
            if (year >= 1900)
            {
                return year;
            }
            throw new NotImplementedException("The year is invalid!");
        }

        private int ValidateMonth(int month)
        {
            if (month >= 1 && month <= 12) 
            {
                return month;
            }
            throw new NotImplementedException("The month es invalid");
        }

        private int ValidateDay(int day, int month, int year)
        {
            if(month == 2 && day == 29 && IsleapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month]) 
            {
                return day;
            }
            throw new NotImplementedException("The day es invalid");
        }

        //UN AÑO BISIESTO SE DA CADA 4 AÑOS, CADA 400 AÑOS. PERO NO CADA 100 AÑOS
        private bool IsleapYear(int year)
        { 
            bool isLeap = (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);

            return isLeap;
        }

        public override string ToString()
        {
            string date = $"{_year:0000}/{_month:00}/{_day:00}";
            return date;
        }
        #endregion
    }
}

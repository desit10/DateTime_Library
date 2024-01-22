using System;
using System.Globalization;

namespace DateTime_Library
{
    public class DateTimeFormatting
    {
        public int DateTimeDifference(DateTime dateStart, DateTime dateEnd)
        {
            TimeSpan difference = dateEnd.Subtract(dateStart);

            return difference.Days;
        }

        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                {
                    // не високосный год
                    return false;
                }
                else
                {
                    // високосный год
                    return true;
                }
            }
            else
            {
                // не високосный год
                return false;
            }
        }

        public string TimeofDay(DateTime date)
        {
            return date.TimeOfDay.ToString();
        }

        public string DateTimeformat(DateTime date, string format, string language)
        {
            DateTimeFormatInfo formatter = new CultureInfo(language).DateTimeFormat;
            string formattedDateTime = date.ToString(format, formatter);

            return formattedDateTime;
        }

    }
        
}

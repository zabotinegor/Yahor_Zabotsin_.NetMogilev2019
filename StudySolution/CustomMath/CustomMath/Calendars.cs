using System;
using System.Globalization;

namespace CustomMath
{
    public static class Calendars
    {
        public static bool GetDaysInMonth(DateTimeFormatInfo dateTimeFormatInfo, int month, out string monthName, out int daysInMonth, int year = 2019)
        {
            daysInMonth = default;
            monthName = default;

            if ((year <= 0) || (month <= 0) || (month > 12) || (dateTimeFormatInfo == null))
            {
                return false;
            }
            else
            {
                monthName = dateTimeFormatInfo.MonthNames[month - 1];
                daysInMonth = DateTime.DaysInMonth(year, month);
                return true;
            }
        }

        public static bool GetDaysInMonth(DateTimeFormatInfo dateTimeFormatInfo, string month, out int daysInMonth, int year = 2019)
        {
            var result = false;
            daysInMonth = default;

            if (string.IsNullOrEmpty(month) || (dateTimeFormatInfo == null))
            {
                return false;
            }

            for (var i = 0; i <= dateTimeFormatInfo.MonthNames.Length - 1; i++)
            {
                if (string.IsNullOrEmpty(dateTimeFormatInfo.MonthNames[i]))
                {
                    continue;
                }

                if (!string.Equals(dateTimeFormatInfo.MonthNames[i], month,
                    StringComparison.CurrentCultureIgnoreCase))
                {
                    continue;
                }

                daysInMonth = DateTime.DaysInMonth(year, i + 1);
                result = true;
                break;
            }

            return result;
        }
    }
}

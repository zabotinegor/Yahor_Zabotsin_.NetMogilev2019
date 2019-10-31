using System;
using System.Globalization;

namespace CustomMath
{
    public static class Calendars
    {
        public static bool GetDaysInMonth(DateTimeFormatInfo dtfi, int month, out string monthName, out int daysInMonth, int year = 2019)
        {
            daysInMonth = default;
            monthName = default;

            if ((year <= 0) || (month <= 0) || (month > 12) || (dtfi == null))
            {
                return false;
            }
            else
            {
                monthName = dtfi.MonthNames[month - 1];
                daysInMonth = DateTime.DaysInMonth(year, month);
                return true;
            }
        }

        public static bool GetDaysInMonth(DateTimeFormatInfo dtfi, string month, out int daysInMonth, int year = 2019)
        {
            var result = false;
            daysInMonth = default;

            if (string.IsNullOrEmpty(month) || (dtfi == null))
            {
                return false;
            }

            for (var i = 0; i <= dtfi.MonthNames.Length - 1; i++)
            {
                if (string.IsNullOrEmpty(dtfi.MonthNames[i]))
                {
                    continue;
                }

                if (string.Equals(dtfi.MonthNames[i], month, StringComparison.CurrentCultureIgnoreCase))
                {
                    daysInMonth = DateTime.DaysInMonth(year, i + 1);
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}

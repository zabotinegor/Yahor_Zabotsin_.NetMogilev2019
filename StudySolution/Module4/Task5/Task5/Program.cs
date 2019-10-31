using CustomMath;
using InputLib;
using System;
using System.Globalization;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo;

            Console.WriteLine(Resources.Messages.MessageEnterMonth);

            var stringBuffer = Console.ReadLine();

            if (InputData.IntData(stringBuffer, out var month))
            {
                Console.WriteLine(Calendars.GetDaysInMonth(dateTimeFormatInfo, month, out var monthName, out var daysInMonth)
                    ? $@"{monthName}, {daysInMonth} {MatchingDaysWithNumerals(daysInMonth)}"
                    : Resources.Messages.MessageWrongMonthNumber);
            }
            else
            {
                Console.WriteLine(Calendars.GetDaysInMonth(dateTimeFormatInfo, stringBuffer, out var daysInMonth)
                    ? $@"{stringBuffer.StartWithСap()}, {daysInMonth} {MatchingDaysWithNumerals(daysInMonth)}"
                    : Resources.Messages.MessageWrongMonthName);
            }

            Console.ReadKey();
        }

        private static string MatchingDaysWithNumerals(int days)
        {
            if ((2 <= days) && (days < 5))
            {
                return Resources.Messages.DayGenitive;
            }
            else if ((5 <= days) && (days < 20))
            {
                return Resources.Messages.DaysGenitive;
            }
            else switch (days % 10)
            {
                case 0:
                    return Resources.Messages.DaysGenitive;
                case 1:
                    return Resources.Messages.DayAccusative;
                case 2:
                    return Resources.Messages.DayGenitive;
                case 3:
                    return Resources.Messages.DayGenitive;
                case 4:
                    return Resources.Messages.DayGenitive;
                default:
                    return Resources.Messages.DaysGenitive;
            }
        }
    }
}

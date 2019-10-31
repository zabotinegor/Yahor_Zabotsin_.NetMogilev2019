using CustomMath;
using InputLib;
using System;
using System.Globalization;
using static Task5_2.Resources.Messages;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTimeFormatInfo = DateTimeFormatInfo.CurrentInfo;

            Console.WriteLine(MessageEnterMonth);

            var stringBuffer = Console.ReadLine();

            if (InputData.IntData(stringBuffer, out var month))
            {
                Console.WriteLine(Calendars.GetDaysInMonth(dateTimeFormatInfo, month, out var monthName, out var daysInMonth)
                    ? $@"{monthName}, {daysInMonth} {MatchingDaysWithNumerals(daysInMonth)}"
                    : MessageWrongMonthNumber);
            }
            else
            {
                Console.WriteLine(Calendars.GetDaysInMonth(dateTimeFormatInfo, stringBuffer, out var daysInMonth)
                    ? $@"{stringBuffer.StartWithСap()}, {daysInMonth} {MatchingDaysWithNumerals(daysInMonth)}"
                    : MessageWrongMonthName);
            }

            Console.ReadKey();
        }

        private static string MatchingDaysWithNumerals(int days)
        {
            if ((2 <= days) && (days < 5))
            {
                return DayGenitive;
            }
            else if ((5 <= days) && (days < 20))
            {
                return DaysGenitive;
            }
            else switch (days % 10)
            {
                case 0:
                    return DaysGenitive;
                case 1:
                    return DayAccusative;
                case 2:
                    return DayGenitive;
                case 3:
                    return DayGenitive;
                case 4:
                    return DayGenitive;
                default:
                    return DaysGenitive;
            }
        }
    }
}

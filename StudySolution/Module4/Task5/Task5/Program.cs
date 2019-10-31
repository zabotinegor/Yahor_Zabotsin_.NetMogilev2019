using System;
using System.Globalization;
using CustomMath;
using InputLib;
using messages = Task5.Resources.Messages;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dtfi = DateTimeFormatInfo.CurrentInfo;

            Console.WriteLine(messages.MessageEnterMonth);

            var stringBuffer = Console.ReadLine();

            if (InputData.IntData(stringBuffer, out var month))
            {
                Console.WriteLine(Calendars.GetDaysInMonth(dtfi, month, out var monthName, out var daysInMonth)
                    ? $@"{monthName}, {daysInMonth} {messages.DaysGenitive}"
                    : messages.MessageWrongMonthNumber);
            }
            else
            {
                Console.WriteLine(Calendars.GetDaysInMonth(dtfi, stringBuffer, out var days)
                    ? $@"{stringBuffer.StartWithСap()}, {days} {messages.DaysGenitive}"
                    : messages.MessageWrongMonthName);
            }

            Console.ReadKey();
        }
    }
}

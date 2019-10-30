using System;
using System.Globalization;
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

            if (InputData.IntData(stringBuffer, out var month) && (month > 0) && (month <= 12))
            {
                Console.WriteLine($@"{dtfi?.MonthNames[month - 1]}, {DateTime.DaysInMonth(2019, month)} {messages.DaysGenitive}");
            }

            Console.ReadKey();
        }
    }
}

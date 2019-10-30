using System;
using System.Globalization;
using InputLib;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var dtfi = DateTimeFormatInfo.CurrentInfo;

            Console.WriteLine("Enter the name of the month or its serial number:");

            var stringBuffer = Console.ReadLine();

            if (InputData.IntData(stringBuffer, out var month) && (month >= 0) && (month < 12))
            {
                Console.WriteLine("{0}, {1} days", dtfi.MonthNames[month], DateTime.DaysInMonth(2019, month));
            }

            Console.ReadKey();
        }
    }
}

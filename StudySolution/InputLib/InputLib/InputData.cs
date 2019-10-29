using CustomMath;
using System;
using System.Globalization;

namespace InputLib
{
    public static class InputData
    {
        public static bool IntData(string inputString, out int data)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException(nameof(inputString));
            }

            data = default;

            return int.TryParse(Console.ReadLine(), out data);
        }

        public static bool DoubleData(string inputString, out double data)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException(nameof(inputString));
            }

            data = default;

            return (double.TryParse(inputString, NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out data));
        }

        public static bool NatData(string inputString, out int data)
        {
            if (inputString == null)
            {
                throw new ArgumentNullException(nameof(inputString));
            }

            data = default;

            return int.TryParse(inputString, out data) && data.IsNatural();
        }

        public static bool IntArray(string message, int size, out int[] array)
        {
            array = new int[size];
            var result = true;

            Console.WriteLine(message);

            for (var i = 0; i < array.Length; i++)
            {
                if (int.TryParse(Console.ReadLine(), out array[i]))
                {
                    continue;
                }

                result = false;
                array = default;
                break;
            }

            return result;
        }
    }
}

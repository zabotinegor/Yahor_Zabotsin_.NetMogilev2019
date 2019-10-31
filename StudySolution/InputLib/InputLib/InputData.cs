using CustomMath;
using System;
using System.Globalization;

namespace InputLib
{
    public static class InputData
    {
        public static bool IntData(string inputString, out int data)
        {
            CheckString(inputString);

            return int.TryParse(inputString, out data);
        }

        public static bool DoubleData(string inputString, out double data)
        {
            CheckString(inputString);

            return (double.TryParse(inputString, NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture, out data));
        }

        public static bool NatData(string inputString, out int data)
        {
            CheckString(inputString);

            return int.TryParse(inputString, out data) && data.IsNatural();
        }

        private static void CheckString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }
        }
    }
}

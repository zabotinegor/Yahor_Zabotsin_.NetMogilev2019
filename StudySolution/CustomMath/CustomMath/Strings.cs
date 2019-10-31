using System;

namespace CustomMath
{
    public static class Strings
    {
        public static string Sum(string str1, string str2)
        {
            return str1 + str2;
        }

        public static string StartWithСap(this string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str));
            }

            return str.Substring(0, 1).ToUpper() + str.Remove(0, 1).ToLower();
        }
    }
}

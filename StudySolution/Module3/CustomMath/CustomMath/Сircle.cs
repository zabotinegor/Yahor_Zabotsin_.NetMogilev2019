using System;

namespace CustomMath
{
    public static class Сircle
    {
        public static bool GetParams(double radius, out double perimeter, out double area)
        {
            perimeter = default;
            area = default;

            if (0 >= radius)
            {
                return false;
            }

            perimeter = 2 * Math.PI * radius;
            area = Math.PI * Math.Pow(radius, 2);

            return true;
        }
    }
}

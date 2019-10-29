using System;

namespace CustomMath
{
    public static class Сircle
    {
        public static bool GetParams(double radius, out double perimeter, out double area)
        {
            perimeter = default;
            area = default;

            if (radius.IsNegativeOrZero())
            {
                return false;
            }

            perimeter = Perimeter(radius);
            area = Area(radius);

            return true;
        }

        private static double Perimeter(double radius)
        {
            return 2 * Math.PI * radius;
        }

        private static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public static (double perimeter, double area) GetParams(double radius)
        {
            return radius.IsNegativeOrZero() ? (0, 0) : (Perimeter(radius), Area(radius));
        }

        public static bool GetParams(double radius, out (double perimeter, double area) tuple)
        {
            tuple = default;

            if (radius.IsNegativeOrZero())
            {
                return false;
            }

            tuple = (Perimeter(radius), Area(radius));

            return true;
        }
    }
}

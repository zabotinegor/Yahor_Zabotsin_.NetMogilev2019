using System;

namespace CustomMath
{
    public static class Roots
    {
        public delegate double FunctionDelegate(double x);
        
        public static double Root(double a, double b, double eps, FunctionDelegate f)
        {
            if (f(a) * f(b) > 0)
            {
                throw new Exception("Perhaps the roots on this segment do not exist");
            }

            if (Math.Abs(b - a) < eps)
            {
                return (a + b) / 2;
            }
            else
            {
                var c = (a + b) / 2;

                return (f(a) * f(c) <= 0) ? Root(a, c, eps, f) : Root(c, b, eps, f);
            }
        }
    }
}

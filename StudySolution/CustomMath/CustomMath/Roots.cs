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
            

            if (a > b)
            {
                var t = a;
                a = b;
                b = t;
            }
            
            while ((b - a) > eps)
            {
                var c = (a + b) / 2;

                if (f(c) == 0)
                {
                    return c;
                }

                if (f(a) * f(c) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }
            return (a + b) / 2;
        }
    }
}

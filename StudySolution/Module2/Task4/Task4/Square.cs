using System;

namespace Task4
{
    internal class Square : Figure
    {
        internal override double Perimeter => 4 * _demension;
        internal override double Area => Math.Pow(_demension, 2);

        internal Square(double parameter)
        {
            Parameter = parameter;
        }

        internal override double GetParameterByPerimeter(double perimeter)
        {
            return perimeter / 4;
        }

        internal override double GetParameterByArea(double area)
        {
            return Math.Sqrt(area);
        }
    }
}

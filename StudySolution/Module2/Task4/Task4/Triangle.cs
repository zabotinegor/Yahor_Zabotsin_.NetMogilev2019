using System;

namespace Task4
{
    internal class Triangle : Figure
    {
        internal override double Perimeter => 3 * _demension;
        internal override double Area => Math.Pow(_demension, 2) * Math.Sqrt(3) / 4;

        internal Triangle(double parameter)
        {
            Parameter = parameter;
        }

        internal override double GetParameterByPerimeter(double perimeter)
        {
            return perimeter / 3;
        }

        internal override double GetParameterByArea(double area)
        {
            return Math.Sqrt(area * 4 / Math.Sqrt(3));
        }
    }
}

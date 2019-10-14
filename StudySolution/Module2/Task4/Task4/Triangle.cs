using System;

namespace Task4
{
    class Triangle : Figure
    {
        private double _side;
        public double Parameter
        {
            get => _side;
            set => _side = (value > 0) ? value : default;
        }
        public override double Perimeter => 3 * _side;
        public override double Area => _side * _side * Math.Sqrt(3) / 4;

        public Triangle(double parameter)
        {
            Parameter = parameter;
        }
        public override double GetParameterByPerimeter(double perimeter)
        {
            return perimeter / 3;
        }

        public override double GetParameterByArea(double area)
        {
            return Math.Sqrt(area * 4 / Math.Sqrt(3));
        }
    }
}

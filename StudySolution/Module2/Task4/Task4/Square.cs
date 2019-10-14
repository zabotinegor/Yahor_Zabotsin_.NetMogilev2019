using System;

namespace Task4
{
    class Square : Figure
    {
        private double _side;
        public double Parameter
        {
            get => _side;
            set => _side = (value > 0) ? value : default;
        }

        public override double Perimeter => 4 * _side;
        public override double Area => _side * _side;

        public Square(double parameter)
        {
            Parameter = parameter;
        }
        public override double GetParameterByPerimeter(double perimeter)
        {
            return perimeter / 4;
        }

        public override double GetParameterByArea(double area)
        {
            return Math.Sqrt(area);
        }
    }
}

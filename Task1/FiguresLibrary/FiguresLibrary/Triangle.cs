using System;

namespace FiguresApp
{
    public class Triangle : IFigure
    {
        public double A { get; private set; }
        public double B { get; private set; }
        public double C { get; private set; }
       
        private bool? rectangular;
        public bool Rectangular 
        {
            get
            {
                rectangular ??= C * C == A * A + B * B;
                return (bool)rectangular;
            }
        }
        private double? square;
        public double Square
        {
            get
            {
                    square ??= Rectangular ? A * B / 2 : Math.Sqrt(P * (P-A)*(P-B)*(P-C));
                    return (double)square;
            }
        }

        private double? _p;
        private double P
        {
            get
            {
                _p ??= (A + B + C) / 2;
                return (double)_p;
            }
        }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 < 0 || side2 < 0 || side3 < 0)
                throw new ArgumentOutOfRangeException("Стороны не могут быть меньше или равны 0");

            double[] sides = new double[] { side1, side2, side3 };
            Array.Sort(sides);

            (A, B, C) = (sides[0], sides[1], sides[2]);

            if (A + B <= C || A + C <= B || B + C <= A)
                throw new ArgumentException("Не выполнено достаточное условие построения треугольника");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresApp
{
    public class Circle : IFigure
    {
        public double Radius { get; }
        private double? square;
        public double Square
        {
            get
            {
                if(square == null)
                {
                    square = Math.PI * Radius * Radius;
                }
                return (double)square;
            }
        }    

        public Circle(double radius)
        {
            if(radius < 0) 
                throw new ArgumentOutOfRangeException("Радиус не может быть меньше 0");

            Radius = radius;
        }
    }
}

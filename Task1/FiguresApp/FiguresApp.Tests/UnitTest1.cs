using System;
using Xunit;

namespace FiguresApp.Tests
{
    public class UnitTest1
    {
        #region Triangle
        [Fact]
        public void CreateTriangleWithSidesLT0()
        {
            IFigure Action() => new Triangle(-1, -7, 6);
            Assert.Throws<ArgumentOutOfRangeException>(Action);
        }

        [Fact]
        public void CheckTriangleSidesAssigment()
        {
            Triangle figure = new Triangle(5, 3, 4);
            Assert.Equal(3, figure.A);
            Assert.Equal(4, figure.B);
            Assert.Equal(5, figure.C);
        }

        [Fact]
        public void CreateBadTriangle()
        {
            IFigure Action() => new Triangle(3,10,1);
            Assert.Throws<ArgumentException>(Action);
        }

        [Fact]
        public void CreateTriangleAndCalculateSquare()
        {
            IFigure figure = new Triangle(3,4,5);
            Assert.Equal(6, figure.Square);
        }

        [Fact]
        public void CheckRectangular()
        {
            Triangle figure = new Triangle(3, 4, 5);
            Assert.True(figure.Rectangular);
            Triangle figure2 = new Triangle(6, 3, 6);
            Assert.False(figure2.Rectangular);
        }
        #endregion Triangle

        #region Circle
        [Fact]
        public void CreateCircleWithRadiusLT0()
        {
            IFigure Action() => new Circle(-1);
            Assert.Throws<ArgumentOutOfRangeException>(Action);
        }

        [Fact]
        public void CreateCircleAndCalculateSquare()
        {
            double r = 10;
            IFigure figure = new Circle(r);
            Assert.Equal(Math.PI*r*r, figure.Square);
        }

        #endregion Circle
    }
}

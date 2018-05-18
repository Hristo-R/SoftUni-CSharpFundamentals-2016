namespace Shapes
{
    using System;

    public class Circle : BasicShape
    {
        public Circle(double width) : base(width, 0)
        {
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Width * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * this.Width;
        }
    }
}
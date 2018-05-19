namespace Shapes
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            var shapes = new IShape[]
            {
                new Circle(10),
                new Rectangle(20, 30), 
                new Rhombus(10, 10, 9)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.GetType().Name);
                Console.WriteLine("Area: {0:F2}", shape.CalculateArea());
                Console.WriteLine("Perimeter: {0:F2}", shape.CalculatePerimeter());
                Console.WriteLine();
            }
        }
    }
}

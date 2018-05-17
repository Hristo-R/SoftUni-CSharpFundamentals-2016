namespace _02.DistanceCalculator
{
    using System;
    using Point3D;

    public class DistanceCalculatorMainProgram
    {
        public static void Main()
        {
            Console.WriteLine("Insert first point:");
            Console.Write("x1 = ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("z1 = ");
            double z1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInsert second point:");
            Console.Write("x2 = ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            double y2 = double.Parse(Console.ReadLine());
            Console.Write("z2 = ");
            double z2 = double.Parse(Console.ReadLine());

            var firstPoint = new Point3D(x1, y1, z1);
            var secondPoint = new Point3D(x2, y2, z2);

            double distance = DistanceCalculator.Calculator(firstPoint, secondPoint);

            Console.WriteLine("\nThe distance between this points is: {0:f2}", distance);
        }
    }
}

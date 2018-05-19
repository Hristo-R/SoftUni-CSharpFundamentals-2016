namespace _02.DistanceCalculator
{
    using System;
    using Point3D;

    public class DistanceCalculator
    {
        public static double Calculator(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt(
                ((secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X)) +
                ((secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y)) +
                ((secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z)));
        }
    }
}

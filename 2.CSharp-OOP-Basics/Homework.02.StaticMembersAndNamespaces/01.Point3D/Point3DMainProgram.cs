namespace Point3D
{
    using System;

    public class Point3DMainProgram
    {
        public static void Main()
        {
            var new3DPoint = new Point3D(1, 1, 1);
            var start3DPoint = Point3D.StartPoint;

            Console.WriteLine("3d point: {0}", new3DPoint);
            Console.WriteLine("Start 3D point: {0}", start3DPoint);
        }
    }
}

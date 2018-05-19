namespace _03.Paths
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Starter
    {
        public static void Main()
        {
            double[] point1 = new double[] { 1.0, 2.0, 3.0 };
            double[] point2 = new double[] { 4.0, 5.0, 6.0 };
            double[] point3 = new double[] { 7.0, 8.0, 9.0 };
            double[] point4 = new double[] { 10.0, 11.0, 12.0 };

            List<double[]> points = new List<double[]>();
            points.Add(point1);
            points.Add(point2);
            points.Add(point3);
            points.Add(point4);

            StringBuilder sb = new StringBuilder();

            foreach (var point in points)
            {
                sb.Append($"{{{string.Join(", ", point)}}} ");
            }

            string sequence = sb.ToString();

            Path3D path3D = new Path3D(sequence);

            Storage.SavePath(path3D);

            Storage.LoadPath();
        }
    }
}

namespace _03.CategorizeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class CategorizeNumbers
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');

            double[] d = new double[strArr.Length];

            List<double> roundNumbers = new List<double>();
            List<double> numbersNonZeroFraction = new List<double>();

            for (int i = 0; i < strArr.Length; i++)
            {
                d[i] = double.Parse(strArr[i], CultureInfo.InvariantCulture);
                if (d[i] % 1 == 0)
                {
                    roundNumbers.Add(d[i]);
                }
                else
                {
                    numbersNonZeroFraction.Add(d[i]);
                }
            }

            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",
                string.Join(", ", numbersNonZeroFraction),
                numbersNonZeroFraction.Min(),
                numbersNonZeroFraction.Max(),
                numbersNonZeroFraction.Sum(),
                numbersNonZeroFraction.Average());
            Console.WriteLine(
                "[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:f2}",
                string.Join(", ", roundNumbers),
                roundNumbers.Min(),
                roundNumbers.Max(),
                roundNumbers.Sum(),
                roundNumbers.Average());
        }
    }
}

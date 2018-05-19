namespace _04.Events
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Events
    {
        private static Dictionary<string, SortedDictionary<string, List<string>>> result =
        new Dictionary<string, SortedDictionary<string, List<string>>>();

        private static string[] locations;

        public static void Main()
        {
            ReadData();
            PrintResult();
            Console.ReadLine();
        }

        private static void PrintResult()
        {
            foreach (string validLocation in locations)
            {
                int count = 1;

                if (result.ContainsKey(validLocation))
                {
                    Console.WriteLine("{0}:", validLocation);
                    foreach (var location in result[validLocation])
                    {
                        Console.WriteLine("{0}. {1} -> {2}", count, location.Key, string.Join(", ", location.Value.OrderBy(x => x)));
                        count++;
                    }
                }
            }
        }

        private static void ReadData()
        {
            int rows = int.Parse(Console.ReadLine());
            string pattern = @"^\s*#([a-zA-Z]+):\s*@([a-zA-Z]+)\s*(([0-1]\d?|2[0-3]?):[0-5]\d?)$";

            for (int i = 0; i < rows; i++)
            {
                Match match = Regex.Match(Console.ReadLine(), pattern);

                string person = match.Groups[1].ToString();
                string location = match.Groups[2].ToString();
                string hour = match.Groups[3].ToString();

                if (!result.ContainsKey(location))
                {
                    result[location] = new SortedDictionary<string, List<string>>();
                }

                if (!result[location].ContainsKey(person))
                {
                    result[location][person] = new List<string>();
                }

                result[location][person].Add(hour);
            }

            locations = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToArray();
        }
    }
}

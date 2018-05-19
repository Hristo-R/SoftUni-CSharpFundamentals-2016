namespace _04.SequencesOfEqualStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SequencesOfEqualStrings
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            int arrLength = array.Length;
            Dictionary<string, int> result = new Dictionary<string, int>();

            for (int i = 0; i < arrLength; i++)
            {
                if (!result.ContainsKey(array[i]))
                {
                    result.Add(array[i], 1);
                }
                else
                {
                    result[array[i]] += 1;
                }
            }

            foreach (var pair in result)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Repeat(pair.Key, pair.Value)));
            }
        }
    }
}

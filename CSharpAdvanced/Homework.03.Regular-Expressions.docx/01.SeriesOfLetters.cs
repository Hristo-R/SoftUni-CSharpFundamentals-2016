namespace _01.SeriesOfLetters
{
    using System;
    using System.Text;

    public class SeriesOfLetters
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i == input.Length - 1)
                {
                    string last = result.ToString();

                    if (last[last.Length - 1] != input[i])
                    {
                        result.Append(input[i]);
                    }
                }
                else
                {
                    if (input[i] != input[i + 1])
                    {
                        result.Append(input[i]);
                    }
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}

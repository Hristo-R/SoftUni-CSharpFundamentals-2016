namespace _03.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"[a-z0-9_.-]+@[a-z0-9_.-]+";
            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(text, pattern);

            if (matches.Count < 2)
            { 
                Console.WriteLine("Found {0} match", matches.Count);
            }
            else
            {
                Console.WriteLine("Found {0} matches", matches.Count);
            }

            foreach (Match match in matches)
            {
                Console.WriteLine("e-mail: {0}", match.Groups[0]);
            }
        }
    }
}

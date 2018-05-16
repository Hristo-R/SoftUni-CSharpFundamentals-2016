namespace _04.SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            string keyword = Console.ReadLine();
            string text = Console.ReadLine();

            string pattern = @"[^.!?]+";

            Regex regex = new Regex(pattern);
            MatchCollection matches = Regex.Matches(text, pattern);

            bool isKeywordEquals = false;

            foreach (Match match in matches)
            {
                string sentence = match.Groups[0].Value;

                string[] words = sentence.Split(" ");

                foreach (var word in words)
                {
                    if (keyword.Equals(word))
                    {
                        isKeywordEquals = true;
                    }
                }

                if (isKeywordEquals)
                {
                    Console.WriteLine(sentence);
                }

                isKeywordEquals = false;
            }
        }
    }
}

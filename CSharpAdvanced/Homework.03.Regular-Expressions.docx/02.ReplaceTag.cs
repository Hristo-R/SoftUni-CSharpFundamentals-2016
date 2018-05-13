namespace _02.ReplaceTag
{
    using System;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            string pattern = @"<a href=""http:\//softuni.bg"">SoftUni</a>|<a href='http:\//softuni.bg'>SoftUni</a>";
            string replacement = "[URL href=http://softuni.bg]SoftUni[/URL]";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);
        }
    }
}

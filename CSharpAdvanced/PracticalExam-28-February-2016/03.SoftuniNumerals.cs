namespace _03.SoftuniNumerals
{
    using System;
    using System.Numerics;
    using System.Text;
    using System.Text.RegularExpressions;

    public class SoftuniNumerals
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string patern = @"(aa)|(aba)|(bcc)|(cc)|(cdc)";
            Regex regex = new Regex(patern);
            MatchCollection collection = regex.Matches(input);
            StringBuilder result = new StringBuilder();

            foreach (Match match in collection)
            {
                switch (match.ToString())
                {
                    case "aa":
                        result.Append("0");
                        break;
                    case "aba":
                        result.Append("1");
                        break;
                    case "bcc":
                        result.Append("2");
                        break;
                    case "cc":
                        result.Append("3");
                        break;
                    case "cdc":
                        result.Append("4");
                        break;
                }
            }
            
            BigInteger number = 0;
            for (int index = 0; index < result.Length; index++)
            {
                BigInteger nextDigit = result[result.Length - 1 - index] - '0';
                number += nextDigit * BigInteger.Pow(5, index);
            }

            Console.WriteLine(number);
        }
    }
}

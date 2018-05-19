using System;
using System.Collections.Generic;

public class Palindromes
{
    public static void Main()
    {
        string[] textStrings =
            Console.ReadLine().Split(new string[] { " ", ",", ".", "?", "!" }, StringSplitOptions.RemoveEmptyEntries);
        List<string> palindromes = new List<string>();

        for (int i = 0; i < textStrings.Length; i++)
        {
            if (IsPalindrome(textStrings[i]))
            {
                palindromes.Add(textStrings[i]);
            }
        }

        palindromes.Sort();
        Console.WriteLine(string.Join(", ", palindromes));
    }

    public static bool IsPalindrome(string word)
    {
        bool isPalindrome = false;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == word[word.Length - i - 1])
            {
                isPalindrome = true;
            }
            else
            {
                isPalindrome = false;
            }
        }

        return isPalindrome;
    }
}
using System;

public class UnicodeCharacters
{
    public static void Main()
    {
        string input = Console.ReadLine();

        foreach (char c in input)
        {
            Console.Write("\\u" + ((int)c).ToString("x4"));
        }

        Console.WriteLine();
    }
}
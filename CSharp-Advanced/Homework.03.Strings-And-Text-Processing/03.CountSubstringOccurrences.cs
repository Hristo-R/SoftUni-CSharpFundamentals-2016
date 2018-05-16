using System;

public class CountSubstringOccurrences
{
    public static void Main()
    {
        string inputString = Console.ReadLine().ToLower();
        string searchString = Console.ReadLine().ToLower();

        int count = 0;
        int index = inputString.IndexOf(searchString, 0);

        while (index != -1)
        {
            count++;
            index = inputString.IndexOf(searchString, index + 1);
        }

        Console.WriteLine(count);
    }
}
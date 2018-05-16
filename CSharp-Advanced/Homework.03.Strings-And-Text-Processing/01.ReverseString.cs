using System;
using System.Collections.Generic;
using System.Text;

public class ReverseString
{
    public static void Main()
    {
        string inputString = Console.ReadLine();
        StringBuilder reversedInput = new StringBuilder();

        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            reversedInput.Append(inputString[i]);
        }

        string reversedString = reversedInput.ToString();
        Console.WriteLine(reversedString);
    }
}
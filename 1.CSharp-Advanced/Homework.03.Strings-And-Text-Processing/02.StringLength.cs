using System;
using System.Text;

public class StringLength
{
    public static void Main()
    {
        string inputString = Console.ReadLine();
        StringBuilder newString = new StringBuilder();
        string stringOf20characters;

        if (inputString.Length >= 20)
        {
            stringOf20characters = inputString.Substring(0, 20);
        }
        else
        {
            for (int i = inputString.Length; i < 20; i++)
            {
                newString.Append('*');
            }

            stringOf20characters = inputString + newString.ToString();
        }

        Console.WriteLine(stringOf20characters);
    }
}
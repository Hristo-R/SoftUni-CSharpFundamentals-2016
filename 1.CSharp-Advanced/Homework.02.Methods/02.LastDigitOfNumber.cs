using System;

public class LastDigitOfNumber
{
    public static void Main()
    {
        string input = Console.ReadLine();
        char lastDigit = input[input.Length - 1];
        Console.WriteLine(ReturnsLastDigitAnWord(lastDigit));
    }

    public static string ReturnsLastDigitAnWord(char lastDigit)
    {
        string digitAsWord;
        switch (lastDigit)
        {
            case '0': digitAsWord = "zero";
                break;
            case '1': digitAsWord = "one";
                break;
            case '2': digitAsWord = "two";
                break;
            case '3': digitAsWord = "three";
                break;
            case '4': digitAsWord = "four";
                break;
            case '5': digitAsWord = "five";
                break;
            case '6': digitAsWord = "six";
                break;
            case '7': digitAsWord = "seven";
                break;
            case '8': digitAsWord = "eight";
                break;
            case '9': digitAsWord = "nine";
                break;
            default:
                digitAsWord = "Invalid integer";
                break;
        }

        return digitAsWord;
    }
}
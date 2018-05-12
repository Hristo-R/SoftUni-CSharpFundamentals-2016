using System;

public class BiggerNumber
{
    public static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }

    public static int GetMax(int firstNumber, int secondNumber)
    {
        int max;
        max = firstNumber;
        if (firstNumber < secondNumber)
        {
            max = secondNumber;
        }

        return max;
    }
}
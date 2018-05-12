﻿using System;

public class LargerThanNeighbours
{
    public static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }

    public static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        bool isLarger = false;
        if (i == 0)
        {
            if (numbers[i] > numbers[i + 1])
            {
                isLarger = true;
            }
        }
        else if (i > 0 && i < numbers.Length - 1)
        {
            if (numbers[i - 1] < numbers[i] && numbers[i + 1] < numbers[i])
            {
                isLarger = true;
            }
        }
        else if (numbers[i - 1] < numbers[i]) 
        {
            isLarger = true;
        }

        return isLarger;
    }
}
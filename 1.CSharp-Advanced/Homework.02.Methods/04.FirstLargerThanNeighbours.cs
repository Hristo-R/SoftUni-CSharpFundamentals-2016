using System;

public class FirstLargerThanNeighbours
{
    public static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    public static int IndexOfFirstElementLargerThanNeighbours(int[] sequence)
    {
        for (int i = 0; i < sequence.Length; i++)
        {
            if (IsLargerThanNeighbours(sequence, i))
            {
                return i;
            }
        }

        return -1;
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
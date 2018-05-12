using System;

public class FillTheMatrix
{
    public static void Main()
    {
        Console.Write("Matrix size N x N.\nInput N = ");
        int matrixSize = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[,] matrixPatternA = new int[matrixSize, matrixSize];
        int[,] matrixPatternB = new int[matrixSize, matrixSize];

        FillMatrixPaternA(matrixSize, matrixPatternA);
        FillMatrixPaternB(matrixSize, matrixPatternB);

        PrintMatrix(matrixSize, matrixPatternA);
        PrintMatrix(matrixSize, matrixPatternB);
    }

    private static void FillMatrixPaternA(int matrixSize, int[,] matrixPatternA)
    {
        int valueOfFilling = 1;
        for (int col = 0; col < matrixSize; col++)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                matrixPatternA[row, col] = valueOfFilling;
                valueOfFilling += 1;
            }
        }
    }

    private static void FillMatrixPaternB(int matrixSize, int[,] matrixPatternB)
    {
        int valueOfFilling = 1;
        int newRow;
        for (int col = 0; col < matrixSize; col++)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                if (col % 2 == 0)
                {
                    matrixPatternB[row, col] = valueOfFilling;
                }
                else
                {
                    newRow = matrixSize - row - 1;
                    matrixPatternB[newRow, col] = valueOfFilling;
                }

                valueOfFilling += 1;
            }
        }
    }

    private static void PrintMatrix(int matrixSize, int[,] matrixPatternA)
    {
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write("{0} ", matrixPatternA[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

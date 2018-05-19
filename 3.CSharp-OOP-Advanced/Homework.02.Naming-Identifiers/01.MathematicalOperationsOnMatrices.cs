namespace Matrices
{
    using System;

    public class MathematicalOperationsOnMatrices
    {
        public static void Main()
        {
            var firstMatrix = new double[,] { { 1, 3 }, { 5, 7 } };
            var secondMatrix = new double[,] { { 4, 2 }, { 1, 5 } };
            var resultMatrix = MatrixMultiplication(firstMatrix, secondMatrix);

            for (var i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (var j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    Console.Write(resultMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        private static double[,] MatrixMultiplication(double[,] firstMatrix, double[,] secondMatrix)
        {
            if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new ArgumentException("The given matrices cannot be multiplied");
            }

            var numberOfRowsInFirstMatrix = firstMatrix.GetLength(0);
            var numberOfColumnsInFirstMatrix = firstMatrix.GetLength(1);
            var numberOfColumnsInSecondMatrix = secondMatrix.GetLength(1);

            var resultMatrix = new double[numberOfRowsInFirstMatrix, numberOfColumnsInSecondMatrix];
            for (var row = 0; row < resultMatrix.GetLength(0); row++)
            {
                for (var column = 0; column < resultMatrix.GetLength(1); column++)
                {
                    for (var i = 0; i < numberOfColumnsInFirstMatrix; i++)
                    {
                        resultMatrix[row, column] += firstMatrix[row, i] * secondMatrix[i, column];
                    }
                }
            }

            return resultMatrix;
        }
    }
}
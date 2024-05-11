using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            { 1, 2, -1, -4, -20 },
            { -8, -3, 4, 2, 1 },
            { 3, 8, 10, 1, 3 },
            { -4, -1, 1, 7, -6 }
        };

        int[,] maxSubmatrix = FindMaximumSumSubmatrix(matrix);
        PrintMatrix(maxSubmatrix);
    }

    static int[,] FindMaximumSumSubmatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int maxSum = int.MinValue;
        int top = 0, bottom = 0, left = 0, right = 0;

        for (int t = 0; t < rows; t++)
        {
            int[] temp = new int[cols];

            for (int b = t; b < rows; b++)
            {
                for (int i = 0; i < cols; i++)
                {
                    temp[i] += matrix[b, i];
                }

                var (sum, start, end) = KadaneAlgorithm(temp);

                if (sum > maxSum)
                {
                    maxSum = sum;
                    top = t;
                    bottom = b;
                    left = start;
                    right = end;
                }
            }
        }

        return ConstructSubmatrix(matrix, top, bottom, left, right);
    }

    static (int, int, int) KadaneAlgorithm(int[] array)
    {
        int maxEndingHere = array[0];
        int maxSoFar = array[0];
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (maxEndingHere + array[i] < array[i])
            {
                maxEndingHere = array[i];
                startIndex = i;
            }
            else
            {
                maxEndingHere += array[i];
            }

            if (maxEndingHere > maxSoFar)
            {
                maxSoFar = maxEndingHere;
                endIndex = i;
            }
        }

        return (maxSoFar, startIndex, endIndex);
    }

    static int[,] ConstructSubmatrix(int[,] matrix, int top, int bottom, int left, int right)
    {
        int submatrixRows = bottom - top + 1;
        int submatrixCols = right - left + 1;
        int[,] submatrix = new int[submatrixRows, submatrixCols];

        for (int i = top; i <= bottom; i++)
        {
            for (int j = left; j <= right; j++)
            {
                submatrix[i - top, j - left] = matrix[i, j];
            }
        }

        return submatrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        Console.WriteLine("Submatriz de mayor suma:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
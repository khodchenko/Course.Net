using System;
using Lesson5Task;

namespace Course.Net
{
    public class CourseConsole
    {
        static void Main()
        {
            int[,] array = GenerateMatrix(2,2);
            Lesson5Task.Lesson5Task.FlipArray(array);    





        }

        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        private static int[] GenerateArray()
        {
            int Min = 0;
            int Max = 20;

            int[] array = new int[7];

            Random randNum = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randNum.Next(Min, Max);
                Console.Write($"[{array[i]}] ");
            }

            return array;
        }

        private static int[,] GenerateMatrix(int x, int y)
        {
            Random random = new Random();
            int[,] matrix = new int[x, y];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, x * y);
                }
            }

            return matrix;
        }

        private static void PowerMatrix(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= matrix[i, j];
                }
            }
        }

        private static int SumByOddIndexes(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            int sum = 0;
            for (int i = 1; i < matrix.GetLength(0); i += 2)
            {
                for (int j = 1; j < matrix.GetLength(1); j += 2)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static void Reverse(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            for (int i = 0, count = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) && count < matrix.Length / 2; j++, count++)
                {
                    Swap(ref matrix[i, j], ref matrix[matrix.GetLength(0) - 1 - i, matrix.GetLength(1) - 1 - j]);
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static int Sum(int[,] matrix)
        {
            if (matrix == null)
            {
                throw new ArgumentException();
            }

            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }

            return sum;
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
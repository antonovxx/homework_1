using System;
/*
 * В двумерном массиве порядка M на N поменяйте заданные столбцы местами
 */

namespace task_6
{
    static class Program
    {
        public static void Main(string[] args)
        {
            const int rows = 3;
            const int cols = 3;
            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix, rows, cols);

            Console.WriteLine("Matrix: " + Environment.NewLine);
            PrintMatrix(matrix, rows, cols);

            Console.WriteLine("\nMatrix after changing: " + Environment.NewLine);

            PrintMatrix(Func(matrix), rows, cols);  

        }

        static int[,] Func(int[,] Arr) 
        {

            int[,] arr = new int[Arr.GetLength(0), Arr.GetLength(1)];

            int k;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = Arr[i, j];
                }
            }
            for (int i = 0; i < Arr.GetLength(0); i++)
            {
                k = arr[i, 0]; // индекс 1 столбца
                arr[i, 0] = arr[i, 1]; // индекс 2 столбца
                arr[i, 1] = k;
            }
            return arr;
        }

        static void FillMatrix(int [,] matrix, int rows, int cols)
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }
        }
        static void PrintMatrix(int [,] matrix, int rows, int cols)
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}

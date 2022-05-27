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
            const int rows = 2;
            const int cols = 3;
            int[,] matrix = new int[rows, cols];

            FillMatrix(matrix, rows, cols);

            PrintMatrix(matrix, rows, cols);

            Console.WriteLine("Enter numbers of cols that places you want to change: ");
            int col1 = int.Parse(Console.ReadLine());
            int col2 = int.Parse(Console.ReadLine());

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {

                }
            }
            

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

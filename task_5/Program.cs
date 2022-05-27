using System;
/*
 * Написать программу, которая предлагает пользователю ввести число и считает, сколько раз это число встречается в массиве.
 */
namespace task_5
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            int [] array = new int [10];
            int count = 0;

            FillArr(array);
            PrintArr(array);

            Console.WriteLine("Enter some number for checking number of entarance: ");
            int number = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    ++count;
                }
            }
            Console.WriteLine($"Number {number} meets {count} times in this array");

        }
        static void FillArr(int[] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-10, 10);
            }
        }
        static void PrintArr(int[] arr)
        {
            foreach(int i in arr)
                Console.WriteLine(i);
        }
    }
}
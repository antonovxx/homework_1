using System;
/*
 * 1. Сжать массив, удалив из него все 0 и, заполнить освободившееся справа элементы значениями -1
 * 2. Преобразовать массив так, чтобы сначала шли все отрицательные элементы, а потом положительные
 * 
 */
namespace task_4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int [] arr = new int[20];
            int count = 0;

            FillArr(arr);
            PrintArr(arr);

            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    ++count;
                } else
                {
                    arr[i - count] = arr[i];
                }
            }

            Array.Resize(ref arr, arr.Length - count);

            Console.WriteLine("New array: ");
            PrintArr(arr);

            Array.Sort(arr); // Task_2

            PrintArr(arr);

        }
        static void FillArr(int[] arr)
        {
            Random random = new Random();
            for(int i = 0; i < arr.Length; ++i)
            {
                arr[i] = random.Next(-5, 5);
            }
        }
        static void PrintArr(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item);
            }
            Console.Write(Environment.NewLine);
        }
    }

}
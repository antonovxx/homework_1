/*
 * Даны целые положительные числа A, B, C. Значение этих чисел программа должна запрашивать у пользователя. 
 * На прямоугольнике размера A*B размещено максимально возможное количество квадратов со стороной C. Квадраты не накладываются друг на друга. 
 * Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника. 
 * Необходимо предусмотреть служебные сообщения в случае, если в прямоугольнике нельзя разместить ни одного квадрата со стороной С 
 * (например, если значение С превышает размер сторон прямоугольника).
*/


using System;

namespace task_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter some unsigned numbers A, B, C: ");
            double A = 0, B = 0, C = 0;
            double firstArea, secondArea;
            int countA = 0;
            int countB = 0;
            int countC = 0;

            bool flag = true;

            while (flag)
            {
                A = Convert.ToDouble(Console.ReadLine());
                B = Convert.ToDouble(Console.ReadLine());
                C = Convert.ToDouble(Console.ReadLine());

                if (C > A || C > B)
                {
                    Console.WriteLine("Side C couldn't be more than A or B");
                }
                else
                {
                    flag = false;
                }
            }

            firstArea = A * B;
            secondArea = C * C;

            while(firstArea >= secondArea)
            {
                firstArea -= secondArea;
            }

            while(A >= C)
            {
                A -= C;
                ++ countA;
            }
            while(B >= C)
            {
                B -= C;
                ++countB;
            }
            for(int i = 0; i < countA; i++)
            {
                countC += countB;
            }

            Console.WriteLine($"Remaining free space: {firstArea}");
            Console.WriteLine($"Number of squares in the rectangle: {countC}");
        }
    }
}
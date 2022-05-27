using System;
/*
 * Начальный вклад в банке равен 10000 руб. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы
 * (P — вещественное число, 0 < P < 25).
 * Значение Р программа должна получать у пользователя. 
 * По данному P определить через сколько месяцев размер вклада превысит 11000 руб., 
 * и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).
 */
namespace task_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            double initialDeposit = 10000;
            double percent;
            int months = 0;

            Console.WriteLine("Enter percents of your deposit: ");
            while (true)
            {
                percent = double.Parse(Console.ReadLine());
                if (percent > 0 && percent < 25)
                {
                    break;
                } 
                else
                {
                    Console.WriteLine("Inccorrect value. Try again.");
                }
            } 

            for(int i = 0; initialDeposit <= 11000; ++i)
            {
                initialDeposit += (initialDeposit / 100) * percent;
                months++;
            }

            Console.WriteLine($"Final deposit amount: {initialDeposit}");
            Console.WriteLine($"Months nedded: {months}");

        }
    }
}
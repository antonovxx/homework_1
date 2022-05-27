using System;

// Описать структуру RequestItem содержащую поля: товар; количество единиц товара.

namespace task_9
{
    struct RequestItem
    {
        public string name { get; set; }
        public int count { get; set; }

        public void Print()
        {
            Console.WriteLine($"Product name: {name}" +
                $"\nCount: {count}")
        }

    }
    class Program
    {
        static void Main()
        {
            RequestItem ri = new RequestItem();
            ri.name = "Box";
            ri.count = 15;
            ri.Print();
        }
    }
}
using System;
// Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; количество заказов осуществленных клиентом;
// общая сумма заказов клиента.

namespace task_8
{
    struct Client
    {
        public string firstName;
        public string lastName;
        public string address;
        public int number;
        public int sumOrders;
        public int totalOrders;

        public void Print()
        {
            Console.WriteLine($"First name: {firstName}" +
                $"Last name: {lastName}" +
                $"\nAdress: {address}" +
                $"\nPhone number: {number}" +
                $"\nSum of orders: {sumOrders}" +
                $"\nTotal orders: {totalOrders}");
        }

    }
    class Program
    {
        static void Main()
        {
            Client client;
            client.firstName = "John";
            client.lastName = "Doe";
            client.address = "Wall Street";
            client.number = 42313131;
            client.sumOrders = 2;
            client.totalOrders = 2 + client.sumOrders;

            client.Print();
        }
    }
}
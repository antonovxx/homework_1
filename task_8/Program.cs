using System;
// Описать структуру Client содержащую поля: код клиента; ФИО; адрес; телефон; количество заказов осуществленных клиентом;
// общая сумма заказов клиента.
//Описать перечисление ClientType определяющее важность клиента, и добавить соответствующее поле в структуру Client.


namespace task_8
{
    struct Client
    {
        private string firstName;
        private string lastName;
        public string adress;
        public string phone;
        public uint countOrders;
        public uint totalOrders;
        public ClientType type;

        public enum ClientType
        {
            common, VIP
        }
        public Client(string firstName, string lastName, string adress, string phone, uint countOrders, uint totalOrders)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adress = adress;
            this.phone = phone;
            this.countOrders = countOrders;
            this.totalOrders = totalOrders;
            
            if (countOrders > 0 && countOrders < 10)
            {
                this.type = ClientType.common;
            }
            else
            {
                this.type = ClientType.VIP;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}", 
                firstName, lastName, adress, phone, countOrders, totalOrders, type);

        }

    }
    class Program
    {
        static void Main()
        {
            Client client = new Client("Petya", "Pupkin", "Wall Street", "(842) 42 - 55 - 11", 10, 32);
            Console.WriteLine(client.ToString());
        }
    }
}
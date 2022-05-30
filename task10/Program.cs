using System;

//Описать структуру Request содержащую поля: код заказа; клиент; дата заказа; перечень заказанных товаров;
//сумма заказа(реализовать вычисляемым свойством).

namespace task10
{
    struct Request
    {
        private string id;
        private string name;
        private DateTime time;
        private ListOfGoods goods;
        private PayType payType;
        public enum PayType
        {
            cash, 
            card, 
            credit
        }

        public enum ListOfGoods
        {
            milk,
            fizzyDrink,
            meat,
            sweet,
            water
        }
        public int sum (ListOfGoods goods)
        {
            int sum = 0;

            switch(goods)
            {
                case ListOfGoods.milk:
                    sum += 50;
                    break;
                case ListOfGoods.fizzyDrink:
                    sum += 100;
                    break;
                case ListOfGoods.meat:
                    sum += 350;
                    break;
                case ListOfGoods.water:
                    sum += 30;
                    break;
                case ListOfGoods.sweet:
                    sum += 400;
                    break;
            }
            return sum;
        }

        public int price
        {
            get => this.sum(this.goods);
            set => this.sum(this.goods);
        }

        public Request(string id, string name, ListOfGoods goods, PayType payType)
        {
            this.id = id;
            this.name = name;
            this.time = DateTime.Now;
            this.goods = goods;
            this.payType = payType;
            this.price = price;
        }

        public override string ToString()
        {
            return String.Format("{0} \t {1} \t {2} \t {3} \t {4}", id, name, goods, payType, price);
        }
    }
    class Program
    {
        public static void Main()
        {
            Request item = new Request("ID_1", "Вася Пупкин", Request.ListOfGoods.milk, Request.PayType.cash);
            Console.WriteLine(item.ToString());
        }
    }
}
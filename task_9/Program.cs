using System;

// Описать структуру RequestItem содержащую поля: товар; количество единиц товара.

namespace task_9
{
    struct RequestItem
    {
        private string goodsName;
        private uint sumOfGoods;

        public RequestItem(string goodsName, uint simOfGoods)
        {
            this.goodsName = goodsName;
            this.sumOfGoods = simOfGoods;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ", goodsName, sumOfGoods);
        }
    }
    class Program
    {
        static void Main()
        {
            RequestItem requestItem = new RequestItem("Milk", 12);
            RequestItem requestItem2 = new RequestItem("Juice", 15);
            Console.WriteLine(requestItem.ToString());
            Console.WriteLine(requestItem2.ToString());
        }
    }
}
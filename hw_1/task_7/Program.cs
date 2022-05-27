using System;



namespace task_7
{
    // Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара.
    struct Article
    {
        public int id;
        public string title;
        public int price;

        public void description()
        {
            Console.WriteLine($"Id: {id}\nTitle: {title}\nPrice: {price}");
        }
    }
    class Program
    {
        static void Main()
        {
            Article art = new Article();

            art.id = 1;
            art.title = "Article";
            art.price = 12312;

            art.description();
        }
    }
}
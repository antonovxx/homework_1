using System;

namespace task_7
{
    // Описать структуру Article, содержащую следующие поля: код товара; название товара; цену товара.
    //Описать перечисление ArticleType определяющее типы товаров, и добавить соответствующее поле в структуру Article.
    struct Article
    {
        private string id;
        private string title;
        public double price;
        private ArticleType type;

        public enum ArticleType
        {
            water, drink, liqors, juices
        }
        public Article(string id, string title, double price, ArticleType type)
        {
            this.id = id;
            this.title = title;
            this.price = price;
            this.type = type;
        }

        public override string ToString()
        {
            return String.Format("{0} \t {1} \t {2} \t {3}", id, title, price, type);
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("ARCTICLE:" + Environment.NewLine);

            Article bonAqua = new Article("ID11", "Bon Aqua", 39.7, Article.ArticleType.water);
            Article cocaCola = new Article("ID12", "Coca Cola", 76.1, Article.ArticleType.drink);


            Console.WriteLine(bonAqua.ToString());
            Console.WriteLine(cocaCola.ToString());
        }
    }
}
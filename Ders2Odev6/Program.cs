using System;

namespace Ders2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products =
            {
                new Product{Id=1,name="Çorap",price=3,stock=100,property="Beyaz, Mavi, Siyah renklerde" },
                new Product
                {Id=2,name="T-Shirt",price=15,stock=75,property="Mor" },
                new Product{Id=3,name="Eşofman",price=50,stock=50,property="Gri" }
            };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Id);
            }

            foreach (Product product in products)
            {
                Console.WriteLine(product.name);
            }

            int a = 0;
            while (a<products.Length)
            {
                Console.WriteLine(products[a].property);
                a++;
            }
        }
    }

    class Product
    {
        public int Id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public string property { get; set; }
    }
}

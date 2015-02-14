using System;
using System.Drawing;
using System.Linq;

namespace LinqExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var products = new[]
            {
                new Product("Product #1", Color.Red, 100),
                new Product("Product #2", Color.Blue, 10),
                new Product("Product #3", Color.Green, 50),
                new Product("Product #4", Color.Black, 55),
                new Product("Product #5", Color.White, 75),
            };

            var productQuery =
                from product in products
                where product.Price > 50
                select new {product.Color, product.Price};

            foreach (var v in productQuery)
            {
                Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
            }

            Console.WriteLine("-------");

            foreach (var v in products
                    .Where(product => product.Price > 50)
                    .Select(product => new {product.Color, product.Price}))
            {
                Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
            }
        }
    }
}

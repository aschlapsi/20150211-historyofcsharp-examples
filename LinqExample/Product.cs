using System.Drawing;

namespace LinqExample
{
    public class Product
    {
        public string Name { get; private set; }
        public Color Color { get; private set; }
        public int Price { get; private set; }

        public Product(string name, Color color, int price)
        {
            Name = name;
            Color = color;
            Price = price;
        }
    }
}
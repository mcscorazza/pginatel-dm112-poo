namespace Ecommerce.Models
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public string Category { get; }

        public Product(string name, double price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}

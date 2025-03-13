namespace Ecommerce.Models
{
    public class OrderItem
    {
        public Product Product { get; }
        public int Quantity { get; }

        public OrderItem(Product product, int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("A quantidade deve ser maior que zero.");

            Product = product;
            Quantity = quantity;
        }

        public double CalculateSubtotal()
        {
            return Product.Price * Quantity;
        }
    }
}

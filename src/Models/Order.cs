namespace Ecommerce.Models
{
    public class Order
    {
        private List<OrderItem> _items;

        public Order()
        {
            _items = new List<OrderItem>();
        }

        public void AddItem(Product product, int quantity)
        {
            var itemExist = _items.FirstOrDefault(i => i.Product == product);

            if (itemExist != null)
            {
                _items.Remove(itemExist);
                _items.Add(new OrderItem(product, itemExist.Quantity + quantity));
            }
            else
            {
                _items.Add(new OrderItem(product, quantity));
            }
        }

        public int ItemsCount() {
            return _items.Count();
        }

        public double CalculateTotalOrder()
        {
            return _items.Sum(item => item.CalculateSubtotal());
        }

        public void ShowOrder()
        {
            if (_items.Count > 0) {
                Console.WriteLine("\n                                 | Resumo do Pedido: |");
                Console.WriteLine("     +====================================================+=======+=================+");
                Console.WriteLine("     | Nome                                               | Qtde. |        Total R$ |");
                Console.WriteLine("     +====================================================+=======+=================+");
                foreach (var item in _items)
                {
                    Console.WriteLine("     | {0,-50} | {1,5} | {2,15:C} |",item.Product.Name, item.Quantity, item.CalculateSubtotal());
                }
                Console.WriteLine("     +====================================================+=======+=================+");
                Console.WriteLine("                                                   Total do Pedido: {0,15:C}", CalculateTotalOrder());
                Console.WriteLine("     --------------------------------------------------------------------------------\n");
            } else {
                Console.WriteLine("     --------------------------------------------------------------------------------");
                Console.WriteLine("     !!! Pedido sem Itens Cadastrados!");
                Console.WriteLine("     --------------------------------------------------------------------------------\n");
            }
        }
        public void ClearOrder() {
            _items.Clear();
        }
    }
}

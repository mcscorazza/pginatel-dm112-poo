using Ecommerce.Models;
using Ecommerce.Repositories;

namespace Ecommerce.Services
{
    public class ProductService
    {
        private List<Product> Products { get; }

        public ProductService()
        {
            Products = ProductFactory.CreateProductList().ToList();
        }
        public List<Product> GetProducts()
        {
            return Products;
        }

        public void ShowProducts()
        {
            Console.WriteLine("\n                             | Lista de Produtos disponíveis: | ");
            Console.WriteLine("     +=====================================+=================+======================+");
            Console.WriteLine("     | Nome                                |        Valor R$ | Categoria            |");
            Console.WriteLine("     +=====================================+=================+======================+");
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine("[{0,2}] | {1,-35} | {2,15:C} | {3,-20} |", i + 1, Products[i].Name, Products[i].Price, Products[i].Category);
            }
            Console.WriteLine("     +=====================================+=================+======================+\n");
        }

    }
}

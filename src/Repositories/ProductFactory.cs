using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public static class ProductFactory
    {
        public static List<Product> CreateProductList()
        {
            return new List<Product>
            {
                new Product("Mouse Gamer", 150.0, "Periféricos"),
                new Product("Teclado Mecânico", 300.0, "Periféricos"),
                new Product("Monitor 24'", 900.0, "Monitores"),
                new Product("Cadeira Gamer", 1200.0, "Móveis"),
                new Product("Notebook Dell", 4500.0, "Computadores"),
                new Product("Impressora Multifuncional", 800.0, "Impressoras"),
                new Product("HD Externo 1TB", 350.0, "Armazenamento"),
                new Product("Placa de Vídeo RTX 3060", 2500.0, "Hardware"),
                new Product("Processador Ryzen 7", 1800.0, "Hardware"),
                new Product("Smartphone Samsung Galaxy S23", 4000.0, "Celulares"),
                new Product("Fone de Ouvido Bluetooth", 200.0, "Áudio"),
                new Product("Smartwatch Apple Watch", 3500.0, "Acessórios"),
                new Product("Câmera Web Full HD", 250.0, "Acessórios"),
                new Product("Microfone Condensador", 500.0, "Áudio"),
                new Product("Mesa Digitalizadora Wacom", 1000.0, "Desenho e Design"),
                new Product("Fonte 750W 80 Plus Gold", 600.0, "Hardware"),
                new Product("Gabinete Gamer RGB", 400.0, "Hardware"),
                new Product("Roteador Wi-Fi 6", 350.0, "Redes"),
                new Product("SSD NVMe 1TB", 700.0, "Armazenamento"),
                new Product("Carregador Turbo USB-C", 120.0, "Acessórios")
            };
        }
    }
}
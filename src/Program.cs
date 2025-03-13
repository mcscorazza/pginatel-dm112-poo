using System;
using Ecommerce.Models;
using Ecommerce.Services;
using Ecommerce.Repositories;
using Ecommerce.Interfaces;

namespace Ecommerce
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService products = new ProductService();
            List<Product> productList = products.GetProducts();
            Order order = new Order();
            PaymentService payment = new PaymentService();

            Console.WriteLine("\n\n     --------------------------------------------------------------------------------");
            Console.WriteLine("                            S I S T E M A   E C O M M E R C E");
            Console.WriteLine("     --------------------------------------------------------------------------------\n");

            Console.WriteLine("     >> Carregando lista de produtos...");
            products.ShowProducts();


            while (true)
            {
                Console.Write("     Entre com uma Opção:\n\n");
                Console.WriteLine("      -[L] Listar Produtos Cadastrados");
                Console.WriteLine("      -[N] Criar Novo Pedido");
                Console.WriteLine("      -[F] Faturar Pedido");
                Console.WriteLine("      -[S] Sair do Sistema\n\n");
                Console.Write("     >> ");
                string inputChoice = Console.ReadLine() ?? " ";

                switch (inputChoice.ToUpper())
                {
                    case "L":
                        products.ShowProducts();
                        break;

                    case "P":
                        break;

                    case "N":
                        Console.WriteLine("\n\n     Novo Pedido:");
                        Console.WriteLine("     ---------------------------------------------------------------------");
                        while (true)
                        {
                            Console.Write("     > Digite ID do Produto para inserir (ou '0' para finalizar): ");
                            string inputProduct = Console.ReadLine() ?? "0";
                            int ProductId = 0;

                            if (!int.TryParse(inputProduct, out ProductId))
                            {
                                Console.WriteLine("     !!! Opção Iválida! Digite um número inteiro!");
                            }
                            else
                            {
                                if (ProductId == 0)
                                {
                                    order.ShowOrder();
                                    break;
                                }
                                else
                                {
                                    if (productList.Count() >= ProductId)
                                    {
                                        Console.Write("     > Quantidade para o Produto [ {0} ]: ", productList[ProductId - 1].Name);
                                        int inputQty = int.Parse(Console.ReadLine() ?? "1");
                                        order.AddItem(productList[ProductId - 1], inputQty);
                                        Console.WriteLine("      >>> Produto [ {0} ] inserido - {1} unidades", productList[ProductId - 1].Name, inputQty);
                                        Console.WriteLine("     ---------------------------------------------------------------------\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine("     ---------------------------------------------------------------------");
                                        Console.WriteLine("\n     !!! Digite um número entre 1 e {0}", productList.Count());
                                        Console.WriteLine("     ---------------------------------------------------------------------\n");
                                    }
                                }
                            }

                        }
                        break;


                    case "F":
                        if (order.ItemsCount() > 0)
                        {

                            order.ShowOrder();
                            Console.WriteLine("      >>> Valor total para faturar: {0,10:C}\n", order.CalculateTotalOrder());
                            while (true)
                            {

                                Console.WriteLine("     Escolha a Forma de Pagamento: ");
                                Console.WriteLine("      - [C] Cartão de Crédito");
                                Console.WriteLine("      - [P] PIX\n");
                                Console.Write("     >> ");

                                string inputPayment = Console.ReadLine() ?? "";

                                if (inputPayment.ToUpper() == "C" || inputPayment.ToUpper() == "P")
                                {
                                    string method = "";
                                    if (inputPayment.ToUpper() == "C") { method = "cartao"; }
                                    if (inputPayment.ToUpper() == "P") { method = "pix"; }
                                    Console.WriteLine($"     Pagamento escolhido: {method.ToUpper()}\n");
                                    Console.WriteLine("     ---------------------------------------------------------------------");
                                    payment.InvoiceOrder(order, method);
                                    order.ClearOrder();
                                    Console.WriteLine("     ---------------------------------------------------------------------\n\n");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("        !!! Opção Inválida");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("      ---------------------------------------------------------------------");
                            Console.WriteLine("      !!! Pedido não contem itens adicionados!");
                            Console.WriteLine("      ---------------------------------------------------------------------\n");
                        }
                        break;

                    case "S":
                        Console.WriteLine("        [x] Saindo do sistema...");
                        Console.WriteLine("     ---------------------------------------------------------------------\n");
                        break;

                    default:
                        Console.WriteLine("       !!! Opção Inválida!\n");
                        break;
                }

                if (inputChoice == "S" || inputChoice == "s")
                {
                    break;
                }
            }

        }
    }
}
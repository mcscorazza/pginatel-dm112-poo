using Ecommerce.Interfaces;

namespace Ecommerce.Services
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void PaymentProcess(double paymentValue)
        {
            Console.WriteLine($"     >>> Pagamento de {paymentValue:C} realizado com Cartão de Crédito.");
        }
    }
}

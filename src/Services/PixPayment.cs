using Ecommerce.Interfaces;

namespace Ecommerce.Services
{
    public class PixPayment : IPaymentMethod
    {
        public void PaymentProcess(double paymentValue)
        {
            Console.WriteLine($"     >>> Pagamento de {paymentValue:C} realizado com PIX.");
        }
    }
}

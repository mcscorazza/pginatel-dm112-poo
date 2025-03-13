using Ecommerce.Interfaces;

namespace Ecommerce.Services
{
    public class PaypalPayment : IPaymentMethod
    {
        public void PaymentProcess(double paymentValue)
        {
            Console.WriteLine($"     >>> Pagamento de {paymentValue:C} realizado via Paypal.");
        }
    }
}

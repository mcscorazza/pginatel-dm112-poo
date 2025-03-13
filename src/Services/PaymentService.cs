using Ecommerce.Models;
using Ecommerce.Interfaces;

namespace Ecommerce.Services
{
    public class PaymentService
    {
        private Dictionary<string, IPaymentMethod> _paymentMethod = new Dictionary<string, IPaymentMethod>();

        public PaymentService()
        {
            _paymentMethod["cartao"] = new CreditCardPayment();
            _paymentMethod["pix"] = new PixPayment();
            _paymentMethod["paypal"] = new PaypalPayment();
        }

        public void InvoiceOrder(Order order, string method)
        {
            if (!_paymentMethod.ContainsKey(method))
            {
                throw new Exception("     !!! Método de pagamento inválido!");
            }
            IPaymentMethod payment = _paymentMethod[method];
            payment.PaymentProcess(order.CalculateTotalOrder());
        }
    }
}

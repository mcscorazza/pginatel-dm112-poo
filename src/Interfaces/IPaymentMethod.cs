namespace Ecommerce.Interfaces
{
    public interface IPaymentMethod
    {
        void PaymentProcess(double paymentValue);
    }
}

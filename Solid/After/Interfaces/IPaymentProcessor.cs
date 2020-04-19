using Solid.Common.Model;

namespace Solid.After.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCredCard(PaymentDetails paymentDetails, decimal totalAmount);
    }
}

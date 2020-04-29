using DIP_Dependency_Inversion_Principle.After.Interfaces;
using DIP_Dependency_Inversion_Principle.Common.Model;

namespace DIP_Dependency_Inversion_Principle.After
{
    // Point of Sales Order
    public class PoSCreditOrder : Order
    {
        private PaymentDetails _paymentDetails;
        private IPaymentProcessor _paymentProcessor;
        public PoSCreditOrder(Cart cart, PaymentDetails paymentDetails, IPaymentProcessor paymentProcessor) : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = paymentProcessor;
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount);
            base.Checkout();
        }

    }
}

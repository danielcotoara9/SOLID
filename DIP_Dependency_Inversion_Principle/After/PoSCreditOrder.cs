using DIP_Dependency_Inversion_Principle.After.Interfaces;
using DIP_Dependency_Inversion_Principle.Common.Model;

namespace DIP_Dependency_Inversion_Principle.After
{
    // Point of Sales Order with Credit Card. What we need is passed to the ctor of the class
    // This class is responsible to do the Checkout stuff in its own way without breaking anything from base
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

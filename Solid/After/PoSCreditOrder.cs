using Solid.After.Implementations;
using Solid.Common.Model;

namespace Solid.After
{
    // Point of Sales Order
    public class PoSCreditOrder : Order
    {
        private PaymentDetails _paymentDetails;
        private PaymentProcessor _paymentProcessor;
        public PoSCreditOrder(Cart cart, PaymentDetails paymentDetails) : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCredCard(_paymentDetails, _cart.TotalAmount);
            base.Checkout();
        }

    }
}

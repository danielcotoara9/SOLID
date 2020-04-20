using SRP_Single_Responsibility_Principle.After.Implementations;
using SRP_Single_Responsibility_Principle.Common.Model;

namespace SRP_Single_Responsibility_Principle.After
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

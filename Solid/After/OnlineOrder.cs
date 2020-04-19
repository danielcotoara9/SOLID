using Solid.After.Implementations;
using Solid.After.Interfaces;
using Solid.Common.Model;

namespace Solid.After
{
    public class OnlineOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly INotificationService _notificationService;
        private readonly IReservationService _reservationService;
        private readonly IPaymentProcessor _paymentProcessor;

        public OnlineOrder(Cart cart, PaymentDetails paymentDetails) : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
            _reservationService = new ReservationService();
            _notificationService = new NotificationService();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCredCard(_paymentDetails, _cart.TotalAmount);

            _reservationService.ReserveInventory(_cart.Items);

            _notificationService.NotifyCustomerOrderCreated(_cart);

            base.Checkout();
        }
    }
}

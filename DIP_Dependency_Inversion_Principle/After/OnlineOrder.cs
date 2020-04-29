using DIP_Dependency_Inversion_Principle.After.Interfaces;
using DIP_Dependency_Inversion_Principle.Common.Model;

namespace DIP_Dependency_Inversion_Principle.After
{
    // used only for online orders 
    // This class should decide what needs in his constructors in order to do the job
    // -------
    // Abstraction should not depend on details. Details should depend on abstractions.
    // This class is responsible to do the Checkout stuff in its own way without breaking anything from base
    public class OnlineOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;
        private readonly INotificationService _notificationService;

        // explicit about dependencies. I need this to do the job!
        public OnlineOrder(Cart cart, 
                           PaymentDetails paymentDetails,
                           IPaymentProcessor paymentProcessor, // depend on abstraction - receive here everything is needed
                           IReservationService reservationService,
                           INotificationService notificationService)
            : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = paymentProcessor;
            _reservationService = reservationService;
            _notificationService = notificationService;
        }

        // simple, easy to understand, easy to maintain
        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount);
            _reservationService.ReserveInventory(_cart);
            _notificationService.NotifyCustomerOrderCreated(_cart);
            base.Checkout();
        }
    }
}

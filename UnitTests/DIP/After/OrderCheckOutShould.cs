using DIP_Dependency_Inversion_Principle.After;
using DIP_Dependency_Inversion_Principle.After.Implementation;
using DIP_Dependency_Inversion_Principle.Before;
using DIP_Dependency_Inversion_Principle.Common.Model;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.DIP.After
{
    public class OrderCheckOutShould
    {
        [Fact]
        public void SendTotalAmountToCreditCardProcessor()
        {
            // Arrange
            var cart = new Cart { TotalAmount = 5, Items = new List<OrderItem>() };
            var paymentDetails = new PaymentDetails { PaymentMethod = PaymentMethod.Cash };
            var paymentProcessor = new PaymentProcessor();
            var reservationService = new ReservationService();
            var notificationService = new NotifyCustomerService();
            var onlineOrder = new OnlineOrder(cart, paymentDetails, paymentProcessor, reservationService, notificationService);

            // Act
            onlineOrder.Checkout();

            // Assert - verify what Checkout should do
            // maybe add here checks for reservation, ... if necesary
            Assert.Equal(cart.TotalAmount, paymentProcessor.AmountPassed);
        }
    }
}

using DIP_Dependency_Inversion_Principle.Before;
using DIP_Dependency_Inversion_Principle.Common.Model;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.DIP.Before
{
    public class OrderCheckOutShould
    {
        [Fact]
        public void NotFailWithNoItemsNoNotificationNoCreditCard()
        {
            var order = new Order();
            var cart = new Cart();
            var paymentDetails = new PaymentDetails { PaymentMethod = PaymentMethod.Cash };
            bool shouldNotifyCustomer = false;
            // when we run this we don't have any indication of success or failure since the method is "void"
            order.Checkout(cart, paymentDetails, shouldNotifyCustomer);

            // if I got here, I guess it worked..
        }

        [Fact]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var order = new Order();
            var cart = new Cart { Items = new List<OrderItem>()};
            var paymentDetails = new PaymentDetails { PaymentMethod = PaymentMethod.Cash };
            bool shouldNotifyCustomer = true;
            // when we run this we don't have any indication of success or failure since the method is "void"
            // we have notifications !! how to check if an email was sent or not ?
            order.Checkout(cart, paymentDetails, shouldNotifyCustomer);

            // if I got here, I guess it worked..
        }
    }
}

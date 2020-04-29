using DIP_Dependency_Inversion_Principle.Common;
using DIP_Dependency_Inversion_Principle.Common.Model;
using DIP_Dependency_Inversion_Principle.Common.Services;
using System;
using System.Net.Mail;

namespace DIP_Dependency_Inversion_Principle.Before
{
    public class Order
    {
        // we don't have nothing passed in the constructor of the class 
        // this method looks good, no instantiations, but what about the methods are called inside ??
        public void Checkout(Cart cart, PaymentDetails paymentDetails, bool notifyCustomer)
        {
            if(paymentDetails.PaymentMethod == PaymentMethod.CreditCard)
            {
                ChargeCard(paymentDetails, cart);
            }

            ReserveInventory(cart);

            if(notifyCustomer)
            {
                NotifyCustomer(cart);
            }
        }

        // have dependencies
        public void NotifyCustomer(Cart cart)
        {
            var customerEmail = cart.CustomerEmail;
            if(!string.IsNullOrEmpty(customerEmail))
            {
                // dependencies on MailMesage and SmtpClient
                // use of static Datetime.Now and Logger.Log method
                using (var message = new MailMessage("orders.domain.com", customerEmail))
                using (var client = new SmtpClient("localhost"))
                {
                    message.Subject = $"Your order placed on {DateTime.Now}";
                    message.Body = "Your order details \n " + cart.ToString();

                    try
                    {
                        client.Send(message);
                    }
                    catch(Exception ex)
                    {
                        Logger.Log($"There was a problem when sending notification to email {customerEmail}", ex);
                    }
                }
            }
        }


        // have dependencies
        public void ReserveInventory(Cart cart)
        {
            foreach(var item in cart.Items)
            {
                try
                {
                    // dependency on InventoryService
                    var inventoryService = new InventoryService();
                    inventoryService.Reserve(item.Sku, item.Quantity);
                }
                catch(Exception ex)
                {
                    throw new Exception($"There was a problem reserving inventory for item {item.Sku}");
                }
            }
        }

        // have dependencies
        public void ChargeCard(PaymentDetails paymentDetails, Cart cart)
        {
            // dependency on PaymentGatway
            using (var paymentGatway = new PaymentGatway())
            {
                try
                {
                    paymentGatway.Credentials = "account credentials";
                    paymentGatway.CardNumber = paymentDetails.CardNumber;
                    paymentGatway.ExpiresMonth = paymentDetails.ExpiresMonth;
                    paymentGatway.ExpiresYear = paymentDetails.ExpiresYear;
                    paymentGatway.NameOnCard = paymentDetails.CardHoldName;
                    paymentGatway.AmountToCharge = cart.TotalAmount;

                    paymentGatway.Charge();
                }
                catch(Exception ex)
                {
                    throw new Exception("There was a problem with your card");
                }
            }
        }
    }
}

using SRP_Single_Responsibility_Principle.Common;
using SRP_Single_Responsibility_Principle.Common.Model;
using SRP_Single_Responsibility_Principle.Common.Services;
using System;
using System.Net.Mail;

namespace SRP_Single_Responsibility_Principle.Before
{
    public class Order
    {
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

        private void NotifyCustomer(Cart cart)
        {
            var customerEmail = cart.CustomerEmail;
            if(!string.IsNullOrEmpty(customerEmail))
            {
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

        private void ReserveInventory(Cart cart)
        {
            foreach(var item in cart.Items)
            {
                try
                {
                    var inventoryService = new InventoryService();
                    inventoryService.Reserve(item.Sku, item.Quantity);
                }
                catch(Exception ex)
                {
                    throw new Exception($"There was a problem reserving inventory for item {item.Sku}");
                }
            }
        }

        private void ChargeCard(PaymentDetails paymentDetails, Cart cart)
        {
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

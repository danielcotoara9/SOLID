using Solid.After.Interfaces;
using Solid.Common.Model;
using System;
using System.Net.Mail;

namespace Solid.After.Implementations
{
    public class NotificationService : INotificationService
    {
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            var customerEmail = cart.CustomerEmail;
            if (!string.IsNullOrEmpty(customerEmail))
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
                    catch (Exception ex)
                    {
                        Logger.Log($"There was a problem when sending notification to email {customerEmail}", ex);
                    }
                }
            }
        }
    }
}

using DIP_Dependency_Inversion_Principle.After.Interfaces;
using DIP_Dependency_Inversion_Principle.Common;
using DIP_Dependency_Inversion_Principle.Common.Model;
using System;
using System.Net.Mail;

namespace DIP_Dependency_Inversion_Principle.After.Implementation
{
    public class NotifyCustomerService : INotificationService
    {
        // responsible for one thing only => sends notifications to customers
        public void NotifyCustomerOrderCreated(Cart cart)
        {
            var customerEmail = cart.CustomerEmail;
            if (!string.IsNullOrEmpty(customerEmail))
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
                    catch (Exception ex)
                    {
                        Logger.Log($"There was a problem when sending notification to email {customerEmail}", ex);
                    }
                }
            }
        }

    }
}

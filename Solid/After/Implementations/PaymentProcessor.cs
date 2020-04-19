using Solid.After.Interfaces;
using Solid.Common.Model;
using Solid.Common.Services;
using System;

namespace Solid.After.Implementations
{
    public class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCredCard(PaymentDetails paymentDetails, decimal totalAmount)
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
                    paymentGatway.AmountToCharge = paymentDetails.TotalAmount;

                    paymentGatway.Charge();
                }
                catch (Exception ex)
                {
                    throw new Exception("There was a problem with your card");
                }
            }
        }
    }
}

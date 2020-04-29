 using SRP_Single_Responsibility_Principle.After.Interfaces;
using SRP_Single_Responsibility_Principle.Common.Model;
using SRP_Single_Responsibility_Principle.Common.Services;
using System;

namespace SRP_Single_Responsibility_Principle.After.Implementations
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
                    paymentGatway.AmountToCharge = totalAmount;

                    paymentGatway.Charge();
                }
                catch (Exception ex)
                {
                    throw new Exception("There was a problem when processing your card");
                }
            }
        }
    }
}

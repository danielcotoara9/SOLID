using DIP_Dependency_Inversion_Principle.After.Interfaces;
using DIP_Dependency_Inversion_Principle.Common.Model;
using DIP_Dependency_Inversion_Principle.Common.Services;
using System;

namespace DIP_Dependency_Inversion_Principle.After.Implementation
{
    public class PaymentProcessor : IPaymentProcessor
    {
        public decimal AmountPassed { get; set; } = 0;
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
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
                    paymentGatway.AmountToCharge = amount;

                    paymentGatway.Charge();
                    AmountPassed = amount;
                }
                catch (Exception ex)
                {
                    throw new Exception("There was a problem with your card");
                }
            }
        }
    }
}

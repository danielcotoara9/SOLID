using DIP_Dependency_Inversion_Principle.Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Dependency_Inversion_Principle.After.Interfaces
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}

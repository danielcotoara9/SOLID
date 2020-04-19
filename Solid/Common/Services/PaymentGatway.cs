using System;

namespace Solid.Common.Services
{
    public class PaymentGatway : IDisposable
    {
        public string Credentials { get; internal set; }
        public long CardNumber { get; internal set; }
        public int ExpiresMonth { get; internal set; }
        public int ExpiresYear { get; internal set; }
        public string NameOnCard { get; internal set; }
        public decimal AmountToCharge { get; internal set; }

        public void Charge()
        {
            // Charge the card
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


    }
}

namespace SRP_Single_Responsibility_Principle.Common.Model
{
    public class PaymentDetails
    {
        public PaymentMethod PaymentMethod { get; set; }
        public long CardNumber { get; internal set; }
        public int ExpiresMonth { get; internal set; }
        public int ExpiresYear { get; internal set; }
        public string CardHoldName { get; internal set; }
    }
    public enum PaymentMethod : int
    {
        CreditCard,
        Cash
    }
}

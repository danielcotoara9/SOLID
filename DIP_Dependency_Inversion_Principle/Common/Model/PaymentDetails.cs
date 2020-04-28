namespace DIP_Dependency_Inversion_Principle.Common.Model
{
    public class PaymentDetails
    {
        public PaymentMethod PaymentMethod { get; set; }
        public long CardNumber { get; internal set; }
        public int ExpiresMonth { get; internal set; }
        public int ExpiresYear { get; internal set; }
        public string CardHoldName { get; internal set; }
        public decimal TotalAmount { get; internal set; }
    }
    public enum PaymentMethod : int
    {
        CreditCard,
        Cash
    }
}

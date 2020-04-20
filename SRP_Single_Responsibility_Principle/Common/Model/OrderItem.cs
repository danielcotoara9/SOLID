namespace SRP_Single_Responsibility_Principle.Common.Model
{
    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quantity { get; internal set; }
    }
}

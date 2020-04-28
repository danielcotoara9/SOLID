namespace DIP_Dependency_Inversion_Principle.Common.Model
{
    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quantity { get; internal set; }
    }
}

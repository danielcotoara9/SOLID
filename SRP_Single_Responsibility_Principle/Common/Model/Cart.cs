using System.Collections.Generic;

namespace SRP_Single_Responsibility_Principle.Common.Model
{
    public class Cart
    {
        public string CustomerEmail { get; set; }
        public decimal TotalAmount { get; set; }
        public IList<OrderItem> Items { get; set; }
    }

}

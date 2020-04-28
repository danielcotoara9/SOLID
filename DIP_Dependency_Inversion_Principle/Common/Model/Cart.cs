using System.Collections.Generic;

namespace DIP_Dependency_Inversion_Principle.Common.Model
{
    public class Cart
    {
        public string CustomerEmail { get; set; }
        public decimal TotalAmount { get; set; }
        public IList<OrderItem> Items { get; set; }
    }

}

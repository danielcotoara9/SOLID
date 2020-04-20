using System.Collections.Generic;

namespace SRP_Single_Responsibility_Principle.Common.Model
{
    public class Cart
    {
        public string CustomerEmail { get; internal set; }
        public decimal TotalAmount { get; set; }
        public IList<Product> Items { get; internal set; }
    }

}

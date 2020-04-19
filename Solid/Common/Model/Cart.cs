using System.Collections.Generic;

namespace Solid.Common.Model
{
    public class Cart
    {
        public string CustomerEmail { get; internal set; }
        public decimal TotalAmount { get; set; }
        public IList<Product> Items { get; internal set; }
    }

}

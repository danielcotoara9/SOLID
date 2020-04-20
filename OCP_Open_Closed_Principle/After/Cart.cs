using OCP_Open_Closed_Principle.After.Implementation;
using OCP_Open_Closed_Principle.After.Interfaces;
using OCP_Open_Closed_Principle.Common.Model;
using System.Collections.Generic;

namespace OCP_Open_Closed_Principle.After
{
    //Shopping cart
    public class Cart
    {
        private readonly List<OrderItem> _items;
        private IPricingCalculator _pricingCalculator;

        public Cart() : this(new PricingCalculator()) { }

        // Strategy Pattern
        public Cart(PricingCalculator pricingCalculator)
        {
            _pricingCalculator = pricingCalculator;
            _items = new List<OrderItem>();
        }

        public IEnumerable<OrderItem> Items
        {
            get { return _items; }
        }
        public string CustomerEmail { get; set; }

        public void Add(OrderItem orderItem)
        {
            _items.Add(orderItem);
        }


        // total price for all items in the cart
        public decimal TotalAmount()
        {
            var total = 0m;

            foreach (var orderItem in Items)
            {
                total += _pricingCalculator.CalculatePrice(orderItem);
            }
            return total;
        }
    }
}

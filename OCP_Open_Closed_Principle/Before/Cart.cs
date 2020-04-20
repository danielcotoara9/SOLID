using OCP_Open_Closed_Principle.Common.Model;
using System.Collections.Generic;

namespace OCP_Open_Closed_Principle.Before
{
    //Shopping cart
    public class Cart
    {
        private readonly List<OrderItem> _items;
        public Cart()
        {
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

            foreach(var orderItem in Items)
            {
                //decide what item is and what reduction to apply
                if(orderItem.Sku.StartsWith("EACH")) {
                    total += orderItem.Quantity * 5m;
                }
                else if(orderItem.Sku.StartsWith("WEIGHT")) {
                    // quantity is in grams, price is per kg
                    total += orderItem.Quantity * 4m / 1000;
                }
                else if (orderItem.Sku.StartsWith("SPECIAL")) {
                    // $0.40 each; 3 for a $1.00
                    total += orderItem.Quantity * .4m;
                    var setsOfThree = orderItem.Quantity / 3;
                    total -= setsOfThree * .2m;
                }
                // PROBLEM - more business rules to come !!! => 
                // So this is a valid time for us to be looking at this and thinking, 
                // how can we change this code in such a way that we don't have to go in and edit this particular method,
                // every time someone(Business Analys, Client, ...) comes up with a different way to price the items that are in the cart

            // SOLUTION - Use abstraction and When introduce new behavior , do it by adding new classes
            }
            return total;
        }
    }
}

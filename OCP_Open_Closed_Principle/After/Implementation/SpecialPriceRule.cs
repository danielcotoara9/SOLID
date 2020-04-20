using OCP_Open_Closed_Principle.After.Interfaces;
using OCP_Open_Closed_Principle.Common.Model;

namespace OCP_Open_Closed_Principle.After.Implementation
{
    public class SpecialPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem orderItem)
        {
            var total = 0m;
            // $0.40 each; 3 for a $1.00
            total += orderItem.Quantity * .4m;
            var setsOfThree = orderItem.Quantity / 3;
            total -= setsOfThree * .2m;
            return total;
        }

        public bool IsMatch(OrderItem orderItem)
        {
            return orderItem.Sku.StartsWith("SPECIAL");
        }
    }
}

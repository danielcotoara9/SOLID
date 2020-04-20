using OCP_Open_Closed_Principle.After.Interfaces;
using OCP_Open_Closed_Principle.Common.Model;

namespace OCP_Open_Closed_Principle.After.Implementation
{
    public class EachPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem orderItem)
        {
            return orderItem.Quantity * 5m;
        }

        public bool IsMatch(OrderItem orderItem)
        {
            return orderItem.Sku.StartsWith("EACH");
        }
    }
}

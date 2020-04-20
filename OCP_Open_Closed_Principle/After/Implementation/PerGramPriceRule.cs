using OCP_Open_Closed_Principle.After.Interfaces;
using OCP_Open_Closed_Principle.Common.Model;

namespace OCP_Open_Closed_Principle.After.Implementation
{
    public class PerGramPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem orderItem)
        {
            return orderItem.Quantity * 4m / 1000;
        }

        public bool IsMatch(OrderItem orderItem)
        {
            return orderItem.Sku.StartsWith("WEIGHT");
        }
    }
}

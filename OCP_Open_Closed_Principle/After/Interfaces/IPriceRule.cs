using OCP_Open_Closed_Principle.Common.Model;

namespace OCP_Open_Closed_Principle.After.Interfaces
{
    public interface IPriceRule
    {
        // determine what rule to apply to an orderItem
        bool IsMatch(OrderItem orderItem);
        //calculate the prices based on the rule
        decimal CalculatePrice(OrderItem orderItem);
    }
}

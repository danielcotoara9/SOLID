using OCP_Open_Closed_Principle.Common.Model;

namespace OCP_Open_Closed_Principle.After.Interfaces
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem orderItem);
    }
}

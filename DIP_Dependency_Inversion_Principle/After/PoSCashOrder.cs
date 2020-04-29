using DIP_Dependency_Inversion_Principle.Common.Model;

namespace DIP_Dependency_Inversion_Principle.After
{
    public class PoSCashOrder : Order
    {
        public PoSCashOrder(Cart cart) : base(cart)
        {
        }
    }
}

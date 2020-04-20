using SRP_Single_Responsibility_Principle.Common.Model;

namespace SRP_Single_Responsibility_Principle.After
{
    public class PoSCashOrder : Order
    {
        public PoSCashOrder(Cart cart) : base(cart)
        {
        }
    }
}

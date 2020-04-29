using DIP_Dependency_Inversion_Principle.Common.Model;

namespace DIP_Dependency_Inversion_Principle.After
{
    // Point of Sales Order only with cash. We only need the cart with all the items in it.
    // This class is responsible to do the Checkout stuff
    public class PoSCashOrder : Order
    {
        public PoSCashOrder(Cart cart) : base(cart)
        {
            // add here code specific for cash transactions
            base.Checkout();
        }
    }
}

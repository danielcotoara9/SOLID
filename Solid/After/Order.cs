using Solid.Common.Model;

namespace Solid.After
{
    public abstract class Order
    {
        protected readonly Cart _cart;
        public Order(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
            //log the order in the DataBase
        }
    }
}

using DIP_Dependency_Inversion_Principle.Common.Model;

namespace DIP_Dependency_Inversion_Principle.After
{
    // High-level modules should not depend on low level modules. Both should depend on abstractions
    // This abstracted base Order will be the parent to all the orders. 
    // -------
    // Abstraction should not depend on details. Details should depend on abstractions.
    // Each child class will have his own details implemented for Checkout method!
    public class Order
    {
        protected readonly Cart _cart;
        public Order(Cart cart)
        {
            _cart = cart;
        }

        public virtual void Checkout()
        {
            // maybe write the code that will save the order in Database - commom to all the childs of this class
        }
    }
}

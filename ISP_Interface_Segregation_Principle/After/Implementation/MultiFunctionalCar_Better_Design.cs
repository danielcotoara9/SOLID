using ISP_Interface_Segregation_Principle.After.Interfaces;

namespace ISP_Interface_Segregation_Principle.After.Implementation
{
    // this class implement everything from the Interface
    public class MultiFunctionalCar_Better_Design : IMultiFunctionalCar
    {
        private readonly ICar _car;
        private readonly IAirplane _airplane;

        // if we already have implemented the Car class and the Airplane class,
        // we can use them inside our class by using the Decorator Pattern
        public MultiFunctionalCar_Better_Design(ICar car, IAirplane airplane)
        {
            _car = car;
            _airplane = airplane;
        }
        // This can be a solution but we will not duplicate the code from Car and Airplane here ???
        public void Drive()
        {
            // code related to drive behavior
            _car.Drive();
        }

        public void Fly()
        {
            // code related to fly behavior
            _airplane.Fly();
        }
    }
}

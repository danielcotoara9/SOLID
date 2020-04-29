using ISP_Interface_Segregation_Principle.After.Interfaces;
using System;

namespace ISP_Interface_Segregation_Principle.After.Implementation
{
    // this class implement everything from the Interface
    public class MultiFunctionalCar : IMultiFunctionalCar
    {
        // This can be a solution but we will not duplicate the code from Car and Airplane here ???
        public void Drive()
        {
            // code related to drive behavior
            Console.WriteLine("Drive a multifunctional car");
        }

        public void Fly()
        {
            // code related to fly behavior
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}

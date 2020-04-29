using ISP_Interface_Segregation_Principle.Before.Interfaces;
using System;

namespace ISP_Interface_Segregation_Principle.Before.Implementation
{
    // this class implement everything from the Interface
    public class MultiFunctionalCar : IVehicle
    {
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

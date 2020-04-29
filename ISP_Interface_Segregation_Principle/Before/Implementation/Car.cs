using ISP_Interface_Segregation_Principle.Before.Interfaces;
using System;

namespace ISP_Interface_Segregation_Principle.Before.Implementation
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            // code related to drive behavior
            Console.WriteLine("Drive a car");
        }

        // the simple car doesn't know how to fly so will since it's obligated to implement
        // everything from the interface will not do anything
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}

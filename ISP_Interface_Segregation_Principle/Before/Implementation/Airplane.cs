using ISP_Interface_Segregation_Principle.Before.Interfaces;
using System;

namespace ISP_Interface_Segregation_Principle.Before.Implementation
{
    public class Airplane : IVehicle
    {
        // the Airplane class doesn't know how to drive. Since it's obligated to implement
        // everything from the interface will not do anything
        public void Drive()
        {
            throw new System.NotImplementedException();
        }

        public void Fly()
        {
            // code related to fly behavior
            Console.WriteLine("Fly an airplane");
        }
    }
}

using ISP_Interface_Segregation_Principle.After.Interfaces;
using System;

namespace ISP_Interface_Segregation_Principle.After.Implementation
{
    public class Airplane : IAirplane
    {
        public void Fly()
        {
            // code related to fly behavior
            Console.WriteLine("Fly an airplane");
        }
    }
}

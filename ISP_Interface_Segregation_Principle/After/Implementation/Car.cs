using ISP_Interface_Segregation_Principle.After.Interfaces;
using System;

namespace ISP_Interface_Segregation_Principle.After.Implementation
{
    public class Car : ICar
    {
        public void Drive()
        {
            // code related to drive behavior
            Console.WriteLine("Drive a car");
        }
    }
}

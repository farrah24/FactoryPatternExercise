using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            InIVehicle automobiles = VehicleFactory.GetVehicle("car"); 
        }    
    }
}

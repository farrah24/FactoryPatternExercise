using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static InIVehicle GetVehicle(string tires)
        {
            if (tires == "car")
            {
                return new Car();
            }
            else
            {
                return new Motorcycle();
            }

        }
    }
}

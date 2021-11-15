using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class Car : InIVehicle
    {
        private String color;
        public Car()
        {
            color = "blue";
        }
        public void Drive()
        {
            Console.WriteLine("The car is fast"); 
        }
        public void setColor(string c)
        {
            color = c;
        }
        public string getcolor()
        {
            return color;
        }
    }
}

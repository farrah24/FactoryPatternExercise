using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public class Motorcycle : InIVehicle
    {
        private string color;
        public Motorcycle()
        {
            color = "red";
        }
            
        public void Drive()
        {
            Console.WriteLine("The motorcycle is a Harley");
            
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

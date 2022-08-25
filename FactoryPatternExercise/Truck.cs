using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Truck : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The truck is driving!");
        }
    }
}

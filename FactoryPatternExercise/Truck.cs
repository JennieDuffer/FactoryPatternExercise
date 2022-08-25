using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Truck : IVehicle
    {
        public int WheelCount { get; set; } = 3;
        public string Make { get; set; }
        public bool isDriveable { get; set; } = false;

        public void Drive()
        {
            Console.WriteLine($"The truck is a {Make} trying to drive on {WheelCount} wheels!");
        }
    }
}

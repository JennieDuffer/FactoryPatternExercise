using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    internal class Car : IVehicle
    {
        public int WheelCount { get; set; } = 4;
        public string Make { get; set; }
        public bool isDriveable { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"This car is driving with {WheelCount} wheels!");
        }
    }
}

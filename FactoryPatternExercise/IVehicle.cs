using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public interface IVehicle
    {
        public int WheelCount { get; set; } 
        public string Make { get; set; }
        public bool isDriveable { get; set; }

        public void Drive();
    }
}

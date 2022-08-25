using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string numberOfTires)
        {
            switch (numberOfTires)
            {
                case "car":
                    return new Car();
                case "truck":
                    return new Truck();
                default:
                    return new Truck();


                    //if (numberOfTires == 4)
                    //{
                    //    return new Car();
                    //}
                    //else
                    //{
                    //    return new Truck();

                    //}


            }
        }
    }
}
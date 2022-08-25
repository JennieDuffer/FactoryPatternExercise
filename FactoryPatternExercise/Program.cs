using FactoryPatternExercise;

Console.WriteLine("What vehicle do you want to drive?");
var response = Console.ReadLine();

IVehicle vehicle = VehicleFactory.GetVehicle(response);

vehicle.Drive();

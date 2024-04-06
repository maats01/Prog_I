using Herança_Polimorfismo.Models;

List<Vehicle> Vehicles = new List<Vehicle>();

Vehicles.Add(new Car());
Vehicles.Add(new Bike());
Vehicles.Add(new Truck());

foreach(Vehicle vehicle in Vehicles)
{
    Console.WriteLine(string.Format("{0} has {1} wheels",
    vehicle.GetType().Name, vehicle.Wheels()));
}
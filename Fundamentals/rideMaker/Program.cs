// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//public Vehicle(string name, int pass, string color, bool eng)
//    public Vehicle(string name, string color)


Car Chevy = new Car("Chevy",6,"Pewter");
// Vehicle Skateboard = new Vehicle("Baker",1,"Red & Black",false);
Horse Clyde = new Horse("Clyde",2 ,"Spotted");
Bicycle Huffy = new Bicycle("Huffy", 1, "Red" );

List<Vehicle> vehicleList = new List<Vehicle>() {Chevy, Clyde, Huffy};

List<INeedFuel> FuelList = new List<INeedFuel>() {};

foreach(Vehicle v in vehicleList)
{
    if (v is INeedFuel)
    {
        // Console.WriteLine(v);
        // FuelList.Add(v as INeedFuel);   // Could be null
        FuelList.Add((INeedFuel) v);       // Explicit Must be INeedFuel or will Error.
    }
}

foreach(INeedFuel f in FuelList) 
{
    f.GiveFuel(10);
    Console.WriteLine($"{f}, {f.FuelTotal}");
}

// foreach(INeedFuel f in FuelList) 
// {
//     Console.WriteLine($"{f}, {f.FuelTotal}");
// }



// foreach(Vehicle car in vehicleList)
// {
//     car.ShowInfo();
// }
// RX7.Travel(100);
// GSXR.Travel(267);
// foreach(Vehicle car in vehicleList)
// {
//     car.ShowInfo();
// }




// No it does not let me change the field manually as it is set to private. 
// This is better so the user can not change the Miles to whatever they want. 
// If we add validations the user would be able to bypass the validations and
// be able to roll back the milage or alter in other ways.cd 
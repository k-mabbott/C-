// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//public Vehicle(string name, int pass, string color, bool eng)
//    public Vehicle(string name, string color)


Vehicle Chevy = new Vehicle("Chevy",6,"Pewter",true);
Vehicle Skateboard = new Vehicle("Baker",1,"Red & Black",false);
Vehicle RX7 = new Vehicle("Mazda", "Maroon");
Vehicle GSXR = new Vehicle("Suzuki", 2, "Blue", true);

List<Vehicle> vehicleList = new List<Vehicle>() {Chevy, Skateboard, RX7, GSXR};

foreach(Vehicle car in vehicleList)
{
    car.ShowInfo();
}
RX7.Travel(100);
GSXR.Travel(267);
foreach(Vehicle car in vehicleList)
{
    car.ShowInfo();
}
// No it does not let me change the field manually as it is set to private. 
// This is better so the user can not change the Miles to whatever they want. 
// If we add validations the user would be able to bypass the validations and
// be able to roll back the milage or alter in other ways.cd 
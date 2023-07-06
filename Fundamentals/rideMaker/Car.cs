

public class Car : Vehicle, INeedFuel
{

    public string FuelType { get; set; }
    public int FuelTotal { get; set; }
    public Car(string name, int pass, string color) : base (name, pass, color, true)
    {
        FuelType = "Petrol";
        FuelTotal = 10;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        if (FuelTotal > 20 )
        {
            FuelTotal = 20;
        }
        Console.WriteLine($"Glug, Glug your {_Name} now has {FuelTotal} Gallons of {FuelType}");
        
    }
}
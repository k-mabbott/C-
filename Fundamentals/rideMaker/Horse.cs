

class Horse : Vehicle, INeedFuel
{

    public string FuelType { get; set; }
    public int FuelTotal { get; set; }
    public Horse(string name, int pass, string color) : base (name, pass, color, true)
    {
        FuelType = "Hay";
        FuelTotal = 10;
    }

    public void GiveFuel(int Amount)
    {
        FuelTotal += Amount;
        if (FuelTotal > 20 )
        {
            FuelTotal = 20;
        }
        Console.WriteLine($"Nom, Nom your {_Name} is full and has taken {FuelTotal} bites of {FuelType}");
        
    }
}
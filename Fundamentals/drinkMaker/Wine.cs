

class Wine : Drink 
{
    public int BottleYear;
    public string Region;

    public Wine(string name, string color, int temp, int cals, int year, string reg ) : base(name, color, temp, false, cals )
    {
        BottleYear = year;
        Region = reg;
    }
        public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Bottle Year: {BottleYear}, Region: {Region}");
    }
}


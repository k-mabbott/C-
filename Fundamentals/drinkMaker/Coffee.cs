

class Coffee : Drink 
{
    public string RoastValue;
    public string TypeOfBeans;

    public Coffee(string name, string color, int temp, bool carb, int cals, string rv, string tob ) : base(name, color, temp, carb, cals )
    {
        RoastValue = rv;
        TypeOfBeans = tob;
    }

        public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Roast Value: {RoastValue}, Type of Beans: {TypeOfBeans}");
    }
}
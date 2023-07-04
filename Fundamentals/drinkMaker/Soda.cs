

class Soda : Drink 
{
    public bool Diet;

    public Soda(string name, string color, bool d, int cals ) : base(name , color, 35, true, cals )
    {
        Diet = d;
    }

    public override void ShowDrink()
    {
        base.ShowDrink();
        Console.WriteLine($"Diet? {Diet}");
    }
}


public class Attack 
{
    public string Name;
    public int DamageAmount;

    public Attack(string n, int d)
    {
        Name = n;
        DamageAmount = d;
    }

    public override string ToString()
    {
        return Name;
    }

}
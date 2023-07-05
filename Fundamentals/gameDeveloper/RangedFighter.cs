

public class RangedFighter : Enemy
{

    int Distance;

    public Attack Arrow;
    public Attack ThrowingKnife;

    // attacks.Add(Punch);
    public RangedFighter(string name) : base(name, 100)
    {
        Distance = 5;
        Arrow = new Attack("Shoot an Arrow", 20);
        ThrowingKnife = new Attack("Throw a Knife", 15);
        AttackList = new List<Attack>() { Arrow, ThrowingKnife };
    }

    public override void PerformAttack(Enemy target, Attack atk)
    {
        if (Distance < 10)
        {
            Console.WriteLine($"Your distance is {Distance} unit(s). Minimum distance to perform {atk} is 10.");
        } else 
        {
            base.PerformAttack(target, atk);
        }
    }

    public void Dash(Enemy target)
    {
        Distance = 20;
        Console.WriteLine($"{Name} Moved back {Distance} Units from {target.Name}");
        
    }

}
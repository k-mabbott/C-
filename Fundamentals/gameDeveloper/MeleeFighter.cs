
// [("Punch",20),("Punch",20),("Punch",20)]
public class MeleeFighter : Enemy
{

    public Attack Punch;
    public Attack Kick;
    public Attack Tackle;
    // public List<Attack> attacks;

    public MeleeFighter(string name) : base(name, 120)
    {
    Punch = new Attack("Punch", 20);
    Kick = new Attack("Kick", 15);
    Tackle = new Attack("Tackle", 25);
    AttackList = new List<Attack>() {Punch, Kick, Tackle};
    }

    public void Rage(Enemy target)
    {
        Attack a = RandomAttack();
        a.DamageAmount += 10;
        PerformAttack(target, a);
        a.DamageAmount -= 10;
    }



}
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.Write($"{i} ");
        // } 
        // Console.WriteLine("gooble", );
        // // prints 1 2 3 4 5 6 ect...
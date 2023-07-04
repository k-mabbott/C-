
// [("Punch",20),("Punch",20),("Punch",20)]
public class MeleeFighter : Enemy
{

    static Attack Punch = new Attack("Punch", 20);
    static Attack Kick = new Attack("Kick", 15);
    static Attack Tackle = new Attack("Tackle", 25);
    static List<Attack> attacks = new List<Attack>() {Punch, Kick, Tackle};

    // attacks.Add(Punch);
    public MeleeFighter(string name) : base(name, 120, attacks)
    {
        
    }

    public Enemy Rage(Enemy target)
    {
        return target;
    }

}


public class MagicCaster : Enemy
{

    int Distance;

    public Attack Fireball;
    public Attack Lightingbolt;
    public Attack StaffStrike;

    // attacks.Add(Punch);
    public MagicCaster(string name) : base(name, 80)
    {
        Distance = 5;
        Fireball = new Attack("Fireball", 25);
        Lightingbolt = new Attack("Lightning Bolt", 20);
        StaffStrike = new Attack("Staff Strike", 10);
        AttackList = new List<Attack>() { Fireball, Lightingbolt, StaffStrike };
    }

    public void Heal(Enemy target)
    {
        if (_Health == 0 )
        {
            Console.WriteLine($"Sorry {Name} has no health left you can not heal anyone...");
            return;
        } else if (target._Health == 0 )
        {
            Console.WriteLine($"Sorry {target.Name} has no health left you can not revive anyone...");
        }

        target._Health += 40;
        if (target._Health > target.MaxHealth)
        {
            target._Health = target.MaxHealth;
        }
        Console.WriteLine($"You healed {target.Name} thier health is now {target._Health}");
        
    }

}
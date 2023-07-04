

public class Enemy 
{
    public string Name;
    private int Health;
        public int _Health
        {
            get
            {
                return Health;
            }
            // set
            // {
            //     Health = value;
            // }
        }
    public List<Attack> AttackList {get;set;}

    public Enemy(string n, int health, List<Attack> attacks)
    {
        Name = n;
        Health = health;
        AttackList = attacks;
    }

    public void AddAttack(Attack a)
    {
        AttackList.Add(a);
    }

    Random rand = new Random();
    public string RandomAttack()
    {
        int randNum = rand.Next(AttackList.Count);
        return AttackList[randNum].Name;
    }

    public void PerformAttack(Enemy target, Attack atk)
    {
        Console.WriteLine($"{Name} attacks {target.Name}");
        Console.WriteLine($"Dealing {atk.DamageAmount} damage. {target.Name}'s health is now {target.Health}!");
    }

}
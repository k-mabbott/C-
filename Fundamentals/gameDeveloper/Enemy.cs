

public class Enemy 
{
    public string Name;
    public int MaxHealth;
    private int Health;
        public int _Health
        {
            get
            {
                return Health;
            }
            set
            {
                Health = value;
            }
        }
    public List<Attack> AttackList {get;set;}

    public Enemy(string n, int health)
    {
        Name = n;
        Health = health;
        MaxHealth = health;
        AttackList = new List<Attack>();
    }

    public void AddAttack(Attack a)
    {
        AttackList.Add(a);
    }

    Random rand = new Random();
    public Attack RandomAttack()
    {
        int randNum = rand.Next(AttackList.Count);
        return AttackList[randNum];
    }

    public virtual void PerformAttack(Enemy target, Attack atk)
    {
        if (_Health == 0 )
        {
            Console.WriteLine($"Sorry {Name} has no health left you can not attack...");
            return;
        } else if (target._Health == 0 )
        {
            Console.WriteLine($"You already took care of {target.Name} pick on someone who still has health left!");
        }
        
        Console.WriteLine($"{Name} attacks {target.Name} Using {atk}");
        target._Health -= atk.DamageAmount;
        if (target._Health < 0 )
        {
            target._Health = 0;
        }
        Console.WriteLine($"Dealing {atk.DamageAmount} damage. {target.Name}'s health is now {target.Health}!");
    }

}
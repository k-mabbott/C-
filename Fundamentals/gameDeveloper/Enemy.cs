

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

    public Enemy(string n)
    {
        Name = n;
        Health = 100;
        AttackList = new List<Attack>();
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

}
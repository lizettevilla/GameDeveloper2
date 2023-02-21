class Enemy {
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string n, int h)
    {
        Name = n;
        Health = h;
        AttackList = new List<Attack>();
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Enemy Name: {this.Name} - Enemy Health: {this.Health}");
        foreach(Attack item in AttackList)
        {
            Console.WriteLine($"Attack: {item.Name} | Damage: {item.DamageAmount}");
        }
    }
    public void RandomAttack()
    {
        Random rand = new Random();
        Attack randAtt = AttackList[rand.Next(0,AttackList.Count)];
        Console.WriteLine($"You{randAtt.Name} for {randAtt.DamageAmount} damage!!!");
    }
    public Enemy AddAttack(Attack att)
    {
        AttackList.Add(att);
        return this;
    }
}
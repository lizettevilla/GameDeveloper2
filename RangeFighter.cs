class RangeFighter : Enemy
{
    public int Distance;
    public RangeFighter(string n) : base(n,100)
    {
        Distance = 5;
        AttackList.Add(new Attack("Shoot Arrow", 20));
        AttackList.Add(new Attack("Throw a Knife", 15));
    }
    public void RangeFighterPrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Distance: {Distance}");
    }
    public void RangeFighterRandomAttack()
    {
        Random rand = new Random();
        Attack randAtt = AttackList[rand.Next(0, AttackList.Count)];
        if(Distance < 10)
        {
            Console.WriteLine("Too far to perform attack!!");
        } else {
            Console.WriteLine($"You {randAtt.Name} for {randAtt.DamageAmount} damage!!");
        }
    }
    public RangeFighter Dash()
    {
        Distance = 20;
        Console.WriteLine("Dash Away");
        return this;
    }
}
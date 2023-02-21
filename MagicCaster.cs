class MagicCaster : Enemy
{
public MagicCaster(string n) : base(n,80)
{
    AttackList.Add(new Attack("Fireball", 25));
    AttackList.Add(new Attack("Lightning Bolt", 20));
    AttackList.Add(new Attack("Staff Strike", 10));
}

public void MagicCasterPrintInfo()
{
    base.PrintInfo();
}
public MagicCaster Heal(Enemy target)
{
    target.Health+=40;
    Console.WriteLine($"Healed {target.Name} to {target.Health} health!!");
    return this;
}
}
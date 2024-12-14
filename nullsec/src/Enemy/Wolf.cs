using System;

public class Wolf : Enemy
{
    public override string Faction => " Wolves ";
    public override int MaxHealth { get ; set ; }
    public override int Health { get ; set ; } = 150;
    public override int AttackPower => 20;
    public override void Attack (PlayerCharacter player)
    {
        Console.WriteLine ("Wolf strikes swiftly and accurately!");
        int critical = new Random().Next(0, 100);
        if (critical < 5)
        {
            Console.WriteLine ("Critical hit!");
            player.TakeDamage(AttackPower * 2);
        }
        else
        {
            player.TakeDamage(AttackPower);
        }
    }
}
using System;
public class Sentinel : Enemy
{
    public override string Faction => " Sentinel ";
    public override int MaxHealth { get ; set ; }
    public override int Health { get ; set ; } = 100;
    public override int AttackPower => 15;
    public override void Attack (PlayerCharacter player)
    {
        Console.WriteLine(" Sentinel attacks with military precision!");
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
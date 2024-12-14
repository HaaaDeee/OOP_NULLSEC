using System;

public class Drone : Enemy
{
    public override string Faction => " Drone ";
    public override int MaxHealth { get ; set ; }
    public override int Health { get; set; } = 50;
    public override int AttackPower => 10;
    public override void Attack(PlayerCharacter player)
    {
        Console.WriteLine(" Drone launches an aerial attack!");
        int critical = new Random().Next(0, 100);
        if (critical < 5)
        {
            Console.WriteLine ("Critical hit!");
            player.TakeDamage(AttackPower * 2);
        }
    }
}
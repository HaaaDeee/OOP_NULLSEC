using System;
public class Sentinel : Enemy
{
    public override string Faction => " Sentinel ";
    public override int MaxHealth { get ; set ; }
    public override int Health { get ; set ; } = 100;
    public override int AttackPower => 15;
    public override void Attack ()
    {
        Console.WriteLine(" Sentinel attacks with military precision!");
    }
}
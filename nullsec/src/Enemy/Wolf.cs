using System;

public class Wolf : Enemy
{
    public override string Faction => " Wolves ";
    public override int MaxHealth { get ; set ; }
    public override int Health { get ; set ; } = 150;
    public override int AttackPower => 25;
    public override void Attack ()
    {
        Console.WriteLine ("Wolf strikes swiftly and accurately!");
    }
}
using System;

public class Drone : Enemy
{
    public override string Faction => " Drone ";
    public override int Health { get ; set ; } = 50;
    public override int AttackPower => 10;
    public override void Attack ()
    {
        Console . WriteLine (" Drone ␣ launches ␣an␣ aerial ␣ attack !");
    }
}
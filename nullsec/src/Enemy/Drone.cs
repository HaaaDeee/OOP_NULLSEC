using System;

public class Drone : Enemy
{
    public override string Faction {get;}
    public override int MaxHealth { get ; set ; }
    public override int Health { get; set; }
    public override int AttackPower { get ; }

    public Drone(int playerLevel){
        Faction = new string("Drone");
        MaxHealth = 35 + (playerLevel * 4);
        Health = MaxHealth;
        AttackPower = 8 + (playerLevel * 1);
    }

    public override void Attack(PlayerCharacter player)
    {
        Console.WriteLine(" Drone launches an aerial attack!");
        int critical = new Random().Next(0, 100);
        if (critical < 3)
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
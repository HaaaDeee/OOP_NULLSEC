using System;

public class Wolf : Enemy
{
    public override string Faction => " Wolves ";
    public override int MaxHealth { get ; set ; }
    public override int Health { get ; set ; }
    public override int AttackPower;

    public Wolf(int playerLevel){
        Faction = "Wolf";
        MaxHealth = 120 + (playerLevel * 6);
        Health = MaxHealth;
        AttackPower = 12 + (playerLevel * 1);
    }

    public override void Attack (PlayerCharacter player)
    {
        Console.WriteLine ("Wolf strikes swiftly and accurately!");
        int critical = new Random().Next(0, 100);
        if (critical < 20)
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
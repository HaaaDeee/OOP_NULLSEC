using System;
public class Sentinel : Enemy
{
    public override string Faction {get;}
    public override int MaxHealth { get ; set ; }
    public override int Health { get ; set ; } 
    public override int AttackPower { get ; }

    public Sentinel(int playerLevel){
        Faction = "Sentinel";
        MaxHealth = 90 + (playerLevel * 3);
        Health = MaxHealth;
        AttackPower = 9 + (playerLevel * 1);
    }

    public override void Attack (PlayerCharacter player)
    {
        Console.WriteLine(" Sentinel attacks with military precision!");
        int critical = new Random().Next(0, 100);
        if (critical < 35)
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
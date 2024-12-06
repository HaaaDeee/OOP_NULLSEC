using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class RangedAttack : IAttackStrategy
{
    public void ExecuteAttack ( Enemy enemy , PlayerCharacter player)
    {
        int damage = enemy.AttackPower - (player.Defense/2); //Reduced effectiveness due to range
        player.TakeDamage(damage);
        Console.WriteLine($"{ enemy.Faction } fires from a distance for { damage } damage.");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CloseRangeAttack : IAttackStrategy
{
    public void ExecuteAttack ( Enemy enemy , PlayerCharacter player)
    {
        int damage = enemy . AttackPower - player . Defense ;
        player . TakeDamage ( damage );
        Console . WriteLine ($"{ enemy . Faction }␣ attacks ␣up␣ close ␣for␣{ damage }␣ damage .");
    }
}
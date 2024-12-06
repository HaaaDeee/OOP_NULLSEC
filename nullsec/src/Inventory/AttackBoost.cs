using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AttackBoost : Item
{
    public override string Name => " Attack ␣ Boost ";
    public override void Use ( PlayerCharacter player )
    {
        player . Attack += 5;
        Console . WriteLine ($"{ player . CharacterName }␣ uses ␣ Attack ␣ Boost .␣ Attack ␣is␣now␣{ player . Attack }");
    }
}
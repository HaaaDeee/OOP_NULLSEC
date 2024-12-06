using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class HealthBoost : Item
{
    public override string Name => " Health ␣ Boost ";
    public override void Use ( PlayerCharacter player )
    {
        player . Health += 20;
        Console . WriteLine ($"{ player . CharacterName }␣ uses ␣ Health ␣Boost .␣ Health ␣is␣now␣{ player . Health }");
    }
}
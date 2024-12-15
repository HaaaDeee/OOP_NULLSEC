using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class AttackBoost : Item
{
    public override string name => "Attack Boost";
    public override void Use ( PlayerCharacter player )
    {
        player.getBuff("attack", 10 + player.Level/2);
        Console.WriteLine($"{ player.CharacterName } uses Attack Boost. Attack is now{ player.Attack }");
    }
}
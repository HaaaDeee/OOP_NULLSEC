using System;

public static class EnemyFactory
{

    public static Enemy CreateEnemy ( string enemyType )
    {
        int characterLevel = PlayerCharacter.GetInstance().Level;
        return enemyType.ToLower() switch
        {
        "sentinel" => new Sentinel (characterLevel),
        "wolf" => new Wolf (characterLevel),
        "drone" => new Drone (characterLevel),
        _ => throw new ArgumentException (" Unknown enemy type")
        };
    }
}
using System;

public static class EnemyFactory
{
    
    int characterLevel = PlayerCharacter.GetInstance().Level;

    public static Enemy CreateEnemy ( string enemyType )
    {
        return enemyType.ToLower() switch
        {
        "sentinel" => new Sentinel (characterLevel),
        "wolf" => new Wolf (characterLevel),
        "drone" => new Drone (characterLevel),
        _ => throw new ArgumentException (" Unknown enemy type")
        };
    }
}
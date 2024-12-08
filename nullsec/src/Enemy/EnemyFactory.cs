using System;

public static class EnemyFactory
{
    public static Enemy CreateEnemy ( string enemyType, PlayerCharacter player)
    {
        return enemyType . ToLower () switch
        {
        " sentinel " => new Sentinel (),
        " wolf " => new Wolf (),
        " drone " => new Drone (),
        _ => throw new ArgumentException (" Unknown enemy type")
        };
    }
}
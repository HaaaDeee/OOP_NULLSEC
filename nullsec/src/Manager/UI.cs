using System;

public class UI
{
    public static UI? instance = null;
    public static UI Instance()
    {
        if (instance == null)
        {
            return new UI();
        }
        else
        {
            return instance;
        }
    }

    public static int BattleManager(PlayerCharacter player, Enemy enemy)
    {
        Console.WriteLine("");
        
    }
}
using System;

public class UI
{
    private static UI? instance = null;

    public static UI Instance() => instance ??= new UI();

    public static int BattleManager(PlayerCharacter player, Enemy enemy)
    {
        Console.WriteLine("");
        return 0;
    }
}
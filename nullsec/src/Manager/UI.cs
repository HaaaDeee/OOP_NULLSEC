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
        Console.WriteLine("Enemy :");
        Console.WriteLine(enemy.Faction);
        Console.WriteLine("Health : " + enemy.Health + "/" + enemy.MaxHealth);
        Console.WriteLine("============================================");
        Console.WriteLine("Player: ");
        Console.WriteLine(player.CharacterName);
        Console.WriteLine("Health : " + player.Health + "/" + player.MaxHealth);
        Console.WriteLine("============================================");
        Console.WriteLine("Pilihan Aksi : ");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Skill"); //skill (bisa di skip)
        Console.WriteLine("3. Item");
        Console.WriteLine("4. Kabur");
        Console.WriteLine("============================================");
        Console.WriteLine("Pilihan anda :");
        return 0;
    }
}
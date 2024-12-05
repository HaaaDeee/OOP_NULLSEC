public class Program
{
    public static void Main()
    {
        Enemy enemy = EnemyFactory.CreateEnemy("sentinel");
        Console.WriteLine($"Enemy faction: {enemy.Faction}");
        Console.WriteLine($"Enemy health: {enemy.Health}");
        Console.WriteLine($"Enemy attack power: {enemy.AttackPower}");
        enemy.Attack();
    }
}
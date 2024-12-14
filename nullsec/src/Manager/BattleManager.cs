using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BattleManager
{
    private PlayerCharacter? player;
    private string enemy;
    private int progress;
    private int choice;
    public BattleManager(string enemy, int progress)
    {
        this.enemy = enemy;
        this.progress = progress;
        choice = -1;
        player = PlayerCharacter.GetInstance();
    }
    public void StartBattle()
    {
        Enemy? enemy = null;
        for (int i = 0; i < progress; i++)
        {
            enemy = EnemyFactory.CreateEnemy(this.enemy);
            if (player == null || enemy == null)
            {
                throw new Exception("Player or enemy is null");
            }
            do
            {
                //player turn
                choice = UI.BattleManager<Enemy>(player, enemy);
                switch (choice)
                {
                    case 1:
                        player.AttackEnemy(enemy);
                        break;
                    case 2:
                        //open inventory
                        break;
                    case 3:
                        //nigerundayo
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                //enemy turn
                enemy.Attack(player);
            } while (enemy.Health > 0 && player.Health > 0);
            if(player.Health < 0)
            {
                Console.WriteLine("Quest failed, returning to main menu");
                return;
            }
        }
    }
}

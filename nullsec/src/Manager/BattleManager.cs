using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BattleManager
{
    private PlayerCharacter? player;
    private Quest? quest;
    private int choice;
    public BattleManager(Quest? quest)
    {
        this.quest = quest;
        choice = -1;
        player = PlayerCharacter.GetInstance();
    }
    public void StartBattle()
    {
        if(quest == null)
        {
            throw new Exception("Quest is null");
        }
        Enemy? enemy = null;
        for (int i = 0; i < quest.objective; i++)
        {
            enemy = EnemyFactory.CreateEnemy(quest.enemy);
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

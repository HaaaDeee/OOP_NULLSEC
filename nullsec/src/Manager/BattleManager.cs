using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BattleManager
{
    private PlayerCharacter? player;
    private Quest? quest;
    private int choice;
    private bool isMove;
    public BattleManager(Quest? quest)
    {
        this.quest = quest;
        choice = -1;
        player = PlayerCharacter.GetInstance();
        isMove = false;
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
                        isMove = true;
                        break;
                    case 2:
                        //open inventory
                        switch(UI.ChooseItem()) {
                            case 1:
                                new HealthBoost().Use(player);
                                break;
                            case 2:
                                new AttackBoost().Use(player);
                                break;
                            default:
                                break;
                        }
                        isMove = true;
                        break;
                    case 3:
                        //nigerundayo
                        Console.WriteLine("You ran away");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                //enemy turn
                if (enemy.Health > 0 && isMove == true)
                {
                    enemy.Attack(player);
                    isMove = false;
                }
            } while (enemy.Health > 0 && player.Health > 0 && choice != 3);
            if (player.Health < 0 || choice == 3)
            {
                break;
            }
        }
        if(player == null)
        {
            throw new Exception("Player is null");
        }
        if(player.Health <= 0 || choice == 3)
        {
            Console.WriteLine("You lose! Quest failed.");
        } else {
            quest.isComplete = true;
            quest.EndQuest();
        }
        System.Threading.Thread.Sleep(3000);
        player.Health = player.MaxHealth;
    }
}

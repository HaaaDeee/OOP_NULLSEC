using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BattleManager
{
    private PlayerCharacter? player;
    private Enemy? enemy;
    private int choice;
    public BattleManager(Enemy? enemy)
    {
        this.enemy = enemy;
        choice = -1;
        player = PlayerCharacter.GetInstance("Player", "Technician");
    }
    public void StartBattle()
    {
        if (player == null || enemy == null)
        {
            throw new Exception("Player or enemy is null");
        }
        choice = UI.BattleManager<Enemy>(player, enemy);
        do
        {
            switch (choice)
            {
                case 1:
                    player.AttackEnemy();
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
        } while (enemy.Health > 0 && player.Health > 0);
        if (enemy.Health <= 0)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
        //kembali ke menu awal
    }
}

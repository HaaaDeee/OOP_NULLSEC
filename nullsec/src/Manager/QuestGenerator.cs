using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class QuestGenerator
{
    private string? enemyType;
    public string GenerateQuest()
    {
        Random random = new Random();
        int rand = random.Next(1, 4);
        switch (rand)
        {
            case 1:
                enemyType = "Sentinel";
                break;
            case 2:
                enemyType = "Wolf";
                break;
            case 3:
                enemyType = "Drone";
                break;
            default:
                break;
        }
        if (enemyType == null)
        {
            throw new Exception("Enemy type is null");
        }
        return enemyType;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Quest
{
    public string enemy;
    public int objective;
    public bool isComplete;
    public Quest(string enemy, int objective)
    {
        this.enemy = enemy;
        this.objective = objective;
        this.isComplete = false;
    }
    public void EndQuest()
    {
        // reward player
        if (isComplete)
        {
            Console.WriteLine("Quest complete!");
            PlayerCharacter.GetInstance().LevelUp();
        } else {
            Console.WriteLine("Big Dawg");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Quest
{
    public Enemy? enemy;
    public int objective;
    public int progress;
    public bool isComplete;
    public Quest(Enemy enemy, int objective)
    {
        this.enemy = enemy;
        this.objective = objective;
        this.progress = 0;
        this.isComplete = false;
    }
    public void StartQuest()
    {
        // call battle manager and generate enemy base on quest objective
    }
    public void UpdateQuest()
    {
        // check if quest is complete
        if (progress >= objective)
        {
            isComplete = true;
        }
    }
    public void EndQuest()
    {
        // reward player
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class QuestManager
{
    QuestGenerator questGenerator = new QuestGenerator();
    private List<string> enemyList = new List<string>();
    private List<int> objectiveList = new List<int>();
    public void GenerateEnemyList()
    {
        for (int i = 0; i < 3; i++)
        {
            enemyList.Add(questGenerator.GenerateQuest());
            objectiveList.Add(new Random().Next(1, 4));
        }
    }
    public void ShowQuests()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Quest {i + 1}: Kill {objectiveList[i]} {enemyList[i]}s");
        }
    }
    public Quest? takeQuest(int questNumber)
    {
        if (questNumber < 1 || questNumber > 3)
        {
            Console.WriteLine("Invalid quest number");
            return null;
        }
        Console.WriteLine($"You have taken quest {questNumber}");
        return new Quest(enemyList[questNumber - 1], objectiveList[questNumber - 1]);
    }
}
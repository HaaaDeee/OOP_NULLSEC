using System;

public class GameState
{
    public static GameState? instance;
    private string? CharacterName;
    private string? TechTree;
    private int Level;
    private int SkillPoints;
    private int Health;
    private int Attack;
    private int Defense;

    private GameState() {
        instance = this;
    }

    public static GameState GetInstance()
    {
        if (instance == null)
        {
            instance = new GameState();
        }
        return instance;
    }

    // Player, etc. mengupdate GameState
    public void UpdateSelf() {
        PlayerCharacter player = PlayerCharacter.GetInstance();
        this.CharacterName = new string(player.CharacterName);
        this.TechTree = new string(player.TechTree);
        this.Level = player.Level;
        this.SkillPoints = player.SkillPoints;
        this.Health = player.Health;
        this.Attack = player.Attack;
        this.Defense = player.Defense;
    }

    // GameState mengupdate state dari player etc
    public void UpdateGame() {

    }
}

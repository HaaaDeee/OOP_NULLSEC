using System;
using System.IO;
using System.Text.Json;

/*
    Game Manager
    Fungsi utama adalah untuk logika saving dan loading
    Menggunakan class GameState sebagai holder data yang perlu di-save

    -. Saving
        State:
            Update GameState => Serialize JSON => Simpan ke file (overwrite)
        
    -. Loading
        State:
            Load dari file pilihan => Deserialize JSON => Update GameState
*/

public class GameManager
{
    StreamReader loader;
    StreamWriter saver;
    GameState gameState = new GameState();
    
    public void SaveGame(int choice)
    {
        try
        {
            // if (File.Exists(filepath)) {
                Console.WriteLine("Trying to update");
                UpdateGameState();
                Console.WriteLine("Update");
                string json = JsonSerializer.Serialize(gameState);
                Console.WriteLine("Serialized json: " + json);
                saver = new StreamWriter("/src/Saves/savefile1.json");
                saver.WriteLine(json);
                Console.WriteLine("Saved");
            // } else {
            //     Console.WriteLine("No saved game found.");
            // }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving game: {ex.Message}");
        }
    }

    public void LoadGame(int choice)
    {
        try
        {
            // if (File.Exists(filepath))
            // {
                // string json = File.ReadAllText(filepath);
                // GameState? state = JsonSerializer.Deserialize<GameState>(json);
                GameStateUpdate();
                Console.WriteLine("Game loaded.");
            // }
            // else
            // {
            //     Console.WriteLine("No saved game found.");
            // }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading game: {ex.Message}");
        }
    }
    
    // Data dari {Player, etc.} mengupdate GameState
    private void UpdateGameState() {
        PlayerCharacter player = PlayerCharacter.GetInstance();
        gameState.CharacterName = new string(player.CharacterName);
        gameState.TechTree = new string(player.TechTree);
        gameState.Level = player.Level;
        gameState.SkillPoints = player.SkillPoints;
        gameState.Health = player.Health;
        gameState.Attack = player.Attack;
        gameState.Defense = player.Defense;
    }

    // Data dari GameState mengupdate {player, etc.}
    private void GameStateUpdate() {
        PlayerCharacter player = PlayerCharacter.GetInstance();
        player.CharacterName = new string(gameState.CharacterName);
        player.TechTree = new string(gameState.TechTree);
        player.Level = gameState.Level;
        player.SkillPoints = gameState.SkillPoints;
        player.Health = gameState.Health;
        player.Attack = gameState.Attack;
        player.Defense = gameState.Defense;
    }
}

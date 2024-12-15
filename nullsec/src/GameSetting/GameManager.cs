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

class GameState
{
    public string? CharacterName { get; set; }
    public string? TechTree { get; set; }
    public int Level { get; set; }
    public int SkillPoints { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
}

public class GameManager
{
    StreamReader loader;
    StreamWriter saver;
    GameState gameState = new GameState();
    
    public void SaveGame(int choice)
    {
        try
        {
            if (choice > 0 && choice < 4) {
                UpdateGameState();
                string json = JsonSerializer.Serialize(gameState);
                string filepath = "savefile"+choice+".json";
                File.WriteAllText(filepath, json);
                Console.Clear();
            } else {
                Console.WriteLine("No save file found.");
                Console.ReadKey();
            }
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
            if (choice > 0 && choice < 4) {
                string filepath = "savefile"+choice+".json";
                string json = File.ReadAllText(filepath);
                Console.Clear();
                if(!string.IsNullOrEmpty(json)) {
                    gameState = JsonSerializer.Deserialize<GameState>(json);
                    GameStateUpdate();
                } else {
                    Console.WriteLine("Save file tidak ada isinya.");
                    Console.ReadKey();
                }
            } else {
                Console.WriteLine("No save file found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading game: {ex.Message}");
        }
    }
    
    public void LoadPreviousGame()
    {
        try
        {
            string last = File.ReadAllText("last.txt");
            if(!string.IsNullOrEmpty(last)) {
                int choice;
                Int32.TryParse(last, out choice);
                string filepath = "savefile"+choice+".json";
                string json = File.ReadAllText(filepath);
                Console.Clear();
                if(!string.IsNullOrEmpty(json)) {

                    gameState = JsonSerializer.Deserialize<GameState>(json);
                    GameStateUpdate();
                } else {
                    Console.WriteLine("Save file tidak ada isinya.");
                    Console.ReadKey();
                }
            } else {
                Console.WriteLine("Save file tidak ada isinya.");
                Console.ReadKey();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading game: {ex.Message}");
        }
    }

    // Data dari {Player, etc.} mengupdate GameState
    private void UpdateGameState() {
        PlayerCharacter player = PlayerCharacter.GetInstance();
        gameState.CharacterName = player.CharacterName;
        gameState.TechTree = player.TechTree;
        gameState.Level = player.Level;
        gameState.SkillPoints = player.SkillPoints;
        gameState.Health = player.Health;
        gameState.Attack = player.Attack;
        gameState.Defense = player.Defense;
    }

    // Data dari GameState mengupdate {player, etc.}
    private void GameStateUpdate() {
        PlayerCharacter player = PlayerCharacter.GetInstance();
        player.CharacterName = gameState.CharacterName;
        player.TechTree = gameState.TechTree;
        player.Level = gameState.Level;
        player.SkillPoints = gameState.SkillPoints;
        player.Health = gameState.Health;
        player.Attack = gameState.Attack;
        player.Defense = gameState.Defense;
    }
}
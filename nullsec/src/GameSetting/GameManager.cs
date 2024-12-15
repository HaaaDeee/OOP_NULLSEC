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
    public List<string>  Items { get; set; }
}

public class GameManager
{
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
                    gameState.Items = new List<string>();
                    gameState = JsonSerializer.Deserialize<GameState>(json);
                    GameStateUpdate();
                    UI.GameScene();
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
                gameState.Items = new List<string>();
                int choice;
                Int32.TryParse(last, out choice);
                string filepath = "savefile"+choice+".json";
                string json = File.ReadAllText(filepath);
                Console.Clear();
                if(!string.IsNullOrEmpty(json)) {

                    gameState = JsonSerializer.Deserialize<GameState>(json);
                    GameStateUpdate();
                    UI.GameScene();
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
        gameState.Items = new List<string>();
        gameState.CharacterName = player.CharacterName;
        gameState.TechTree = player.TechTree;
        gameState.Level = player.Level;
        gameState.SkillPoints = player.SkillPoints;
        gameState.Health = player.MaxHealth;
        gameState.Attack = player.MaxAttack;
        gameState.Defense = player.MaxDefense;
        foreach(Item item in player.inventory.items) {
            string name = item.name;
            switch(name) {
                case "Health Boost":
                    gameState.Items.Add("Health Boost");
                    break;
                case "Attack Boost":
                    gameState.Items.Add("Attack Boost");
                    break;
                default:
                    break;
            }
        }
    }

    // Data dari GameState mengupdate {player, etc.}
    private void GameStateUpdate() {
        PlayerCharacter player = PlayerCharacter.GetInstance();
        player.CharacterName = gameState.CharacterName;
        player.TechTree = gameState.TechTree;
        player.Level = gameState.Level;
        player.SkillPoints = gameState.SkillPoints;
        player.MaxHealth = gameState.Health;
        player.MaxAttack = gameState.Attack;
        player.MaxDefense = gameState.Defense;
        player.Health = player.MaxHealth;
        player.Attack = player.MaxAttack;
        foreach(string item in gameState.Items) {
            switch(item) {
                case "Health Boost":
                    player.inventory.AddItem(new HealthBoost());
                    break;
                case "Attack Boost":
                    player.inventory.AddItem(new AttackBoost());
                    break;
                default:
                    break;
            }
        }
    }
}
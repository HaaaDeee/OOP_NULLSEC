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
    GameState gameState = GameState.GetInstance();
    public void SaveGame(string filepath)
    {
        try
        {
            if (File.Exists(filepath)) {
                gameState.UpdateSelf();
                string json = JsonSerializer.Serialize(gameState);
                File.WriteAllText(filepath, json);
                Console.WriteLine("Game saved.");
            } else {
                Console.WriteLine("No saved game found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving game: {ex.Message}");
        }
    }

    public  void LoadGame(string filepath)
    {
        try
        {
            if (File.Exists(filepath))
            {
                string json = File.ReadAllText(filepath);
                GameState? state = JsonSerializer.Deserialize<GameState>(json);
                gameState.UpdateGame();
                Console.WriteLine("Game loaded.");
            }
            else
            {
                Console.WriteLine("No saved game found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading game: {ex.Message}");
        }
    }
}

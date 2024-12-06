using System;
using System.IO;
using System.Text.Json;

public static class GameManager
{
    public static void SaveGame(GameState state, string filepath)
    {
        try
        {
            string json = JsonSerializer.Serialize(state);
            File.WriteAllText(filepath, json);
            Console.WriteLine("Game saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving game: {ex.Message}");
        }
    }

    public static GameState? LoadGame(string filepath)
    {
        try
        {
            if (File.Exists(filepath))
            {
                string json = File.ReadAllText(filepath);
                GameState? state = JsonSerializer.Deserialize<GameState>(json);
                Console.WriteLine("Game loaded.");
                return state;
            }
            else
            {
                Console.WriteLine("No saved game found.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading game: {ex.Message}");
            return null;
        }
    }
}

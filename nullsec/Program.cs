using System;
public class Program
{
    public static void Main()
    {
        // Inisialisasi UI
        UI ui = UI.GetInstance();

        // Logika main menu
        // Entry point kedalam game
        int choice = -999;
        ConsoleKeyInfo input;
        Console.Clear();
        while (choice != 4) {
            UI.MainMenu();
            input = Console.ReadKey();
            Int32.TryParse(input.KeyChar.ToString(), out choice);
            Console.Clear();
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine("Apakah anda ingin memulai game baru?");
                    System.Console.WriteLine("Pencet enter bila ya, selainnya bila tidak");
                    if(Console.ReadKey().Key == ConsoleKey.Enter) {
                        UI.NewGame();
                        UI.GameScene();
                    } else {
                        Console.Clear();
                    }
                    break;
                case 2:
                    System.Console.WriteLine("Apakah anda ingin melanjutkan save sebelumnya?");
                    System.Console.WriteLine("Pencet enter bila ya, selainnya bila tidak");
                    if(Console.ReadKey().Key == ConsoleKey.Enter) {
                        ContinueGame();
                    } else {
                        Console.Clear();
                    }
                    break;
                case 3:
                    LoadGame();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Mohon hanya pilih opsi yang tersedia.");
                    break;
            }
        }
        Console.WriteLine("SAMPAI_JUMPA.");
    }

    public static void ContinueGame() {
        Console.Write("Loading Last Savefile");
        for(int i=0; i<5; i++) {
            Console.Write("=>");
            System.Threading.Thread.Sleep(400);
        }
        Console.Clear();
    }

    public static void LoadGame() {
        int choice = -999;
        while(choice != 4) {
            Console.WriteLine("Pilih slot file mana yang ingin dipilih");
            Console.WriteLine("1. Save 1");
            Console.WriteLine("2. Save 2");
            Console.WriteLine("3. Save 3");
            Console.WriteLine("4. Kembali ke menu utama");
            Console.Write    ("  Pilihan anda: ");
            string? input = Console.ReadLine();
            Int32.TryParse(input, out choice);
            Console.Clear();
        }
    }
}
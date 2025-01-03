using System;

public class UI
{
    public static UI? instance = null;
    private static PlayerCharacter? player = null;

    private UI() {
        instance = this;
    }

    public static UI GetInstance()
    {
        if (instance == null)
        {
            return new UI();
        }
        else
        {
            return instance;
        }
    }

    public static int BattleManager<T>(PlayerCharacter player, T enemy) where T: Enemy
    {
        Console.WriteLine("Enemy :");
        Console.WriteLine(enemy.Faction);
        Console.WriteLine("Health : " + enemy.Health + "/" + enemy.MaxHealth);
        Console.WriteLine("============================================");
        Console.WriteLine("Player: ");
        Console.WriteLine(player.CharacterName);
        Console.WriteLine("Health : " + player.Health + "/" + player.MaxHealth);
        Console.WriteLine("============================================");
        Console.WriteLine("Pilihan Aksi : ");
        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Inventory"); //skill (bisa di skip)
        Console.WriteLine("3. Kabur");
        Console.WriteLine("============================================");
        Console.WriteLine("Pilihan anda :");
        string? choice = Console.ReadLine();
        int int_choice;
        Int32.TryParse(choice, out int_choice);
        return int_choice;
    }
    
    public static void NewGame() {
        string[] line1 = {
            "\"Selamat", " Datang", " di ", "SYS", " HO", "-RI", "-ZON...\"\n",
            "\"Karena ", "anda ", "sudah ", "sehat, ", "silahkan ", "keluar ", "gedung ", "ini.\"\n"
            };

        Console.Write("Loading New Game\n{");
        for(int i=0; i<5; i++) {
            Console.Write("=>");
            System.Threading.Thread.Sleep(400);
        }
        Console.WriteLine("}");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Kamu terbangun di sebuah ranjang di sebuah ruangan yang kumuh.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Kepalamu terasa pusing.");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Tiba-tiba masuk sebuah robot kedalam ruangan dimana kamu berada.");
        System.Threading.Thread.Sleep(3000);
        for(int i=0; i<line1.Length; i++) {
            Console.Write(line1[i]);
            System.Threading.Thread.Sleep(800);
        }
        Console.WriteLine("Sebut robot itu.");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("\"Tunggu sebentar! Aku baru saja bangun!\"");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Kamu dikeluarkan dari gedung tersebut dengan paksa.");
        Console.WriteLine("Tanpa ada bawaan apapun, kecuali apa yang ada di-dalam pakaianmu.");
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("Kamu merogoh kedalam kantongmu, terdapat sebuah kartu putih bersih dengan");
        Console.WriteLine(" tulisan yang berlapis emas dengan tulisan \"NULL_SEC\" lengkap dengan sebuah alamat.");
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("Tanpa sadar, kamu menuju alamat tersebut dengan berjalan kaki.");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Herannya, jarak yang perlu ditempuh tidak begitu jauh.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Karena gedung tersebut terletak tepat di seberang gedung tempat anda dikeluarkan.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Dengan waspada kamu memasuki gedung tersebut.");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Kamu melihat dengan resepsionis didepan pintu gedung dan mulai menghampirinya.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\"Selamat datang di NULL SEC, apa yang bisa saya bantu?\"");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Tanpa berkata apapun, kamu menaruh kartu putih tersebut diatas meja resepsionis.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\"Baiklah, mohon ikuti saya.\" Sebut resepsionis tersebut dengan nada yang lebih serius.");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Kamu dibawa kedalam sebuah ruangan.");
        Console.WriteLine("Tidak tahu ruangan apa, yang pasti desainernya sangat menyukai konsep brutalisme.");
        System.Threading.Thread.Sleep(5000);
        Console.WriteLine("Kamu dihampiri oleh seseorang dari belakang.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\"Selamat datang di NULL SEC!\", ucapnya.");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("\"Disini kamu akan bekerja untuk kami. Kami punya berbagai misi yang bisa kamu lakukan.\"");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\"Kami telah menyelamatkanmu, jadi setidaknya ini adalah bayaranmu kepada kami.\"");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\"Tenang saja, kami memiliki berbagai fasilitas yang bisa membantumu bekerja.\"");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\"Untuk mulai, kamu hanya perlu tanda-tangan disini saja, jangan lupa centang Tech Tree yang ingin kamu pilih\"\n");
        System.Threading.Thread.Sleep(4000);
        Console.WriteLine("    PERSETUJUAN PEKERJA");
        Console.WriteLine("    ...");
        Console.WriteLine("    dengan pilihan Tech-Tree sebagai berikut:");
        Console.WriteLine("      1. Technician");
        Console.WriteLine("      2. Hacker");
        Console.WriteLine("      3. Enforcer");
        Console.WriteLine("      4. Infiltrator\n\n");
        Console.Write    ("    Nama: ");
        string? playerName = null;
        while(string.IsNullOrEmpty(playerName)) {
            playerName = Console.ReadLine();
        }

        string? tech_tree = null;
        Console.Write    ("    Tech Tree: ");
        do
        {
            tech_tree = Console.ReadLine();
            if (!string.IsNullOrEmpty(playerName)) {
                if(
                    (tech_tree.ToLower() == "technician") || (tech_tree.ToLower() == "hacker") ||
                    (tech_tree.ToLower() == "enforcer") || (tech_tree.ToLower() == "infiltrator"))
                {
                    break;
                }
            }
        } while (true);
        Console.WriteLine("\n\"Baiklah, kamu sudah mulai bisa mendapatkan pekerjaan besok hari. Selamat datang. di NULL SEC\" sebut orang tersebut");
        player = PlayerCharacter.GetInstance(playerName, tech_tree);
        Console.Clear();
        // Dari sini pindah ke UI GameScene
    }

    public static void MainMenu() {
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
        Console.WriteLine("|  Selamat datang di NULL_SEC!          |");
        Console.WriteLine("|-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-|");
        Console.WriteLine("| Silhakan pilih opsi yang tersedia:    |");
        Console.WriteLine("| 1. Game Baru                          |");
        Console.WriteLine("| 2. Lanjut Game Sebelmnya              |");
        Console.WriteLine("| 3. Pilih Save File                    |");
        Console.WriteLine("| 4. Keluar                             |");
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }

    public static void GameScene() {
        int choice = -999;
        ConsoleKeyInfo input;
        Console.WriteLine();
        player = PlayerCharacter.GetInstance();
        string[] menus = [
            "#######################################################",
            "######                                           ######",
            "###                                                 ###",
            "##       1. LIHAT STATUS                             ##",
            "##       2. ATUR SKILLPOINT                          ##",
            "##       3. PILIH MISI                               ##",
            "##       4. LIHAT INVENTORY                          ##",
            "##       5. SIMPAN PERMAINAN                         ##",
            "##       6. KELUAR DARI PERMAINAN                    ##",
            "###                                                 ###",
            "######                                           ######",
            "#######################################################"
        ];
        while(choice != 6) {
            for(int i = 0; i<menus.Length; i++) {
                Console.WriteLine(menus[i]);
            }
            input = Console.ReadKey();
            Int32.TryParse(input.KeyChar.ToString(), out choice);
            Console.Clear();
            switch (choice)
            {
                case 1:
                    ShowStatus();
                    break;
                case 2:
                    ApplySkillPoints();
                    break;
                case 3:
                    SelectMission();
                    break;
                case 4:
                    ShowInventory();
                    break;
                case 5:
                    SaveGame();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("    !!PERHATIAN!!\n    Mohon hanya pilih opsi yang tersedia.");
                    break;
            }
            Console.Clear();
        }
    }

    private static void ShowStatus() {
        if(player == null) {
            throw new Exception("Player is null");
        }
        player.DisplayStatus();
        Console.ReadKey();
    }

    private static void ApplySkillPoints() {
        if(player == null) {
            throw new Exception("Player is null");
        }
        ConsoleKeyInfo input;
        int choice = -999;
        while(choice != 4) {
            Console.WriteLine("Status Player saat ini");
            player.DisplayStatus();
            Console.WriteLine("Pilih stats yang anda ingin tambah menggunakan skill point yang tersedia");
            Console.WriteLine("1. Health");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Defense");
            Console.WriteLine("\n4. Kembali ke main menu");
            input = Console.ReadKey();
            Int32.TryParse(input.KeyChar.ToString(), out choice);
            switch(choice) {
                case 1:
                    player.AllocateSkillPoint("health");
                    break;
                case 2:
                    player.AllocateSkillPoint("attack");
                    break;
                case 3:
                    player.AllocateSkillPoint("defense");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void SelectMission() {
        QuestManager questManager = new QuestManager();
        BattleManager battleManager;
        ConsoleKeyInfo input;
        int choice = -1;
        // Generate enemy list
        questManager.GenerateEnemyList();
        Console.WriteLine("Daftar Quest:");
        questManager.ShowQuests();
        while(choice < 1 || choice > 3) {
            Console.WriteLine("Pilih Quest:");
            input = Console.ReadKey();
            Int32.TryParse(input.KeyChar.ToString(), out choice);
            if(choice < 1 || choice > 3) {
                Console.WriteLine("Invalid quest number");
            }
        }
        battleManager = new BattleManager(questManager.takeQuest(choice));
        battleManager.StartBattle();
    }

    private static void ShowInventory() {
        PlayerCharacter player = PlayerCharacter.GetInstance();
        Console.WriteLine("Your Inventory:");
        foreach(Item item in player.inventory.items) {
            Console.WriteLine(item.name);
        }
        Console.ReadKey();
    }

    private static void SaveGame() {
        int choice = -1;
        ConsoleKeyInfo input;
        GameManager gameManager = new GameManager();
        while(choice < 1 || choice > 3) {
            Console.Clear();
            Console.WriteLine("Pilih slot file untuk menyimpan permainan");
            Console.WriteLine("1. Save 1");
            Console.WriteLine("2. Save 2");
            Console.WriteLine("3. Save 3");
            input = Console.ReadKey();
            Int32.TryParse(input.KeyChar.ToString(), out choice);
            if(choice < 1 || choice > 3) {
                Console.WriteLine("Mohon hanya pilih opsi yang tersedia.");
            }
        }
        gameManager.SaveGame(choice);
        File.WriteAllText("last.txt", choice.ToString());
        Console.Write("\nSaving game to slot "+choice+"\n{");
        for(int i=0; i<5; i++) {
            Console.Write("=>");
            System.Threading.Thread.Sleep(400);
        }
        Console.WriteLine("}");
        Console.WriteLine("Game berhasil disimpan.");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
    }

    public static int ChooseItem() {
        int choice = -1;
        ConsoleKeyInfo input;
        int healthcount = 0;
        int attackcount = 0;
        foreach(Item item in player.inventory.items) {
            switch(item.name) {
                case "Health Boost":
                    healthcount++;
                    break;
                case "Attack Boost":
                    attackcount++;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine("Anda memiliki:");
        Console.WriteLine("1. "+healthcount.ToString()+"x Health Boost");
        Console.WriteLine("2. "+attackcount.ToString()+"x Attack Boost");
        Console.WriteLine("Pilihan anda:");
        while(choice < 1 || choice > 2) {
            input = Console.ReadKey();
            Int32.TryParse(input.KeyChar.ToString(), out choice);
            if((choice == 1 && healthcount > 0) || (choice == 2 && attackcount > 0)) {
                return choice;
            } else {
                Console.WriteLine("Item tidak cukup");
            }
        }
        return -1;
    }
}
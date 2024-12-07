using System;
public class Program
{
    public static void Main()
    {
        int choice = -999;
        while (choice != 4) {
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.WriteLine("|  Selamat datang di NULL_SEC!          |");
            Console.WriteLine("|-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-|");
            Console.WriteLine("| Silhakan pilih opsi yang tersedia:    |");
            Console.WriteLine("| 1. Game Baru                          |");
            Console.WriteLine("| 2. Lanjut Game Sebelmnya              |");
            Console.WriteLine("| 3. Pilih Save File                    |");
            Console.WriteLine("| 4. Keluar                             |");
            Console.WriteLine("|-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-|"); 
            Console.Write    ("  Pilihan anda: ");
            string input = Console.ReadLine();
            Int32.TryParse(input, out choice);
            Console.Clear();
            switch (choice)
            {
                case 1:
                    System.Console.WriteLine("Apakah anda ingin memulai game baru?");
                    System.Console.WriteLine("Pencet enter bila ya, selainnya bila tidak");
                    if(Console.ReadKey().Key == ConsoleKey.Enter) {
                        NewGame();
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
        string? player = null;
        while(string.IsNullOrEmpty(player)) {
            player = Console.ReadLine();
        }

        string? tech_tree = null;
        Console.Write    ("    Tech Tree: ");
        do
        {
            tech_tree = Console.ReadLine();
        } while ((tech_tree.ToLower() != "technician") &&
                (tech_tree.ToLower() != "hacker") &&
                (tech_tree.ToLower() != "enforcer") &&
                (tech_tree.ToLower() != "infiltrator"));
        Console.WriteLine("\n\"Baiklah, kamu sudah mulai bisa mendapatkan pekerjaan besok hari. Selamat datang. di NULL SEC\" sebut orang tersebut");
        PlayerCharacter.GetInstance(player, tech_tree);
        // Dari sini pindah ke UI gameplay
    }

    public static void ContinueGame() {
        Console.Write("Loading Last Savefile\n{");
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
            string input = Console.ReadLine();
            Int32.TryParse(input, out choice);
            Console.Clear();
        }
    }
}
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
            Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
            Console.Clear();
            switch (choice)
            {
                case 1:
                NewGame();
                    break;
                case 2:
                    break;
                case 3:
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
        for(int i=0; i<10; i++) {
            Console.Write("=>");
            System.Threading.Thread.Sleep(500);
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
        System.Threading.Thread.Sleep(2000);
        for(int i=0; i<line1.Length; i++) {
            Console.Write(line1[i]);
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine("Sebut robot itu.");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("\"Tunggu sebentar! Aku baru saja bangun!\"");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("...");
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine("Kamu dikeluarkan dari gedung tersebut dengan paksa.");
        Console.WriteLine("Tanpa ada bawaan apapun, kecuali apa yang ada di-dalam pakaianmu.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Kamu merogoh kedalam kantongmu, terdapat sebuah kartu putih bersih dengan");
        Console.WriteLine(" tulisan yang berlapis emas dengan tulisan \"NULL_SEC\" lengkap dengan sebuah alamat.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("Tanpa sadar, kamu menuju alamat tersebut dengan berjalan kaki.");
        Console.WriteLine("Herannya jarak yang perlu ditempuh tidak begitu jauh.");
        Console.WriteLine("Karena gedung tersebut terletak tepat di seberang gedung tempat anda dikeluarkan.");
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine(".");
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+");
    }

    public static void ContinueGame() {

    }

    public static void LoadGame(int choice) {

    }
}
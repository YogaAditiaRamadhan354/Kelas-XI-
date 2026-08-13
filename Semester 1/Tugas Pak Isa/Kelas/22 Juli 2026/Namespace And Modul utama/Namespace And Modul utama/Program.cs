using System;

namespace tugas1
{
    class Kalkulator
    {
        public static int Tambah(int x, int y) => x + y;
        public static int Kurang(int x, int y) => x - y;
        public static int Kali(int x, int y) => x * y;
        public static double Bagi(double x, double y) => x / y;

        public static void Eksekusi()
        {
            Console.Clear();
            Console.WriteLine("=== MENU KALKULATOR ===");
            Console.Write("Masukkan angka pertama: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan angka kedua  : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n--- HASIL PERHITUNGAN ---");
            Console.WriteLine($"Tambah         : {Kalkulator.Tambah(a, b)}");
            Console.WriteLine($"Kurang         : {Kalkulator.Kurang(a, b)}");
            Console.WriteLine($"Kali           : {Kalkulator.Kali(a, b)}");

            if (b == 0)
                Console.WriteLine("Bagi           : Tidak dapat membagi dengan nol");
            else
                Console.WriteLine($"Bagi           : {Kalkulator.Bagi(a, b):F2}");

            Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
            Console.ReadKey();
        }
    }

    class BangunDatar
    {
        public static double LuasPersegi(double sisi) => sisi * sisi;
        public static double LuasPersegiPanjang(double panjang, double lebar) => panjang * lebar;
        public static double LuasSegitiga(double alas, double tinggi) => 0.5 * alas * tinggi;
        public static double LuasLingkaran(double jariJari) => Math.PI * jariJari * jariJari;

        public static void Eksekusi()
        {
            Console.Clear();
            Console.WriteLine("=== MENU BANGUN DATAR ===");

            Console.Write("Masukkan sisi persegi   : ");
            double sisi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan panjang persegi panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar persegi panjang  : ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan alas segitiga  : ");
            double alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi segitiga: ");
            double tinggi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan jari-jari lingkaran: ");
            double jariJari = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- HASIL LUAS ---");
            Console.WriteLine($"Luas Persegi   : {BangunDatar.LuasPersegi(sisi)}");
            Console.WriteLine($"Luas Persegi Panjang : {BangunDatar.LuasPersegiPanjang(panjang, lebar)}");
            Console.WriteLine($"Luas Segitiga  : {BangunDatar.LuasSegitiga(alas, tinggi)}");
            Console.WriteLine($"Luas Lingkaran : {BangunDatar.LuasLingkaran(jariJari):F2}");

            Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
            Console.ReadKey();
        }
    }

    class BangunRuang
    {
        public static double VolumeKubus(double sisi) => sisi * sisi * sisi;
        public static double VolumeBalok(double panjang, double lebar, double tinggi) => panjang * lebar * tinggi;
        public static double VolumeTabung(double jariJari, double tinggi) => Math.PI * jariJari * jariJari * tinggi;

        public static void Eksekusi()
        {
            Console.Clear();
            Console.WriteLine("=== MENU BANGUN RUANG ===");

            Console.Write("Masukkan sisi kubus     : ");
            double sisi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan panjang balok  : ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar balok    : ");
            double lebar = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi balok   : ");
            double tinggiBalok = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan jari-jari tabung: ");
            double jariJari = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan tinggi tabung  : ");
            double tinggiTabung = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n--- HASIL VOLUME ---");
            Console.WriteLine($"Volume Kubus   : {BangunRuang.VolumeKubus(sisi)}");
            Console.WriteLine($"Volume Balok   : {BangunRuang.VolumeBalok(panjang, lebar, tinggiBalok)}");
            Console.WriteLine($"Volume Tabung  : {BangunRuang.VolumeTabung(jariJari, tinggiTabung):F2}");

            Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
            Console.ReadKey();
        }
    }

    class Zodiak
    {
        public static void CekZodiak()
        {
            Console.Clear();
            Console.WriteLine("=== MENU ZODIAK ===");
            Console.Write("Masukkan tanggal lahir (1-31): ");
            int tanggal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Masukkan bulan lahir (1-12)  : ");
            int bulan = Convert.ToInt32(Console.ReadLine());

            string namaZodiak = GetNamaZodiak(tanggal, bulan);
            Console.WriteLine($"\nZodiak Anda adalah           : {namaZodiak}");

            Console.WriteLine("\nTekan tombol apa saja untuk kembali ke menu...");
            Console.ReadKey();
        }

        private static string GetNamaZodiak(int tanggal, int bulan)
        {
            if ((bulan == 3 && tanggal >= 21) || (bulan == 4 && tanggal <= 19)) return "Aries";
            if ((bulan == 4 && tanggal >= 20) || (bulan == 5 && tanggal <= 20)) return "Taurus";
            if ((bulan == 5 && tanggal >= 21) || (bulan == 6 && tanggal <= 20)) return "Gemini";
            if ((bulan == 6 && tanggal >= 21) || (bulan == 7 && tanggal <= 22)) return "Cancer";
            if ((bulan == 7 && tanggal >= 23) || (bulan == 8 && tanggal <= 22)) return "Leo";
            if ((bulan == 8 && tanggal >= 23) || (bulan == 9 && tanggal <= 22)) return "Virgo";
            if ((bulan == 9 && tanggal >= 23) || (bulan == 10 && tanggal <= 22)) return "Libra";
            if ((bulan == 10 && tanggal >= 23) || (bulan == 11 && tanggal <= 21)) return "Scorpio";
            if ((bulan == 11 && tanggal >= 22) || (bulan == 12 && tanggal <= 21)) return "Sagittarius";
            if ((bulan == 12 && tanggal >= 22) || (bulan == 1 && tanggal <= 19)) return "Capricorn";
            if ((bulan == 1 && tanggal >= 20) || (bulan == 2 && tanggal <= 18)) return "Aquarius";
            if ((bulan == 2 && tanggal >= 19) || (bulan == 3 && tanggal <= 20)) return "Pisces";
            return "Tidak Valid";
        }
    }

    class MenuUtama
    {
        public static void TampilkanMenu()
        {
            bool berjalan = true;
            while (berjalan)
            {
                Console.Clear();
                Console.WriteLine("=======================================");
                Console.WriteLine("             MENU PROGRAM              ");
                Console.WriteLine("=======================================");
                Console.WriteLine("1. Jalankan Kalkulator");
                Console.WriteLine("2. Hitung Bangun Datar");
                Console.WriteLine("3. Hitung Bangun Ruang");
                Console.WriteLine("4. Cek Zodiak");
                Console.WriteLine("5. Keluar Aplikasi");
                Console.WriteLine("=======================================");
                Console.Write("Pilih menu (1-5): ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        Kalkulator.Eksekusi();
                        break;
                    case "2":
                        BangunDatar.Eksekusi();
                        break;
                    case "3":
                        BangunRuang.Eksekusi();
                        break;
                    case "4":
                        Zodiak.CekZodiak();
                        break;
                    case "5":
                        berjalan = false;
                        Console.WriteLine("\nTerima kasih telah menggunakan program ini!");
                        break;
                    default:
                        Console.WriteLine("\nPilihan tidak valid! Silakan tekan tombol apa saja untuk mencoba lagi.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MenuUtama.TampilkanMenu();
        }
    }
}
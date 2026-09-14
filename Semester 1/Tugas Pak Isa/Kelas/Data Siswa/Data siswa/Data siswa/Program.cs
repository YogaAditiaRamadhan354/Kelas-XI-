using System;

namespace Data_siswa
{
    class Home
    {
        static void Main()
        {
            Nilai nil = new Nilai();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine("====  Data Siswa ====");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Identitas");
                Console.WriteLine("2. Mapel");
                Console.WriteLine("3. Absen");
                Console.WriteLine("4. Nilai");
                Console.WriteLine("0. Keluar");
                Console.WriteLine("---------------------");
                Console.Write("Pilih opsi (0-4): ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        MenuIdentitas();
                        break;

                    case "2":
                        MenuMapel();
                        break;

                    case "3":
                        MenuAbsen();
                        break;

                    case "4":
                        nil.TampilanNilai();
                        break;

                    case "0":
                        Console.WriteLine("Program selesai...");
                        return;

                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MenuIdentitas()
        {
            Identitas identitas = new Identitas();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine("===== IDENTITAS =====");
                Console.WriteLine("---------------------");
                Console.WriteLine("1. Siswa");
                Console.WriteLine("2. Wali");
                Console.WriteLine("3. Sekolah");
                Console.WriteLine("0. Kembali");
                Console.WriteLine("--------------------");
                Console.Write("Pilih opsi: ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        Console.Clear();
                        identitas.Siswa();
                        Console.WriteLine("Tekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        identitas.Wali();
                        Console.WriteLine("\nTekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        identitas.Sekolah();
                        Console.WriteLine("\nTekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MenuMapel()
        {
            Mapel mapel = new Mapel();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("====== MAPEL =======");
                Console.WriteLine("--------------------");
                Console.WriteLine("1. Produktif");
                Console.WriteLine("2. Non Produktif");
                Console.WriteLine("0. Kembali");
                Console.WriteLine("--------------------");
                Console.Write("Pilih opsi: ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        Console.Clear();
                        mapel.Produktif();
                        Console.WriteLine("\nTekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        mapel.NonProduktif();
                        Console.WriteLine("\nTekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MenuAbsen()
        {
            Absen absen = new Absen();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--------------------");
                Console.WriteLine("====== ABSEN =======");
                Console.WriteLine("--------------------");
                Console.WriteLine("1. Januari");
                Console.WriteLine("2. Februari");
                Console.WriteLine("3. Maret");
                Console.WriteLine("0. Kembali");
                Console.WriteLine("--------------------");
                Console.Write("Pilih opsi: ");

                string pilihan = Console.ReadLine();

                switch (pilihan)
                {
                    case "1":
                        Console.Clear();
                        absen.Januari();
                        Console.WriteLine("\nTekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.Clear();
                        absen.Februari();
                        Console.WriteLine("\nTekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        absen.Maret();
                        Console.WriteLine("\nTekan Enter untuk kembali...");
                        Console.ReadLine();
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Pilihan tidak valid!");
                        Console.ReadKey();
                        break;
                }
            }
        }

       
    }


    class Identitas
    {
        public void Siswa()
        {
            Console.WriteLine("Nama   : Yoga Aditia");
            Console.WriteLine("Kelas  : XI RPL");
            Console.WriteLine("No Telp: 08123456789");
            Console.WriteLine("Alamat : Urangagung, Sidoarjo");
        }

        public void Wali()
        {
            Console.WriteLine("Nama Wali  : Bapak Yoga");
            Console.WriteLine("NIK Wali   : 987654321");
            Console.WriteLine("No Telp    : 08123456789");
            Console.WriteLine("Alamat Wali: Urangagung, Sidoarjo");
        }

        public void Sekolah()
        {
            Console.WriteLine("Sekolah       : SMKN 2 Buduran");
            Console.WriteLine("Alamat Sekolah: Jl. Raya Buduran No. 123, Sidoarjo");
            Console.WriteLine("NIS           : 123456789");
        }
    }


    class Mapel
    {
        public void Produktif()
        {
            Console.WriteLine("==== Mapel Produktif ====");
            Console.WriteLine("1. Matematika");
            Console.WriteLine("2. Pemrograman");
            Console.WriteLine("3. Bahasa Indonesia");
            Console.WriteLine("4. Bahasa Inggris");
            Console.WriteLine("-------------------------");
        }

        public void NonProduktif()
        {
            Console.WriteLine("==== Mapel Non-Produktif ====");
            Console.WriteLine("1. Pendidikan Agama");
            Console.WriteLine("2.Olahraga");
            Console.WriteLine("3. Sejarah");
            Console.WriteLine("4. Bahasa Jawa");
            Console.WriteLine("-----------------------------");
        }
    }


    class Absen
    {
        public void Januari()
        {
            Console.WriteLine("==== Daftar Absen Januari ===");
            Console.WriteLine("Hadir  : 25");
            Console.WriteLine("Alfa   : 1");
            Console.WriteLine("Izin   : 3");
            Console.WriteLine("Sakit  : 2");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Presentase Kehadiran: 90%");
        }

        public void Februari()
        {
            Console.WriteLine("==== Daftar Absen Februari ===");
            Console.WriteLine("Hadir  : 18");
            Console.WriteLine("Alfa   : 1");
            Console.WriteLine("Izin   : 0");
            Console.WriteLine("Sakit  : 3");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Presentase Kehadiran: 85%");
        }

        public void Maret()
        {
            Console.WriteLine("==== Daftar Absen Maret ===");
            Console.WriteLine("Hadir  : 20");
            Console.WriteLine("Alfa   : 0");
            Console.WriteLine("Izin   : 2");
            Console.WriteLine("Sakit  : 1");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Presentase Kehadiran: 92%");
        }
    }


    class Nilai
    {
        public void TampilanNilai()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mapel Produktif");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Matematika       : 97 A+");
            Console.WriteLine("Pemrograman      : 90 A");
            Console.WriteLine("Bahasa Indonesia : 88 B+");
            Console.WriteLine("Bahasa Inggris   : 90 A");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Mapel Non-Produktif");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Olahraga         : 95 A");
            Console.WriteLine("Sejarah          : 89 B+");
            Console.WriteLine("Bahasa Jawa      : 90 A");
            Console.WriteLine("Pendidikan Agama : 92 A");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Nilai Rata-rata  : 91 A");
        }

      
    }
}

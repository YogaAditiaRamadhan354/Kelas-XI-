using System;

namespace Jadwal
{
    class Home
    {
        static void Main()
        {
            Senin senin = new Senin();
            Selasa selasa = new Selasa();
            Rabu rabu = new Rabu();
            Kamis kamis = new Kamis();
            Jumat jumat = new Jumat();

            Console.WriteLine("===== JADWAL PELAJARAN =====");
            Console.WriteLine();

            Console.WriteLine("[Senin]");
            senin.SesiSatu();
            senin.SesiDua();
            senin.SesiTiga();
            Console.WriteLine();

            Console.WriteLine("[Selasa]");
            selasa.SesiSatu();
            selasa.SesiDua();
            selasa.SesiTiga();
            Console.WriteLine();

            Console.WriteLine("[Rabu]");
            rabu.SesiSatu();
            rabu.SesiDua();
            rabu.SesiTiga();
            Console.WriteLine();

            Console.WriteLine("[Kamis]");
            Kamis.SesiSatu();
            Kamis.SesiDua();
            Kamis.SesiTiga();
            Console.WriteLine();

            Console.WriteLine("[Jumat]");
            Jumat.SesiSatu();
            Jumat.SesiDua();
            Console.WriteLine();

            Console.WriteLine("Tekan ENTER untuk keluar...");
            Console.ReadLine();
        }


        class Senin
        {
            public void SesiSatu()
            {
                Console.WriteLine(" Sesi 1:");
                Console.WriteLine("   Upacara");
                Console.WriteLine("   B.Jepang");
                Console.WriteLine("   B.Inggris");
            }

            public void SesiDua()
            {
                Console.WriteLine(" Sesi 2:");
                Console.WriteLine("   Matematika");
            }

            public void SesiTiga()
            {
                Console.WriteLine(" Sesi 3:");
                Console.WriteLine("   PPLG");
            }
        }


        class Selasa
        {
            public void SesiSatu()
            {
                Console.WriteLine(" Sesi 1:");
                Console.WriteLine("   PKWU");
                Console.WriteLine("   PJOK");
            }

            public void SesiDua()
            {
                Console.WriteLine(" Sesi 2:");
                Console.WriteLine("   B.Indonesia");
            }

            public void SesiTiga()
            {
                Console.WriteLine(" Sesi 3:");
                Console.WriteLine("   PPLG");
            }
        }


        class Rabu
        {
            public void SesiSatu()
            {
                Console.WriteLine(" Sesi 1:");
                Console.WriteLine("   PPLG");
            }

            public void SesiDua()
            {
                Console.WriteLine(" Sesi 2:");
                Console.WriteLine("   PPLG");
            }

            public void SesiTiga()
            {
                Console.WriteLine(" Sesi 3:");
                Console.WriteLine("   PPLG");
                Console.WriteLine("   BK");
            }
        }


        class Kamis
        {
            public  static void SesiSatu()
            {
                Console.WriteLine(" Sesi 1:");
                Console.WriteLine("   B.Jerman");
                Console.WriteLine("   B.Jawa");
            }

            public  static void SesiDua()
            {
                Console.WriteLine(" Sesi 2:");
                Console.WriteLine("   PKWU");
            }

            public static void SesiTiga()
            {
                Console.WriteLine(" Sesi 3:");
                Console.WriteLine("   PAI");
            }
        }


        class Jumat
        {
            public static void SesiSatu()
            {
                Console.WriteLine(" Sesi 1:");
                Console.WriteLine("   B.Inggris");
                Console.WriteLine("   Sej" +
                    "arah");
            }

            public static void SesiDua()
            {
                Console.WriteLine(" Sesi 2:");
                Console.WriteLine("   PP");
            }
        }
    }
}





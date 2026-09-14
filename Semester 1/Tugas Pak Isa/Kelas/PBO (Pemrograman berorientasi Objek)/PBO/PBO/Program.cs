using System;
using System.Security.Cryptography.X509Certificates;
namespace Matematika
{
    class Home
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Belajar PBO");

            Kalkulator Cal = new Kalkulator();
            Cal.Penjumlahan();
            Cal.Pengurangan();
            Cal.Perkalian();
            Cal.Pembagian();

            Bangundatar Bdatar = new Bangundatar();
            Bangundatar.LuasPersegipanjang();
            Bangundatar.KelilingPersegipanjang();
            Bangundatar.LuasLingkaran();

            BangunRuang Bruang = new BangunRuang();
            Bruang.VolumeTabung();
            Bruang.VolumeBalok();
            Bruang.VolumePyramid();


        }
        
        
    }


    class Kalkulator
    {
        public void Penjumlahan()
        {
            Console.WriteLine("Penjumlahan");
        }

        public void Pengurangan()
        {
            Console.WriteLine("Pengurangan");
        }

        public void Perkalian()
        {
            Console.WriteLine("Perkalian");
        }

        public void Pembagian() 
        {
            Console.WriteLine("Pembagian");
        }
    }

    class Bangundatar
    {
        public static void KelilingPersegipanjang()
        {
            Console.WriteLine("");
        }

         public static void LuasPersegipanjang()
        {
            Console.WriteLine("");
        }

        public static void LuasLingkaran()
        {
            Console.WriteLine("");
        }
    }

    class BangunRuang
    {
        public void VolumeBalok()
        {
            Console.WriteLine("Volume Balok");
        }

        public void VolumeTabung()
        {
            Console.WriteLine("Volume Tabung");
        }

        public void VolumePyramid()
        {
            Console.WriteLine("Volume Pyramid");
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==========================================");
            Console.WriteLine("      Modul Ajar Dasar Pemrograman");
            Console.WriteLine("==========================================");
            Console.WriteLine("1.  BAB 1");
            Console.WriteLine("2.  BAB 2");
            Console.WriteLine("3.  BAB 5");
            Console.WriteLine("4.  BAB 6");
            Console.WriteLine("5.  BAB 8");
            Console.WriteLine("6.  BAB 9");
            Console.WriteLine("7.  BAB 10");
            Console.WriteLine("8.  BAB 11");
            Console.WriteLine("9.  BAB 12");
            Console.WriteLine("10. BAB 13");
            Console.WriteLine("11. BAB 14");
            Console.WriteLine("==========================================");
            Console.Write("Pilih Bab: ");

            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1": MenuBab1(); break;
                case "2": MenuBab2(); break;
                case "3": MenuBab5(); break;
                case "4": MenuBab6(); break;
                case "5": MenuBab8(); break;
                case "6": MenuBab9(); break;
                case "7": MenuBab10(); break;
                case "8": MenuBab11(); break;
                case "9": MenuBab12(); break;
                case "10": MenuBab13(); break;
                case "11": MenuBab14(); break;

                default:
                    Salah();
                    break;
            }
        }
    }

    // =====================================================
    // FUNGSI UMUM
    // =====================================================

    static void Judul(string judul)
    {
        Console.Clear();
        Console.WriteLine("==========================================");
        Console.WriteLine(judul);
        Console.WriteLine("==========================================");
    }

    static void Pause()
    {
        Console.WriteLine();
        Console.WriteLine("Tekan ENTER untuk kembali...");
        Console.ReadLine();
    }

    static void Salah()
    {
        Console.WriteLine("Pilihan tidak tersedia!");
        Pause();
    }


    // =====================================================
    // BAB 1
    // =====================================================

    static void MenuBab1()
    {
        while (true)
        {
            Judul("BAB 1 - DASAR PEMROGRAMAN");

            Console.WriteLine("1. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": LatihanBab1(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void LatihanBab1()
    {
        while (true)
        {
            Judul("BAB 1 - LATIHAN");

            Console.WriteLine("1. Perbedaan Hardware dan Software");
            Console.WriteLine("2. Lima Bahasa Pemrograman");
            Console.WriteLine("3. Program Hello World");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Judul("HARDWARE DAN SOFTWARE");
                    Console.WriteLine("Hardware adalah perangkat keras komputer.");
                    Console.WriteLine("Contoh: Keyboard, Mouse, Monitor, CPU.");
                    Console.WriteLine();
                    Console.WriteLine("Software adalah perangkat lunak komputer.");
                    Console.WriteLine("Contoh: Windows, Word, Chrome, Visual Studio.");
                    Pause();
                    break;

                case "2":
                    Judul("LIMA BAHASA PEMROGRAMAN");
                    Console.WriteLine("1. C#");
                    Console.WriteLine("2. Java");
                    Console.WriteLine("3. Python");
                    Console.WriteLine("4. HTML");
                    Console.WriteLine("5. JavaScript");
                    Pause();
                    break;

                case "3":
                    Judul("HELLO WORLD");
                    Console.WriteLine("Console.WriteLine(\"Hello World!\");");
                    Console.WriteLine();
                    Console.WriteLine("Hasil:");
                    Console.WriteLine("Hello World!");
                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 2 - ALGORITMA
    // =====================================================

    static void MenuBab2()
    {
        while (true)
        {
            Judul("BAB 2 - ALGORITMA");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    StudiKasusBab2();
                    break;

                case "2":
                    LatihanBab2();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 2 - STUDI KASUS
    // =====================================================

    static void StudiKasusBab2()
    {
        while (true)
        {
            Judul("BAB 2 - STUDI KASUS");

            Console.WriteLine("1. Login Sederhana");
            Console.WriteLine("2. Menghitung Rata-rata Tiga Nilai");
            Console.WriteLine("3. Menentukan Bilangan Ganjil atau Genap");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    LoginBab2();
                    break;

                case "2":
                    RataRataBab2();
                    break;

                case "3":
                    GanjilGenapBab2();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // LOGIN SEDERHANA
    // =====================================================

    static void LoginBab2()
    {
        Judul("LOGIN SEDERHANA");

        // Username dan password yang benar
        string usernameBenar = "admin";
        string passwordBenar = "12345";

        Console.Write("Masukkan username: ");
        string username = Console.ReadLine();

        Console.Write("Masukkan password: ");
        string password = Console.ReadLine();

        Console.WriteLine();

        if (username == usernameBenar && password == passwordBenar)
        {
            Console.WriteLine("================================");
            Console.WriteLine("       LOGIN BERHASIL!");
            Console.WriteLine("================================");
            Console.WriteLine("Selamat datang, " + username);
        }
        else
        {
            Console.WriteLine("================================");
            Console.WriteLine("        LOGIN GAGAL!");
            Console.WriteLine("================================");
            Console.WriteLine("Username atau password salah.");
        }

        Pause();
    }


    // =====================================================
    // RATA-RATA TIGA NILAI
    // =====================================================

    static void RataRataBab2()
    {
        Judul("MENGHITUNG RATA-RATA TIGA NILAI");

        Console.Write("Masukkan nilai pertama : ");
        double nilai1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan nilai kedua   : ");
        double nilai2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan nilai ketiga  : ");
        double nilai3 = Convert.ToDouble(Console.ReadLine());

        double rataRata = (nilai1 + nilai2 + nilai3) / 3;

        Console.WriteLine();
        Console.WriteLine("Nilai 1   = " + nilai1);
        Console.WriteLine("Nilai 2   = " + nilai2);
        Console.WriteLine("Nilai 3   = " + nilai3);
        Console.WriteLine("----------------------------");
        Console.WriteLine("Rata-rata = " + rataRata);

        Pause();
    }


    // =====================================================
    // GANJIL ATAU GENAP
    // =====================================================

    static void GanjilGenapBab2()
    {
        Judul("MENENTUKAN GANJIL ATAU GENAP");

        Console.Write("Masukkan bilangan: ");
        int angka = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        if (angka % 2 == 0)
        {
            Console.WriteLine(angka + " adalah bilangan GENAP.");
        }
        else
        {
            Console.WriteLine(angka + " adalah bilangan GANJIL.");
        }

        Pause();
    }


    // =====================================================
    // BAB 2 - LATIHAN
    // =====================================================

    static void LatihanBab2()
    {
        while (true)
        {
            Judul("BAB 2 - LATIHAN");

            Console.WriteLine("1. Algoritma Membuat Teh");
            Console.WriteLine("2. Algoritma Menarik Uang di ATM");
            Console.WriteLine("3. Menghitung Luas Segitiga");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AlgoritmaTehBab2();
                    break;

                case "2":
                    AlgoritmaATMBab2();
                    break;

                case "3":
                    LuasSegitigaBab2();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // ALGORITMA MEMBUAT TEH
    // =====================================================

    static void AlgoritmaTehBab2()
    {
        Judul("ALGORITMA MEMBUAT TEH");

        Console.WriteLine("Langkah-langkah:");
        Console.WriteLine("1. Siapkan gelas.");
        Console.WriteLine("2. Masukkan teh ke dalam gelas.");
        Console.WriteLine("3. Panaskan air.");
        Console.WriteLine("4. Tuangkan air panas ke dalam gelas.");
        Console.WriteLine("5. Tambahkan gula secukupnya.");
        Console.WriteLine("6. Aduk hingga rata.");
        Console.WriteLine("7. Teh siap diminum.");

        Pause();
    }


    // =====================================================
    // ALGORITMA MENARIK UANG DI ATM
    // =====================================================

    static void AlgoritmaATMBab2()
    {
        Judul("ALGORITMA MENARIK UANG DI ATM");

        Console.WriteLine("Langkah-langkah:");
        Console.WriteLine("1. Masukkan kartu ATM.");
        Console.WriteLine("2. Masukkan PIN.");
        Console.WriteLine("3. Pilih menu Tarik Tunai.");
        Console.WriteLine("4. Masukkan jumlah uang.");
        Console.WriteLine("5. Sistem memeriksa saldo.");
        Console.WriteLine("6. Jika saldo cukup, uang dikeluarkan.");
        Console.WriteLine("7. Ambil uang.");
        Console.WriteLine("8. Ambil kartu ATM.");
        Console.WriteLine("9. Selesai.");

        Pause();
    }


    // =====================================================
    // LUAS SEGITIGA - BISA DIGUNAKAN
    // =====================================================

    static void LuasSegitigaBab2()
    {
        Judul("MENGHITUNG LUAS SEGITIGA");

        Console.Write("Masukkan alas   : ");
        double alas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan tinggi : ");
        double tinggi = Convert.ToDouble(Console.ReadLine());

        double luas = 0.5 * alas * tinggi;

        Console.WriteLine();
        Console.WriteLine("Alas   = " + alas);
        Console.WriteLine("Tinggi = " + tinggi);
        Console.WriteLine("----------------------------");
        Console.WriteLine("Luas segitiga = " + luas);

        Pause();
    }


    // =====================================================
    // BAB 5
    // =====================================================

    static void MenuBab5()
    {
        while (true)
        {
            Judul("BAB 5");

            Console.WriteLine("1. Mengubah Hello World");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine();
                    Console.WriteLine("Sebelum:");
                    Console.WriteLine("Hello World!");
                    Console.WriteLine();
                    Console.WriteLine("Sesudah:");
                    Console.WriteLine("Yoga Aditia Ramadhan");
                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 6
    // =====================================================

    static void MenuBab6()
    {
        while (true)
        {
            Judul("BAB 6 - CONSOLE");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab6(); break;
                case "2": LatihanBab6(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void StudiKasusBab6()
    {
        while (true)
        {
            Judul("BAB 6 - STUDI KASUS");

            Console.WriteLine("1. Nama Sekolah");
            Console.WriteLine("2. Nama dan Sapaan");
            Console.WriteLine("3. Tiga Baris Informasi");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("SMK / SMA Nama Sekolah");
                    Console.WriteLine("Jurusan Rekayasa Perangkat Lunak");
                    Pause();
                    break;

                case "2":
                    Console.Write("Masukkan nama: ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Halo, " + nama + "!");
                    Pause();
                    break;

                case "3":
                    Console.WriteLine("Nama  : Yoga Aditia Ramadhan");
                    Console.WriteLine("Kelas : XI RPL");
                    Console.WriteLine("Bahasa: C#");
                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void LatihanBab6()
    {
        while (true)
        {
            Judul("BAB 6 - LATIHAN");

            Console.WriteLine("1. Fungsi using System");
            Console.WriteLine("2. Fungsi Main()");
            Console.WriteLine("3. Perbedaan Write() dan WriteLine()");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("using System digunakan untuk mengakses");
                    Console.WriteLine("namespace System, seperti Console.");
                    Pause();
                    break;

                case "2":
                    Console.WriteLine("Main() adalah method utama.");
                    Console.WriteLine("Program mulai dijalankan dari Main().");
                    Pause();
                    break;

                case "3":
                    Console.WriteLine("Write()     : tidak pindah baris.");
                    Console.WriteLine("WriteLine() : pindah ke baris berikutnya.");
                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 8
    // =====================================================

    static void MenuBab8()
    {
        while (true)
        {
            Judul("BAB 8 - OPERATOR DAN INPUT");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("3. Mini Project");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab8(); break;
                case "2": LatihanBab8(); break;
                case "3": MiniProjectBab8(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void StudiKasusBab8()
    {
        while (true)
        {
            Judul("BAB 8 - STUDI KASUS");

            Console.WriteLine("1. Total Belanja Tiga Barang");
            Console.WriteLine("2. Menentukan Siswa Lulus");
            Console.WriteLine("3. Operator Modulus");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Harga 1: ");
                    double h1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Harga 2: ");
                    double h2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Harga 3: ");
                    double h3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Total = " + (h1 + h2 + h3));
                    Pause();
                    break;

                case "2":
                    Console.Write("Nilai: ");
                    double nilai = Convert.ToDouble(Console.ReadLine());

                    if (nilai >= 75)
                        Console.WriteLine("LULUS");
                    else
                        Console.WriteLine("TIDAK LULUS");

                    Pause();
                    break;

                case "3":
                    Console.Write("Bilangan pertama: ");
                    int a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Bilangan kedua: ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Sisa = " + (a % b));
                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void LatihanBab8()
    {
        while (true)
        {
            Judul("BAB 8 - LATIHAN");

            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Rata-rata Tiga Nilai");
            Console.WriteLine("3. Genap atau Ganjil");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Luas = " + (p * l));
                    Pause();
                    break;

                case "2":
                    Console.Write("Nilai 1: ");
                    double n1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 2: ");
                    double n2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 3: ");
                    double n3 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Rata-rata = " + ((n1 + n2 + n3) / 3));
                    Pause();
                    break;

                case "3":
                    Console.Write("Bilangan: ");
                    int angka = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        angka % 2 == 0 ? "Genap" : "Ganjil"
                    );

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void MiniProjectBab8()
    {
        Judul("BAB 8 - MINI PROJECT");

        Console.Write("Harga Barang : ");
        double harga = Convert.ToDouble(Console.ReadLine());

        Console.Write("Jumlah : ");
        int jumlah = Convert.ToInt32(Console.ReadLine());

        double total = harga * jumlah;

        Console.WriteLine("Total = " + total);

        Pause();
    }


    // =====================================================
    // BAB 9
    // =====================================================

    static void MenuBab9()
    {
        while (true)
        {
            Judul("BAB 9 - INPUT DATA");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab9(); break;
                case "2": LatihanBab9(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void StudiKasusBab9()
    {
        while (true)
        {
            Judul("BAB 9 - STUDI KASUS");

            Console.WriteLine("1. Biodata Siswa");
            Console.WriteLine("2. Luas Persegi Panjang");
            Console.WriteLine("3. Rata-rata Tiga Nilai");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Nama: ");
                    string nama = Console.ReadLine();

                    Console.Write("Kelas: ");
                    string kelas = Console.ReadLine();

                    Console.Write("Alamat: ");
                    string alamat = Console.ReadLine();

                    Console.WriteLine();
                    Console.WriteLine("===== BIODATA =====");
                    Console.WriteLine("Nama   : " + nama);
                    Console.WriteLine("Kelas  : " + kelas);
                    Console.WriteLine("Alamat : " + alamat);

                    Pause();
                    break;

                case "2":
                    Console.Write("Panjang: ");
                    double panjang = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Lebar: ");
                    double lebar = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Luas = " + (panjang * lebar));

                    Pause();
                    break;

                case "3":
                    Console.Write("Nilai 1: ");
                    double x = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 2: ");
                    double y = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Nilai 3: ");
                    double z = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Rata-rata = " + ((x + y + z) / 3));

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void LatihanBab9()
    {
        while (true)
        {
            Judul("BAB 9 - LATIHAN");

            Console.WriteLine("1. Write() dan WriteLine()");
            Console.WriteLine("2. Nama dan Sapaan");
            Console.WriteLine("3. Menghitung Umur");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Write() tidak pindah baris.");
                    Console.WriteLine("WriteLine() pindah baris.");
                    Pause();
                    break;

                case "2":
                    Console.Write("Nama: ");
                    string nama = Console.ReadLine();
                    Console.WriteLine("Halo, " + nama + "!");
                    Pause();
                    break;

                case "3":
                    Console.Write("Tahun lahir: ");
                    int tahun = Convert.ToInt32(Console.ReadLine());

                    int umur = DateTime.Now.Year - tahun;

                    Console.WriteLine("Umur = " + umur + " tahun");
                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 10
    // =====================================================

    static void MenuBab10()
    {
        while (true)
        {
            Judul("BAB 10 - PERCABANGAN");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab10(); break;
                case "2": MiniProjectBab10(); break;
                case "3": LatihanBab10(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void StudiKasusBab10()
    {
        while (true)
        {
            Judul("BAB 10 - STUDI KASUS");

            Console.WriteLine("1. Ganjil atau Genap");
            Console.WriteLine("2. Menghitung Diskon");
            Console.WriteLine("3. Kategori Nilai");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Bilangan: ");
                    int angka = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        angka % 2 == 0 ? "Bilangan Genap" : "Bilangan Ganjil"
                    );

                    Pause();
                    break;

                case "2":
                    Console.Write("Total belanja: ");
                    string inputTotal = Console.ReadLine();
                    if (!double.TryParse(inputTotal, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double total))
                    {
                        double.TryParse(inputTotal, out total);
                    }

                    Console.Write("Masukkan besar diskon (%): ");
                    string inputDiskon = Console.ReadLine();
                    if (!double.TryParse(inputDiskon, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double diskonInput))
                    {
                        double.TryParse(inputDiskon, out diskonInput);
                    }

                    double potongan = total * (diskonInput / 100);
                    double totalAkhir = total - potongan;

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Diskon yang dimasukkan : {diskonInput}%");
                    Console.WriteLine($"Jumlah potongan        : {potongan}");
                    Console.WriteLine($"Total setelah diskon   : {totalAkhir}");
                    Console.WriteLine("----------------------------------------");

                    // TAMBAHAN: Jeda agar console tidak langsung tertutup/melompat ke menu berikutnya
                    Console.WriteLine("Tekan sembarang tombol untuk kembali ke menu...");
                    Console.ReadKey();
                    break;




                case "3":
                    Console.Write("Nilai: ");
                    double nilai = Convert.ToDouble(Console.ReadLine());

                    if (nilai >= 90)
                        Console.WriteLine("Kategori A");
                    else if (nilai >= 80)
                        Console.WriteLine("Kategori B");
                    else if (nilai >= 70)
                        Console.WriteLine("Kategori C");
                    else if (nilai >= 60)
                        Console.WriteLine("Kategori D");
                    else
                        Console.WriteLine("Kategori E");

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void MiniProjectBab10()
    {
        Judul("BAB 10 - MINI PROJECT");

        Console.Write("Masukkan Umur: ");
        int umur = Convert.ToInt32(Console.ReadLine());

        if (umur >= 17)
            Console.WriteLine("Boleh membuat KTP");
        else
            Console.WriteLine("Belum memenuhi syarat");

        Pause();
    }

    static void LatihanBab10()
    {
        while (true)
        {
            Judul("BAB 10 - LATIHAN");

            Console.WriteLine("1. Login Sederhana");
            Console.WriteLine("2. Menentukan Hari dengan Switch");
            Console.WriteLine("3. Menentukan Nilai A, B, C, D");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    LoginBab10();
                    break;

                case "2":
                    HariBab10();
                    break;

                case "3":
                    NilaiBab10();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void LoginBab10()
    {
        Console.Write("Username: ");
        string username = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        if (username == "admin" && password == "12345")
            Console.WriteLine("Login berhasil!");
        else
            Console.WriteLine("Login gagal!");

        Pause();
    }

    static void HariBab10()
    {
        Console.Write("Nomor hari 1-7: ");
        int hari = Convert.ToInt32(Console.ReadLine());

        switch (hari)
        {
            case 1: Console.WriteLine("Senin"); break;
            case 2: Console.WriteLine("Selasa"); break;
            case 3: Console.WriteLine("Rabu"); break;
            case 4: Console.WriteLine("Kamis"); break;
            case 5: Console.WriteLine("Jumat"); break;
            case 6: Console.WriteLine("Sabtu"); break;
            case 7: Console.WriteLine("Minggu"); break;
            default: Console.WriteLine("Tidak valid"); break;
        }

        Pause();
    }

    static void NilaiBab10()
    {
        Console.Write("Nilai: ");
        double nilai = Convert.ToDouble(Console.ReadLine());

        if (nilai >= 90)
            Console.WriteLine("A");
        else if (nilai >= 80)
            Console.WriteLine("B");
        else if (nilai >= 70)
            Console.WriteLine("C");
        else if (nilai >= 60)
            Console.WriteLine("D");
        else
            Console.WriteLine("Di bawah D");

        Pause();
    }


    // =====================================================
    // BAB 11 - PERULANGAN
    // =====================================================

    static void MenuBab11()
    {
        while (true)
        {
            Judul("BAB 11 - PERULANGAN");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab11(); break;
                case "2": MiniProjectBab11(); break;
                case "3": LatihanBab11(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void StudiKasusBab11()
    {
        while (true)
        {
            Judul("BAB 11 - STUDI KASUS");

            Console.WriteLine("1. Menampilkan Angka 1-100");
            Console.WriteLine("2. Menjumlahkan Bilangan 1-50");
            Console.WriteLine("3. Pola Segitiga Bintang");
            Console.WriteLine("4. Tabel Perkalian");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Judul("ANGKA 1-100");

                    for (int i = 1; i <= 100; i++)
                    {
                        Console.Write(i + " ");

                        if (i % 10 == 0)
                            Console.WriteLine();
                    }

                    Pause();
                    break;

                case "2":
                    Judul("JUMLAH 1-50");

                    int jumlah = 0;

                    for (int i = 1; i <= 50; i++)
                        jumlah += i;

                    Console.WriteLine("Hasil = " + jumlah);

                    Pause();
                    break;

                case "3":
                    Judul("POLA SEGITIGA BINTANG");

                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= i; j++)
                            Console.Write("*");

                        Console.WriteLine();
                    }

                    Pause();
                    break;

                case "4":
                    Judul("TABEL PERKALIAN");

                    for (int i = 1; i <= 10; i++)
                    {
                        for (int j = 1; j <= 10; j++)
                        {
                            Console.Write($"{i * j,4}");
                        }

                        Console.WriteLine();
                    }

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void MiniProjectBab11()
    {
        Judul("BAB 11 - MINI PROJECT");

        Console.Write("Masukkan jumlah siswa: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Nama siswa ke-{i}: ");
            string nama = Console.ReadLine();

            Console.WriteLine("Nama siswa: " + nama);
        }

        Pause();
    }

    static void LatihanBab11()
    {
        while (true)
        {
            Judul("BAB 11 - LATIHAN");

            Console.WriteLine("1. Faktorial");
            Console.WriteLine("2. Bilangan Genap 1-100");
            Console.WriteLine("3. Pola Persegi Nested Loop");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Judul("FAKTORIAL");

                    Console.Write("Masukkan angka: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    long faktorial = 1;

                    for (int i = 1; i <= n; i++)
                        faktorial *= i;

                    Console.WriteLine($"{n}! = {faktorial}");

                    Pause();
                    break;

                case "2":
                    Judul("BILANGAN GENAP 1-100");

                    for (int i = 2; i <= 100; i += 2)
                        Console.Write(i + " ");

                    Pause();
                    break;

                case "3":
                    Judul("POLA PERSEGI");

                    for (int i = 1; i <= 5; i++)
                    {
                        for (int j = 1; j <= 5; j++)
                            Console.Write("* ");

                        Console.WriteLine();
                    }

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 12 - ARRAY DAN LIST
    // =====================================================

    static void MenuBab12()
    {
        while (true)
        {
            Judul("BAB 12 - ARRAY DAN LIST");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab12(); break;
                case "2": MiniProjectBab12(); break;
                case "3": LatihanBab12(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void StudiKasusBab12()
    {
        while (true)
        {
            Judul("BAB 12 - STUDI KASUS");

            Console.WriteLine("1. Array 10 Nilai Siswa");
            Console.WriteLine("2. Mengelola List Nama");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    int[] nilai = new int[10];

                    for (int i = 0; i < nilai.Length; i++)
                    {
                        Console.Write($"Nilai siswa ke-{i + 1}: ");
                        nilai[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int total = 0;
                    int tertinggi = nilai[0];

                    foreach (int n in nilai)
                    {
                        total += n;

                        if (n > tertinggi)
                            tertinggi = n;
                    }

                    double rata = (double)total / nilai.Length;

                    Console.WriteLine();
                    Console.WriteLine("Nilai tertinggi = " + tertinggi);
                    Console.WriteLine("Rata-rata = " + rata);

                    Pause();
                    break;

                case "2":
                    List<string> daftarNama = new List<string>();

                    Console.Write("Jumlah nama: ");
                    int jumlahNama = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < jumlahNama; i++)
                    {
                        Console.Write($"Nama ke-{i + 1}: ");
                        daftarNama.Add(Console.ReadLine());
                    }

                    Console.WriteLine();
                    Console.WriteLine("===== DAFTAR NAMA =====");

                    foreach (string nama in daftarNama)
                        Console.WriteLine(nama);

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void MiniProjectBab12()
    {
        Judul("BAB 12 - MINI PROJECT");

        int[] nilai = { 75, 80, 90, 85, 70 };

        int total = 0;

        foreach (int n in nilai)
            total += n;

        Console.WriteLine($"Rata-rata = {(double)total / nilai.Length}");

        Pause();
    }

    static void LatihanBab12()
    {
        while (true)
        {
            Judul("BAB 12 - LATIHAN");

            Console.WriteLine("1. Nilai Terbesar dalam Array");
            Console.WriteLine("2. Jumlah Bilangan Genap dalam Array");
            Console.WriteLine("3. Aplikasi Daftar Nama List");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    int[] angka = { 20, 50, 10, 80, 40 };

                    int terbesar = angka[0];

                    foreach (int n in angka)
                    {
                        if (n > terbesar)
                            terbesar = n;
                    }

                    Console.WriteLine("Nilai terbesar = " + terbesar);

                    Pause();
                    break;

                case "2":
                    int[] data = { 2, 5, 8, 11, 14, 17, 20 };

                    int jumlahGenap = 0;

                    foreach (int n in data)
                    {
                        if (n % 2 == 0)
                            jumlahGenap++;
                    }

                    Console.WriteLine("Jumlah bilangan genap = " + jumlahGenap);

                    Pause();
                    break;

                case "3":
                    List<string> namaList = new List<string>();

                    while (true)
                    {
                        Console.Clear();

                        Console.WriteLine("===== DAFTAR NAMA =====");
                        Console.WriteLine("1. Tambah Nama");
                        Console.WriteLine("2. Tampilkan Nama");
                        Console.WriteLine("3. Hapus Nama");
                        Console.WriteLine("0. Kembali");
                        Console.Write("Pilih: ");

                        string pilihan = Console.ReadLine();

                        if (pilihan == "1")
                        {
                            Console.Write("Masukkan nama: ");
                            namaList.Add(Console.ReadLine());

                            Console.WriteLine("Nama berhasil ditambahkan.");
                            Pause();
                        }
                        else if (pilihan == "2")
                        {
                            Console.WriteLine();

                            if (namaList.Count == 0)
                            {
                                Console.WriteLine("Daftar nama masih kosong.");
                            }
                            else
                            {
                                for (int i = 0; i < namaList.Count; i++)
                                    Console.WriteLine($"{i + 1}. {namaList[i]}");
                            }

                            Pause();
                        }
                        else if (pilihan == "3")
                        {
                            Console.Write("Masukkan nama yang ingin dihapus: ");
                            string hapus = Console.ReadLine();

                            if (namaList.Remove(hapus))
                                Console.WriteLine("Nama berhasil dihapus.");
                            else
                                Console.WriteLine("Nama tidak ditemukan.");

                            Pause();
                        }
                        else if (pilihan == "0")
                        {
                            break;
                        }
                        else
                        {
                            Salah();
                        }
                    }

                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 13 - METHOD
    // =====================================================

    static void MenuBab13()
    {
        while (true)
        {
            Judul("BAB 13 - METHOD");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab13(); break;
                case "2": MiniProjectBab13(); break;
                case "3": LatihanBab13(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    // Method Bab 13
    static double LuasPersegiPanjangMethod(double panjang, double lebar)
    {
        return panjang * lebar;
    }

    static double LuasLingkaran(double jariJari)
    {
        return Math.PI * jariJari * jariJari;
    }

    static string CekGanjilGenap(int angka)
    {
        if (angka % 2 == 0)
            return "Genap";

        return "Ganjil";
    }

    static double HitungRata(int a, int b, int c)
    {
        return (a + b + c) / 3.0;
    }

    static int KelilingPersegi(int sisi)
    {
        return 4 * sisi;
    }

    static long FaktorialMethod(int angka)
    {
        long hasil = 1;

        for (int i = 1; i <= angka; i++)
            hasil *= i;

        return hasil;
    }

    static double PangkatBilangan(double angka, int pangkat)
    {
        return Math.Pow(angka, pangkat);
    }

    static void StudiKasusBab13()
    {
        while (true)
        {
            Judul("BAB 13 - STUDI KASUS");

            Console.WriteLine("1. Method Luas Persegi Panjang");
            Console.WriteLine("2. Method Luas Lingkaran");
            Console.WriteLine("3. Method Ganjil atau Genap");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Panjang: ");
                    double p = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Lebar: ");
                    double l = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(
                        "Luas = " + LuasPersegiPanjangMethod(p, l)
                    );

                    Pause();
                    break;

                case "2":
                    Console.Write("Jari-jari: ");
                    double r = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(
                        "Luas = " + LuasLingkaran(r)
                    );

                    Pause();
                    break;

                case "3":
                    Console.Write("Bilangan: ");
                    int angka = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(CekGanjilGenap(angka));

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void MiniProjectBab13()
    {
        Judul("BAB 13 - MINI PROJECT");

        Console.WriteLine(HitungRata(80, 90, 85));

        Pause();
    }

    static void LatihanBab13()
    {
        while (true)
        {
            Judul("BAB 13 - LATIHAN");

            Console.WriteLine("1. Method Keliling Persegi");
            Console.WriteLine("2. Method Faktorial");
            Console.WriteLine("3. Method Pangkat Bilangan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Sisi: ");
                    int sisi = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        "Keliling = " + KelilingPersegi(sisi)
                    );

                    Pause();
                    break;

                case "2":
                    Console.Write("Angka: ");
                    int angka = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        $"{angka}! = {FaktorialMethod(angka)}"
                    );

                    Pause();
                    break;

                case "3":
                    Console.Write("Bilangan: ");
                    double bilangan = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Pangkat: ");
                    int pangkat = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(
                        "Hasil = " + PangkatBilangan(bilangan, pangkat)
                    );

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }


    // =====================================================
    // BAB 14 - OOP / CLASS
    // =====================================================

    static void MenuBab14()
    {
        while (true)
        {
            Judul("BAB 14 - OBJECT ORIENTED PROGRAMMING");

            Console.WriteLine("1. Studi Kasus");
            Console.WriteLine("2. Mini Project");
            Console.WriteLine("3. Latihan");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1": StudiKasusBab14(); break;
                case "2": MiniProjectBab14(); break;
                case "3": LatihanBab14(); break;
                case "0": return;
                default: Salah(); break;
            }
        }
    }

    static void StudiKasusBab14()
    {
        while (true)
        {
            Judul("BAB 14 - STUDI KASUS");

            Console.WriteLine("1. Class Siswa");
            Console.WriteLine("2. Class PersegiPanjang");
            Console.WriteLine("3. Class Rekening");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Siswa siswa = new Siswa();

                    Console.Write("Nama siswa: ");
                    siswa.Nama = Console.ReadLine();

                    Console.Write("Nilai: ");
                    siswa.Nilai = Convert.ToDouble(Console.ReadLine());

                    siswa.TampilData();

                    Pause();
                    break;

                case "2":
                    PersegiPanjang persegi = new PersegiPanjang();

                    Console.Write("Panjang: ");
                    persegi.Panjang = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Lebar: ");
                    persegi.Lebar = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine(
                        "Luas = " + persegi.HitungLuas()
                    );

                    Pause();
                    break;

                case "3":
                    Rekening rekening = new Rekening();

                    Console.Write("Saldo awal: ");
                    rekening.Saldo = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Jumlah setor: ");
                    double setor = Convert.ToDouble(Console.ReadLine());

                    rekening.Setor(setor);

                    rekening.LihatSaldo();

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }

    static void MiniProjectBab14()
    {
        Judul("BAB 14 - MINI PROJECT");

        Mobil m = new Mobil();

        m.Merk = "Toyota";

        m.Jalan();

        Pause();
    }

    static void LatihanBab14()
    {
        while (true)
        {
            Judul("BAB 14 - LATIHAN");

            Console.WriteLine("1. Class Buku");
            Console.WriteLine("2. Class Mahasiswa");
            Console.WriteLine("3. Constructor Dua Parameter");
            Console.WriteLine("0. Kembali");
            Console.Write("Pilih: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Buku buku = new Buku();

                    Console.Write("Judul: ");
                    buku.Judul = Console.ReadLine();

                    Console.Write("Penulis: ");
                    buku.Penulis = Console.ReadLine();

                    buku.TampilData();

                    Pause();
                    break;

                case "2":
                    Mahasiswa mahasiswa = new Mahasiswa();

                    Console.Write("Nama: ");
                    mahasiswa.Nama = Console.ReadLine();

                    Console.Write("NIM: ");
                    mahasiswa.NIM = Console.ReadLine();

                    mahasiswa.TampilData();

                    Pause();
                    break;

                case "3":
                    Console.Write("Nama: ");
                    string nama = Console.ReadLine();

                    Console.Write("Umur: ");
                    int umur = Convert.ToInt32(Console.ReadLine());

                    Orang orang = new Orang(nama, umur);

                    orang.TampilData();

                    Pause();
                    break;

                case "0":
                    return;

                default:
                    Salah();
                    break;
            }
        }
    }
}


// =========================================================
// CLASS BAB 14
// =========================================================

class Siswa
{
    public string Nama { get; set; }
    public double Nilai { get; set; }

    public void TampilData()
    {
        Console.WriteLine();
        Console.WriteLine("===== DATA SISWA =====");
        Console.WriteLine("Nama  : " + Nama);
        Console.WriteLine("Nilai : " + Nilai);
    }
}


class PersegiPanjang
{
    public double Panjang { get; set; }
    public double Lebar { get; set; }

    public double HitungLuas()
    {
        return Panjang * Lebar;
    }
}


class Rekening
{
    public double Saldo { get; set; }

    public void Setor(double jumlah)
    {
        Saldo += jumlah;
        Console.WriteLine("Setor berhasil.");
    }

    public void LihatSaldo()
    {
        Console.WriteLine("Saldo saat ini = " + Saldo);
    }
}


class Mobil
{
    public string Merk { get; set; }

    public void Jalan()
    {
        Console.WriteLine($"{Merk} sedang berjalan.");
    }
}


class Buku
{
    public string Judul { get; set; }
    public string Penulis { get; set; }

    public void TampilData()
    {
        Console.WriteLine();
        Console.WriteLine("===== DATA BUKU =====");
        Console.WriteLine("Judul   : " + Judul);
        Console.WriteLine("Penulis : " + Penulis);
    }
}


class Mahasiswa
{
    public string Nama { get; set; }
    public string NIM { get; set; }

    public void TampilData()
    {
        Console.WriteLine();
        Console.WriteLine("===== DATA MAHASISWA =====");
        Console.WriteLine("Nama : " + Nama);
        Console.WriteLine("NIM  : " + NIM);
    }
}


// Constructor dengan dua parameter
class Orang
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Orang(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public void TampilData()
    {
        Console.WriteLine();
        Console.WriteLine("===== DATA ORANG =====");
        Console.WriteLine("Nama : " + Nama);
        Console.WriteLine("Umur : " + Umur);
    }
}

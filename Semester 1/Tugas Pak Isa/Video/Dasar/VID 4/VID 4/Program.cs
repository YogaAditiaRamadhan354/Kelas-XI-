//Materi Percabangan

// IF

int umur = 13;

//if (umur >= 18)
//{
//    Console.WriteLine("Anda sudah besar.");
//}

//ELSE


if (umur >= 18)
{
    Console.WriteLine("Anda sudah dewasa.");
}
else
{
    Console.WriteLine("Anda masih anak-anak.");
}

//ELSE IF

int nilai = 80;

if (nilai >= 90)
{
    Console.WriteLine("Nilai Anda A");
}
else if (nilai >= 80)
{
    Console.WriteLine("Nilai Anda B");
}
else if (nilai >= 70)
{
    Console.WriteLine("Nilai Anda C");
}
else if (nilai >= 60)
{
    Console.WriteLine("Nilai Anda D");
}
else
{
    Console.WriteLine("Nilai Anda E");
}

//SWITCH
//Digunakan untuk memilih kondisu berdasarkan nilai tertentu

string hari = "Senin";

switch (hari)
{
    case "Senin":
        Console.WriteLine("Hari ini adalah hari Senin.");
        break;
    case "Selasa":
        Console.WriteLine("Hari ini adalah hari Selasa.");
        break;
    case "Rabu":
        Console.WriteLine("Hari ini adalah hari Rabu.");
        break;
    case "Kamis":
        Console.WriteLine("Hari ini adalah hari Kamis.");
        break;
    case "Jumat":
        Console.WriteLine("Hari ini adalah hari Jumat.");
        break;
    case "Sabtu":
        Console.WriteLine("Hari ini adalah hari Sabtu.");
        break;
    case "Minggu":
        Console.WriteLine("Hari ini adalah hari Minggu.");
        break;
    default:
        Console.WriteLine("Nama hari tidak valid.");
        break;
}
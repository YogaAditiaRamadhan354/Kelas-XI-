// Materi Perulangan For, While, dan Foreach

// perulangan digunakan untuk menjalankan perintah otomatis

// 1. For Loop
// digunakan ketika jumlah sudah diketahui

// digunakan untuk perulangan dengan jumlah yang tertentu

// isi (parameter) darei for loop
// int i = 1 <- nilai awal perulangan 
// i <= 5 <- kondisi perulangan
// i++ <- penambahan nilai i setiap  perulangan)

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Perulangan ke-" + i);
}

//2.While Loop
//Digunakan ketika jumlah perulangan tidak diketahui

int angka = 1;

while (angka <= 3) // while loop akan terus berjalan selama kondisi bernilai true
{
    Console.WriteLine("Perulangan ke-" + angka);
   angka++; // Increment wajib, agar perulangan tidak menjadi infinite loop
}

//Foreach Loop
//Digunakan untuk mengambil data dalam koleksi (array, list, dll)

string[] namaOrang = { "Andi", "Budi", "Caca", "Dedi", "Eka" };

foreach (string nama in namaOrang)
{
    Console.WriteLine(nama);
}
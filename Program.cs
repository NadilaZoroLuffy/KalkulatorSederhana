using System; //pustaka

Console.WriteLine("Kalkulator Sederhana"); //tampil  otomatis 
Console.WriteLine("====================");

// Meminta pengguna untuk memasukkan angka pertama
Console.Write("Masukkan angka pertama: ");
double angka1 = Convert.ToDouble(Console.ReadLine()); // baca

// Meminta pengguna untuk memasukkan operator
Console.Write("Masukkan operator (+, -, *, /): ");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
char operasi = Console.ReadLine()[0];
#pragma warning restore CS8602 // Dereference of a possibly null reference.

// Meminta pengguna untuk memasukkan angka kedua
Console.Write("Masukkan angka kedua: ");
double angka2 = Convert.ToDouble(Console.ReadLine()); //menyimpan angka 2

double hasil = 0; // Variabel untuk menyimpan hasil

// Memeriksa operator yang dipilih dan melakukan operasi yang sesuai
switch (operasi) //menetukan operasi
{
    case '+':
        hasil = angka1 + angka2; // Lakukan penjumlahan
        break;
    case '-':
        hasil = angka1 - angka2; // Lakukan pengurangan
        break;
    case '*':
        hasil = angka1 * angka2; // Lakukan perkalian
        break;
    case '/':
        if (angka2 == 0) // Memeriksa pembagi nol
        {
            Console.WriteLine("Error: Pembagian dengan nol tidak diperbolehkan.");
            return; // Keluar dari program
        }
        hasil = angka1 / angka2; // Lakukan pembagian
        break;
    default:
        Console.WriteLine("Error: Operator tidak valid.");
        return; // Keluar dari program
}

// Menampilkan hasil
Console.WriteLine($"Hasil: {angka1} {operasi} {angka2} = {hasil}");
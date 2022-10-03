using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MENU PERSEGI PANJANG");
            Console.WriteLine("1. Hitung luas");
            Console.WriteLine("2. Hitung luas keliling");

            int pilih;
            Console.WriteLine("Menupilihan");
            pilih = int.Parse(Console.ReadLine());

            if (pilih >= 3 || pilih >= 5)
            {
                Console.WriteLine("menu tidak sesuai");
            }

            double panjang,tinggi,hasil;
            Console.WriteLine("=== MENGHITUNG LUAS PERSEGI PANJANG  =");
            Console.Write("Masukkan panjang (cm) : ");
            panjang = double.Parse(Console.ReadLine());
            Console.Write("Masukkan tinggi (cm)  : ");
            tinggi = double.Parse(Console.ReadLine());
            hasil =  panjang * tinggi;
            Console.WriteLine("\n\tHasilnya, luas persegi panjang adalah : {0} cm", hasil);


            Console.WriteLine("Ingin Mengulang Kembali (Y/T");
            Console.ReadLine();
        }
    }
}
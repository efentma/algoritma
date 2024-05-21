using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("1 - Masukkan angka : ");
        int k = int.Parse(Console.ReadLine() ?? " "); // membaca input dari user dan mengkonversi nilai ke tipe data int

        for (int i = 1; i <= k; i++) // looping 1 - nilai input k
        {
            if (i % 12 == 0) // jika kelipatan 3 & 4, cetak OKYES
            {
                Console.Write(" OKYES ");
            }
            else if (i % 3 == 0) // jika kelipatan 3, cetak OK
            {
                Console.Write(" OK ");
            }
            else if (i % 4 == 0) // jika kelipatan 4, cetak YES
            {
                Console.Write(" YES ");
            }
            else
            {
                Console.Write(i + " "); // cetak angka jika bukan kelipatan 3, 4 atau 3 & 4
            }
        }
        Console.WriteLine();

        //Nomor 2a
        Console.Write("2a - Masukkan angka: ");
        int a = int.Parse(Console.ReadLine() ?? " ");

        for (int i = 1; i <= a; i++) // looping luar dari 1 - nilai input a
        {
            for (int j = 1; j <= i; j++) // looping dalam dari 1 - i
            {
                Console.Write(i); // mencetak nilai i
            }
            Console.WriteLine();
        }

        // Nomor 2b

        Console.Write("2b - Masukan angka: ");
        int b = int.Parse(Console.ReadLine() ?? " ");

        for (int i = 1; i <= b; i++)
        {
            for (int j = i; j >= 1; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        // Nomor 2c
        Console.Write("2c - Masukan angka: ");
        int c = int.Parse(Console.ReadLine() ?? " ");
        int n = 1; // menyimpan nilai yang akan ditampilkan
        bool status = true; // cek status turun/naik

        for (int i = 1; i <= c; i++) // looping dari 1 - nilai input c
        {
            for (int j = 0; j < i; j++)
            {
                if (n == c)
                    status = false; // jika nilai n atau maksimum, cetak angka menurun
                if (n == 1)
                    status = true; // jika nilai n atau minimum, cetak angka naik

                if (status)
                    Console.Write(n++); // jika status true, nilai n ditambahkan 1
                else
                    Console.Write(n--); // jika status false, nilai n dikurangi 1
            }
            Console.WriteLine();
        }

        // Nomor 2d
        Console.Write("2d - Masukan angka: ");
        int d = int.Parse(Console.ReadLine() ?? " ");

        // Inisialisasi array dua dimensi untuk menyimpan angka
        int[,] matrix = new int[d, d];

        // Pengisian angka kedalam array
        int num = 1;
        for (int i = 0; i < d; i++)
        {
            if (i % 2 == 0) // jika baris genap, angka akan diisi dari kiri ke kanan
            {
                for (int j = 0; j < d; j++)
                {
                    matrix[i, j] = num;
                    num++;
                }
            }
            else // jika baris ganjil, angka akan diisi dari kanan ke kiri
            {
                for (int j = d - 1; j >= 0; j--)
                {
                    matrix[i, j] = num;
                    num++;
                }
            }
        }

        // Menampilkan matrix
        for (int i = 0; i < d; i++)
        {
            for (int j = 0; j < d; j++)
            {
                Console.Write(matrix[j, i] + " ");
            }
            Console.WriteLine();
        }

        // Nomor 3

        Console.Write("Nomor 3 ");
        int[] array = [12, 9, 13, 6, 10, 4, 7, 2]; // array yang akan di sorting

        List<int> result = new List<int>(); // list nilai yang bukan kelipatan tiga

        // Membuang nilai kelipatan tiga
        foreach (int number in array)
        {
            if (number % 3 != 0)
            {
                result.Add(number);
            }
        }
        result.Sort(); // mengurutkan nilai yang tersisa secara ascending

        // mencetak output array baru
        Console.WriteLine("Array baru: ");
        foreach (int number in result)
        {
            Console.Write(number + " ");
        }

    }
}
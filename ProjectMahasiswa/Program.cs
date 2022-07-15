using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("PILIHAN MENU APLIKASI");
            Console.WriteLine();

            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.WriteLine("TAMBAH DATA MAHASISWA");
            Console.WriteLine();

            Mahasiswa mhs = new Mahasiswa();

            Console.Write("NIM : ");
            mhs.Nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nama : ");
            mhs.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            mhs.jenisKelamin = Console.ReadLine();
            Console.Write("IPK : ");
            mhs.ipk = Console.ReadLine();

            if (mhs.jenisKelamin == "L")
            {
                mhs.jenisKelamin = "Laki-laki";
            }
            if (mhs.jenisKelamin == "P")
            {
                mhs.jenisKelamin = "Perempuan";
            }

            daftarMahasiswa.Add(mhs);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("DATA MAHASISWA");
            Console.WriteLine();

            for (int i = 0; i < daftarMahasiswa.Count; i++)
            {
                Mahasiswa mhs = daftarMahasiswa[i];
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", i+1, mhs.Nim, mhs.Nama, mhs.jenisKelamin, mhs.ipk);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

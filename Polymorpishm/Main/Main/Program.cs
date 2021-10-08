using System;
using System.Collections.Generic;

namespace OOP_Polymorpishme
{
    class Program
    {
        static void Main(string[] args)
        {
            var gajiKaryawan = new GajiKaryawan(" John", " Smith", "111-11-1111", 800.00M);
            var karyawanPerJam = new KaryawanPerJam(" Karen", " Price", "222-22-2222", 16.75M, 40.0M);
            var komisiKaryawan = new KomisiKaryawan("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var gajiPokokPlusKomisiKaryawan = new GajiPokokPlusKomisiKaryawan("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine(" Karyawan diproses secara individual : \n");
            Console.WriteLine($" {gajiKaryaawan}\n  Diperoleh            : " + $"{gajiKaryawan.Penghasilan():C}");
            Console.WriteLine($" {karyawanPerJam}\n  Diperoleh            : " + $"{karyawanPerJam.Penghasilan():C}");
            Console.WriteLine($" {komisiKaryawan}\n  Diperoleh            : " + $"{komisiKaryawan.Penghasilan():C}");
            Console.WriteLine($" {gajiPokokPlusKomisiKaryawan}\n  Diperoleh            : " + $"{gajiPokokPlusKomisiKaryawan.Penghasilan():C}\n");

            var seluruhKaryawan = new List<Karyawan>() { gajiKaryawan, karyawanPerJam, komisiKaryawan, gajiPokokPlusKomisiKaryawan };
            Console.WriteLine("\n  Karyawan diproses secara Polimorfik : ");

            foreach (var karyawanSekarang in seluruhKaryawan)
            {
                Console.WriteLine(karyawanSekarang);

                if (karyawanSekarang is GajiPokokPlusKomisiKaryawan)
                {
                    var karyawan = (GajiPokokPlusKomisiKaryawan)karyawanSekarang;

                    karyawan.GajiPokok *= 1.10M;
                    Console.WriteLine("  Gaji Pokok baru dengan kenaikan 10% adalah : " + $"{karyawan.GajiPokok:C}");
                }
                Console.WriteLine($"  Penghasilan          : {karyawanSekarang.Penghasilan():C}");
            }
            Console.WriteLine();
            for (int j = 0; j < seluruhKaryawan.Count; j++)
            {
                Console.WriteLine($"  Karyawan {j} adalah {seluruhKaryawan[j].GetType()}");
            }

        }
    }
}

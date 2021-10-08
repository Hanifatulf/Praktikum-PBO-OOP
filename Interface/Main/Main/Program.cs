using System;
using System.Collections.Generic;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var Hutang = new List<IHutang>() {
            new Tagihan("01234",  "seat",  2,  375.00M),
            new Tagihan("56789",  "tire",  4,  79.95M),
            new GajiKaryawan("John",  "Smith", "111-11-1111",  800.00M),
            new GajiKaryawan("Lisa",  "Barnes", "888-88-8888",  1200.00M)};

            Console.WriteLine("  Tagihan dan Karyawan diproses secara polimorfik : \n");

            foreach (var hutang in Hutang)
            {
                Console.WriteLine($"{hutang}");
                Console.WriteLine($"  Tanggal jatuh tempo : {hutang.DapatkanJumlahPembayaran():C}\n");
            }
        }
    }
}
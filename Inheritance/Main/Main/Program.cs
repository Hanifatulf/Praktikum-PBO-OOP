using System;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;

namespace OOP_Inheritance
    {
        class Program
        {
            static void Main(string[] args)
            {
                KomisiKaryawan karyawan = new KomisiKaryawan("Sue", "Jones", "222-22-222", 10000.00M, .06M);

                Console.WriteLine(" Informasi karyawan diperoleh dengan properti dan metode : \n");

                //Console.WriteLine(" Nama Depan adalah          : {0}", karyawan.NamaDepan);
                //Console.WriteLine(" Nama Belakang adalah       : {0}", karyawan.NamaBelakang);
                //Console.WriteLine(" No KTP adalah              : {0}", karyawan.NoKtp);
                //Console.WriteLine(" Penjual Kotor adalah       : {0:C}", karyawan.PenjualanBruto);
                //Console.WriteLine(" Tarif Komisi adalah        : {0:F2}", karyawan.TarifKomisi);
                //Console.WriteLine(" Pendapatan adalah          : {0:C}", karyawan.Penghasilan());
                Console.WriteLine($" Nama Depan adalah            : {karyawan.NamaDepan }");
                Console.WriteLine($" Nama Belakang adalah         : {karyawan.NamaBelakang }");
                Console.WriteLine($" No KTP adalah                : {karyawan.NoKtp }");
                Console.WriteLine($" Penjualan Bruto adalah       : {karyawan.PenjualanBruto:C}");
                Console.WriteLine($" Tarif Komisi adalah          : {karyawan.TarifKomisi:F2}");
                Console.WriteLine($" Penghasilan adalah           : {karyawan.Penghasilan():C}");

                karyawan.PenjualanBruto = 5000.00M; //set penjualan bruto
                karyawan.TarifKomisi = .1M; //set tarif komisi
                Console.WriteLine("\n Informasi terbaru karyawan diperoleh dari ToString : ");
                Console.WriteLine(karyawan);
                Console.WriteLine($" Penghasilan\t     : {karyawan.Penghasilan():C}");

                //Console.WriteLine("\n {0} :  {1}", "Informasi terbaru karyawan diperoleh dari ToString", karyawan);
                //Console.WriteLine(" Penghasilan : {0:C}", karyawan.Penghasilan());
                Console.ReadLine();
            }
        }
    }
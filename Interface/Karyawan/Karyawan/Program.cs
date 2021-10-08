using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    public abstract class Karyawan : IHutang
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NoKtp { get; }

        public Karyawan(string namaDepan, string namaBelakang, string noKtp)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NoKtp = noKtp;
        }

        public override string ToString() =>
            $" {NamaDepan} {NamaBelakang}\n " +
            $" No KTP              : {NoKtp}";


        public abstract decimal Penghasilan();

        public decimal DapatkanJumlahPembayaran() => Penghasilan();
    }
}
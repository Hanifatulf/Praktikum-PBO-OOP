using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorpishme
{
    public class GajiKaryawan : Karyawan
    {
        private decimal gajiMingguan;

        public GajiKaryawan(string namaDepan, string namaBelakang, string noKtp, decimal gajiMingguan) :
            base(namaDepan, namaBelakang, noKtp)
        {
            GajiMingguan = gajiMingguan;
        }

        public decimal GajiMingguan
        {
            get { return gajiMingguan; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiMingguan) } harus >= 0");
                }
                gajiMingguan = value;
            }
        }

        public override decimal Penghasilan() => GajiMingguan;

        public override string ToString() =>
            $"\n  Gaji Karyawan        :{base.ToString()}\n " +
            $" Gaji Mingguan        : {GajiMingguan:C}";

    }
}
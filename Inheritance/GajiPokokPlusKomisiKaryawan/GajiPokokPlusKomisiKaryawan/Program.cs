using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    class GajiPokokPlusKomisiKaryawan : KomisiKaryawan
    {
        private decimal gajiPokok;

        public GajiPokokPlusKomisiKaryawan(string namaDepan, string namaBelakang, string noKtp, decimal penjualanBruto, decimal tarifKomisi, decimal gajiPokok)
         : base(namaDepan, namaBelakang, noKtp, penjualanBruto, tarifKomisi)
        {
            GajiPokok = gajiPokok;
        }

        public decimal GajiPokok
        {
            get { return gajiPokok; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiPokok)} harus >= 0");
                }
                gajiPokok = value;
            }
        }
        public override decimal Penghasilan() => GajiPokok + base.Penghasilan();
        public override string ToString() => $"gaji-pokok {base.ToString()}\n gaji pokok : {GajiPokok:C}";
    }
}
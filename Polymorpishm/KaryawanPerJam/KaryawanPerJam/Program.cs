using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorpishme
{
    public class KaryawanPerJam : Karyawan
    {
        private decimal gaji;
        private decimal jam;


        public KaryawanPerJam(string namaDepan, string namaBelakang, string noKtp, decimal gajiperJam, decimal jamBekerja) :
            base(namaDepan, namaBelakang, noKtp)
        {
            Gaji = gajiperJam;
            Jam = jamBekerja;
        }

        public decimal Gaji
        {
            get { return gaji; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Gaji) } harus >= 0");
                }
                gaji = value;
            }
        }

        public decimal Jam
        {
            get { return jam; }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jam) } harus >= 0 dan <= 168");
                }
                jam = value;
            }
        }

        public override decimal Penghasilan()
        {
            if (Jam <= 40)
            {
                return Gaji * Jam;
            }
            else
            {
                return (40 * Gaji) + ((Jam - 40) * Gaji * 1.5M);
            }
        }

        public override string ToString() =>
            $"\n  Karyawan per Jam     :{base.ToString()}\n " +
            $" Gaji per Jam         : {Gaji:C}\n  Jam Kerja            : {Jam:F2}";

    }
}
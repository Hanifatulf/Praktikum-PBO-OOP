using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Polymorpishme
{
    public class KomisiKaryawan : Karyawan
    {
        private decimal penjualanBruto;
        private decimal tarifKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string noKtp, decimal penjualanBruto, decimal tarifKomisi) :
            base(namaDepan, namaBelakang, noKtp)
        {
            PenjualanBruto = penjualanBruto;
            TarifKomisi = tarifKomisi;
        }

        public decimal PenjualanBruto
        {
            get { return penjualanBruto; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PenjualanBruto)} harus >= 0");
                }
                penjualanBruto = value;
            }
        }

        public decimal TarifKomisi
        {
            get { return penjualanBruto; }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TarifKomisi)} harus > 0 dan< 1");
                }
                tarifKomisi = value;
            }

        }
        public override decimal Penghasilan() => TarifKomisi * PenjualanBruto;

        public override string ToString() =>
            $"\n  Komisi Karyawan      : {base.ToString()}\n" +
            $"  Penjualan Bruto      : {PenjualanBruto:C}\n " +
            $" Tarif Komisi         : {TarifKomisi:F2}";
    }
}
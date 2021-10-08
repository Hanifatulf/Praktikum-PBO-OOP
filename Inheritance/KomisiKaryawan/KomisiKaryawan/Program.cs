using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class KomisiKaryawan
    {
        public string NamaDepan { get; }
        public string NamaBelakang { get; }
        public string NoKtp { get; }
        public decimal penjualanBruto;
        public decimal tarifKomisi;

        public KomisiKaryawan(string namaDepan, string namaBelakang, string noKtp, decimal penjualanBruto, decimal tarifKomisi)
        {
            NamaDepan = namaDepan;
            NamaBelakang = namaBelakang;
            NoKtp = noKtp;
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
            get { return tarifKomisi; }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(tarifKomisi)} harus > 0 dan < 1");
                }
                tarifKomisi = value;
            }
        }
        public virtual decimal Penghasilan() => TarifKomisi * PenjualanBruto;

        public override string ToString() =>
            $"\n Komisi karyawan     : {NamaDepan } {NamaBelakang } \n" +
            $" No KTP              : {NoKtp} \n" +
            $" Penjualan Bruto     : {PenjualanBruto:C}\n" +
            $" Komisi karyawan     : {TarifKomisi:F2}";
    }
}
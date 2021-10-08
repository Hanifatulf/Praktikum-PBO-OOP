using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interface
{
    public class Tagihan : IHutang
    {
        public string NomorBagian { get; }
        public string DeskripsiBagian { get; }
        private int jumlah;
        private decimal hargaPerBarang;

        public Tagihan(string nomorBagian, string deskripsiBagian, int jumlah, decimal hargaPerBarang)
        {
            NomorBagian = nomorBagian;
            DeskripsiBagian = deskripsiBagian;
            Jumlah = jumlah;
            HargaPerBarang = hargaPerBarang;
        }

        public int Jumlah
        {
            get { return jumlah; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jumlah)} harus >= 0");
                }

                jumlah = value;
            }
        }

        public decimal HargaPerBarang
        {
            get { return hargaPerBarang; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HargaPerBarang)} harus >= 0");
                }
                hargaPerBarang = value;
            }
        }

        public override string ToString() =>
        $"  Tagihan :\n  Nomor Bagian        : {NomorBagian} ({DeskripsiBagian})\n" +
        $"  Jumlah              : {Jumlah}\n  Harga per Barang    : {HargaPerBarang:C}";

        public decimal DapatkanJumlahPembayaran() => Jumlah * HargaPerBarang;



    }
}
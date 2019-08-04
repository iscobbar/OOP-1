using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Sorular
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Sınıf: Ogrenci
             *  tc,ad,soyad,dogumtarihi,yas,sınıfı sinifOgretmeni
             *  YasHesapla(): yaşını ata ve ekrana yazdır.
             *  BilgiListele(): Öğrencinin bilgilerin yazdır.
             *  tüm bilgileri parametre olarak alan yapıcı metotu yazın.      
             */

            Ogrenci ogr1 = new Ogrenci("12312312", "Oya", "ILIK", 1990, "12C", "Ayşe ATABAK");

            ogr1.BilgiListele();

            Console.Read();
        }
    }
    class Ogrenci
    {
        private string _Tc;
        public string Tc { get { return _Tc; } set { _Tc = value; } }
        private string _Ad;
        public string Ad { get { return _Ad; } set { _Ad = value; } }
        private string _Soyad;
        public string Soyad;
        private short _Dt;
        public short Dt;
        private string _Sinif;
        public string Sinif;
        private string _SinifOgretmeni;
        public string SinifOgretmeni;

        private byte _Yas;

        // Yapıcıyı parametresiz olarak da kullanmak istiyorsak mutlak boş olarak tanımlamalıyız.

        public Ogrenci() { }

        public Ogrenci(string tc, string ad, string soyad, short dt, string sinif, string sinifOgretmeni)
        {
            this.Tc = tc;
            this.Ad = ad;
            this.Soyad = soyad;
            this.Dt = dt;
            this.Sinif = sinif;
            this.SinifOgretmeni = sinifOgretmeni;
            YasHesapla(dt);

        }
        private void YasHesapla(short dt)
        {
            this._Yas = (byte)(DateTime.Now.Year - dt);
        }
        public void BilgiListele()
        {
            Console.WriteLine(this.Tc);
            Console.WriteLine(this.Ad);
            Console.WriteLine(this.Soyad);
            Console.WriteLine(this._Yas);
            Console.WriteLine(this.Sinif);
            Console.WriteLine(this.SinifOgretmeni);
        }
    }
}
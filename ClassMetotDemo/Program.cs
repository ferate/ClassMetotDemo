using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Id = 1;
            Musteri1.Adi = "FERAT";
            Musteri1.Soyadi = "EFİL";            
            Musteri1.Telefon = "5052429999";
            Musteri1.EPosta = "efilferat@hotmail.com";
            Musteri1.Adres = "SAMSUN";

            Musteri Musteri2 = new Musteri();
            Musteri2.Id = 2;
            Musteri2.Adi = "MUSTAFA";
            Musteri2.Soyadi = "BELİR";
            Musteri2.Telefon = "5055553434";
            Musteri2.EPosta = "mbelir@hotmail.com";
            Musteri2.Adres = "İSTANBUL";

            Musteri Musteri3 = new Musteri();
            Musteri3.Id = 3;
            Musteri3.Adi = "SEBAHATTİN";
            Musteri3.Soyadi = "ŞEKER";
            Musteri3.Telefon = "5052420606";
            Musteri3.EPosta = "s.seker@gmail.com";
            Musteri3.Adres = "ANKARA";

            MusteriManager.MusteriEkle(Musteri1);
            Console.WriteLine("*************************************");
            MusteriManager.MusteriListele(Musteri2);
            Console.WriteLine("*************************************");
            MusteriManager.MusteriSilme(Musteri3);

        }
    }
}

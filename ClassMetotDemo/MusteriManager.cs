using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public static void MusteriEkle(Musteri YeniMusteri)
        {
            Console.WriteLine("Müşteri Başarı İle Eklendi.");
            Console.WriteLine("Eklenen Müşteri Bilgileri :");
            Console.WriteLine("Id :" + YeniMusteri.Id);
            Console.WriteLine("Adı :"+YeniMusteri.Adi);
            Console.WriteLine("Soyadı :" + YeniMusteri.Soyadi);            
            Console.WriteLine("Telefonu :" + YeniMusteri.Telefon);
            Console.WriteLine("E-Posta Adresi :" + YeniMusteri.EPosta);
            Console.WriteLine("Adres :" + YeniMusteri.Adres);
        }

        public static void MusteriListele(Musteri ListelenecekMusteri)
        {
            Console.WriteLine("Müşteri Listeleme İşlemi Başarılı");
            Console.WriteLine("Listelenen Müşteri Bilgileri :");
            Console.WriteLine("Id :" + ListelenecekMusteri.Id);
            Console.WriteLine("Adı :" + ListelenecekMusteri.Adi);
            Console.WriteLine("Soyadı :" + ListelenecekMusteri.Soyadi);
            Console.WriteLine("Telefonu :" + ListelenecekMusteri.Telefon);
            Console.WriteLine("E-Posta Adresi :" + ListelenecekMusteri.EPosta);
            Console.WriteLine("Adres :" + ListelenecekMusteri.Adres);
        }

        public static void MusteriSilme(Musteri SilinecekMusteri)
        {
            Console.WriteLine("Müşteri Silme İşlemi Başarılı");
            Console.WriteLine("Silinen Müşteri Bilgileri :");
            Console.WriteLine("Id :" + SilinecekMusteri.Id);
            Console.WriteLine("Adı :" + SilinecekMusteri.Adi);
            Console.WriteLine("Soyadı :" + SilinecekMusteri.Soyadi);
            Console.WriteLine("Telefonu :" + SilinecekMusteri.Telefon);
            Console.WriteLine("E-Posta Adresi :" + SilinecekMusteri.EPosta);
            Console.WriteLine("Adres :" + SilinecekMusteri.Adres);
        }

    }
}

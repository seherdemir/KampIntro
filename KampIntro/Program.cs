using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int OgrenciSayisi = 32000;
            double faizOrani = 1.65;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalis Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artis Butonu");
            }
            else
            {
                Console.WriteLine("Degismedi Durum");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanici Ayarlari Butonu");
            }
            else
            {
                Console.WriteLine("Giris Yap Butonu ");
            }
            Console.WriteLine(kategoriEtiketi);

        }
    }
}

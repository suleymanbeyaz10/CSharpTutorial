using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety

            //Do not repeat yourself
            
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.34;
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 19.55;
            double dolarBugun = 19.55;

            if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else if(dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else
            {
                Console.WriteLine("Değişmedi çizgisi");
            }



            Console.WriteLine(kategoriEtiketi);

        }
    }
}

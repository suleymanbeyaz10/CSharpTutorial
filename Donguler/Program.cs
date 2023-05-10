using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "JavaScript Kursu";
            string kurs2 = "Angular Kursu";
            string kurs3 = "React Kursu";
            string kurs4 = "NodeJS Kursu";
            string kurs5 = "TypeScript Kursu";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            

            Console.WriteLine("****** Dinamik Olmayan Yapı Bitti ******");

            //ARRAY -- dizi

            string[] kurslar = new string[] { "JavaScript Kursu",
                "Angular Kursu",
                "React Kursu",
                "NodeJS Kursu",
                "TypeScript Kursu"};

            for (int i =  0; i < kurslar.Length; i++)
            {

                Console.WriteLine(kurslar[i]);            
            }

            Console.WriteLine("****** For Bitti ******");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("****** Foreach Bitti ******");

            Console.WriteLine("Sayfa Sonu - Footer");
        }
    }
}

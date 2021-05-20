using System;
using System.Collections.Generic;

namespace GenericMyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler2 = new MyDictionary<int, string>();
            sehirler2.Add(10, "Balıkesir");
            sehirler2.Add(11, "Bilecik");
            sehirler2.Add(16, "Bursa");
            sehirler2.Add(17, "Çanakkale");
            sehirler2.Add(22, "Edirne");
            sehirler2.Add(34, "İstanbul");
            sehirler2.Add(39, "Kırklareli");
            sehirler2.Add(41, "Kocaeli");
            sehirler2.Add(54, "Sakarya");
            sehirler2.Add(59, "Tekirdağ");
            sehirler2.Add(77, "Yalova");

            bool exit = true;
            string input;

            while (exit)
            {
                Console.WriteLine("Plaka Sorgulamak için 1 giriniz.");
                Console.WriteLine("Çıkış yapmak için -1 giriniz.");
                input = (Console.ReadLine());

                if (input.Equals("1"))
                {
                    Console.WriteLine("\nMarmara Bölgesi İllerinden Birinin Plaka Numarasını Giriniz: ");
                    int plaque = int.Parse(Console.ReadLine());

                    try
                    {
                        Console.WriteLine(sehirler2[plaque] + "\n");
                    }
                    catch
                    {

                        Console.WriteLine("\nHatalı Plaka Kodu Girdiniz.");
                        Console.WriteLine("Girdiğiniz Değer Marmara Bölgesine Ait Bir Plaka Numarası Değildir.\n");

                    }
                }

                if (input.Equals("-1"))
                {
                    Console.WriteLine("\nİyi günler.\n");
                    exit = false;
                    break;
                }
            }
        }
    }
}

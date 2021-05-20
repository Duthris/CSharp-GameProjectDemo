using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> numbers = new Dictionary<int,string>();
            numbers.Add(1, "One");
            numbers.Add(2, "Two");
            numbers.Add(3, "Three");

            int Num;
            bool quit = true;
            string input;
            int tempKey;
            string tempValue;
          
            while (quit)
            {
                Console.WriteLine("\nEkleme yapmak için 1 giriniz.");
                Console.WriteLine("Görüntülemek için 2 giriniz.");
                Console.WriteLine("Çıkış yapmak için -1 giriniz.");
                input = (Console.ReadLine());

                if (input.Equals("1"))
                {
                    Console.WriteLine("\nKey giriniz: ");
                    tempKey = int.Parse(Console.ReadLine());

                    Console.WriteLine("\nValue Giriniz: ");
                    tempValue = Console.ReadLine();

                    numbers.Add(tempKey, tempValue);
                }

                if (input.Equals("2"))
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        Console.WriteLine("Sayı: {0}, Yazılışı: {1}", numbers.ElementAt(i).Key, numbers.ElementAt(i).Value);
                    }
                
                }

                if (input.Equals("-1"))
                {
                    quit = false;
                    break;
                }


                    //while (quit) 
                    //{
                    //    Console.WriteLine("\nYazılışını görmek istediğiniz sayıyı giriniz: ");
                    //    Num = int.Parse(Console.ReadLine());

                    //    if (Num == -1)
                    //    {
                    //        quit = false;
                    //        break;
                    //    }

                    //    else
                    //    {
                    //        try
                    //        {
                    //            Console.WriteLine(numbers[Num]);
                    //        }
                    //        catch
                    //        {
                    //            Console.WriteLine("Sayı bulunamadı.");
                    //        }
                    //    }
            }
        }
        }
    }


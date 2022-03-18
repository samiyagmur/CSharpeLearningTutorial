using System;
using System.Collections;                  


           //string  = Console.ReadLine();
           // int number2;
           // bool success = int.TryParse(number, out number2);
           // Console.WriteLine(success);
           
namespace Koleksiyonlar_Soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste1 = new ArrayList();
            ArrayList liste2 = new ArrayList();
            int flagtr = 0;
            for (int i = 0; i < 20; i++) 
            {
                Console.Write($"Lütfen işlem yapılmasını istediğiniz {i+1}.sayıyıları giriniz: ");

                string sayi = Console.ReadLine();
                int turnTheNumber;
                bool sadeceSayi = int.TryParse(sayi, out turnTheNumber);
                while(true)
                {   
                    if(0<turnTheNumber && sadeceSayi == true)
                    { 
                        for (int j = 2; j < turnTheNumber; j++)
                        {
                            if(turnTheNumber % j == 0)
                            {
                                flagtr = 1;
                                break;
                            }
                    
                    
                        }
                        if (flagtr == 0)
                        {
                            liste1.Add(turnTheNumber);
                        }
                        else
                        {
                            liste2.Add(turnTheNumber);
                        }
                        flagtr = 0;
                        break;
                    }
                    else
                    {   Console.Write($"Lütfen karakter girişi yapmayınız.Lütfen {i+1}.sayıyı tekrar giriniz: ");
                        sayi = Console.ReadLine();
                        sadeceSayi = int.TryParse(sayi, out turnTheNumber);


                    }
                }
            }
            liste1.Add(2);
            liste1.Sort();
            liste1.Reverse();
            
            liste2.Sort();
            liste2.Reverse();
            Console.WriteLine();
            Console.Write("Asal olan sayıların büyükten küçüğe doğru sıralaması: ");
            foreach (int i in liste1)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.Write("Asal olmayan sayıların büyükten küçüğe doğru sıralaması: ");
            foreach (int i in liste2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Asal olan sayıların sayısı: ");
            Console.Write(liste1.Count);
            Console.WriteLine();
            Console.Write("Asal olmayan sayıların sayısı: ");
            Console.Write(liste2.Count);
            Console.WriteLine();
            Console.Write("Asal olan sayıların ortalaması: ");
            int toplamListe1 = 0;
            for(int i = 0; i < liste1.Count; i++)
            {
                toplamListe1 += Convert.ToInt32(liste1[i]);
            }
            Console.Write(toplamListe1 / liste1.Count);
            Console.WriteLine();
            Console.Write("Asal olmayan sayıların ortalaması: ");
            int toplamListe2 = 0;
            for (int i = 0; i < liste2.Count; i++)
            {
                toplamListe2 += Convert.ToInt32(liste2[i]);
            }
            Console.Write(toplamListe2 / liste2.Count);
        }
        
    }
}

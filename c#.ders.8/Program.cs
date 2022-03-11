using System;

namespace c_.ders._8
{
    class Program
    {
        static async void Main(string[] args)
        {   
            //Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            
            for (int i = 0 ; i < sayac; i++)
            {
                if(i%2 == 1){
                    Console.WriteLine(i);
                }
                
            }
            int tekToplam = 0;
            int ciftToplam = 0;
            for(int i = 1; i<1000;i++)
            {
                if (i%2 == 1)
                {
                    tekToplam = i + tekToplam;
                }
                else if (i%2 == 0)
                {
                    ciftToplam = i + ciftToplam;
                }
            }

            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);

        }
    }
}

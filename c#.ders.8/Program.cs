using System;

namespace c_.ders._8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            Console.WriteLine("Lütfen bir sayı giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = sayac - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }

            }
            //1 ile 1000 arasındaki tek ve çif sayıların ayrı ayrı toplamı.
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekToplam = i + tekToplam;
                }
                else if (i % 2 == 0)
                {
                    ciftToplam = i + ciftToplam;
                }
            }

            Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);

            //break,(Döngüyü sonlandırmayı sağlar)
            //continue(Bir sonraki satırı atlayarak sonraki satırların işlemesini sağlar.)

            for( int i = 1;i < 10; i++)
            {
                if(i == 4)
                        break;// i'4e eşit olduğu zaman döngüden çıkacak
                    Console.WriteLine(i);
                
               
            }
            for( int i = 1;i < 10; i++)
            {
                if(i == 4)
                        continue;// i'4e eşit olduğu zaman döngüden çıkacak
                    Console.WriteLine(i);
                
               
            }
            //for( ; ; )//Sonsuz döngü.Kullanıcıdan aldığınız bir sayının sonucunda break komutu ile kırabilirsiniz.
            {
                         
               
            }

        }
    }
}

using System;

namespace c_.ders._9
{
    class Program
    {
        static void Main(string[] args)
        {
           //while döngüleri//Consoldan girilen sayı kadar  
           int ort;
           int toplam=0;
           Console.Write("Kaç adet sayının ortalamasını almak istersiniz: ");
           int count = int.Parse(Console.ReadLine());
           int artis=1;
           while(artis<=count)
            {    
               Console.Write(artis + ".sayiyı giriniz: ");
               int sayi = int.Parse(Console.ReadLine());
               toplam = sayi + toplam;

               artis++;            
               
            }
            Console.WriteLine("Girilen " + count + " sayının ortalaması: " + (toplam/count));
            //'a' dan 'z' ye kadar tüm harfleri console a yazdır.
            char character='a';
            while(character<='z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine();
            Console.WriteLine("*****Foreach*****");
            string[] arabalar = {"BMW","TOYOTA","NİSSAN","FORD"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}

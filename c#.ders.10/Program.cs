using System;

namespace c_.ders._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanımlama

            string[] renkler = new string [5];

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};
            
            int [] dizi;

            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            //Erişim
            dizi[3] = 10;
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            
            //Döngüler dizi kullanımı
            //Klavyeden girilen n tane sayının ortalaması
            Console.Write("Ortalaması alınmasını istediğiniz sayı adedini giriniz: ");
            int n = int.Parse(Console.ReadLine());
            int [] ort = new int [n];
            
            int toplam = 0;
            for(int i=1 ; i<=n ; i++)
            {   Console.Write(i+".sayiyi giriniz: ");
                ort [i-1] = int.Parse(Console.ReadLine());
                
                
            }
            foreach (var sayi in ort)
                toplam += sayi;
            

            Console.WriteLine(n+" tane sayinin ortalamasi: "+toplam/n);



        }
    }
}

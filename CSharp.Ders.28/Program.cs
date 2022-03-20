using System;

namespace CSharp.Ders._28
{
    internal class Program
    {
        static void Main(string[] args)
        {                                        //enum//Birden fazla değeri belli olan değişkenlere aynı anda
                                                //ihtiyacımız olduğunda kodun okunabilriliğini arttığmak için enum
                                                //kullanabiliriz.
        
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if (sıcaklık <= (int)HavaDurumu.normal)//Eğer integera dönüştürürsek enum parmetrelerinin sayısal karşılığını yazdırabiliriz.
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyin");
            }
            else if (sıcaklık >= (int)HavaDurumu.sıcak)
            {
                Console.WriteLine("Dışarı çıkmak için çok sıcak bir gün");
            }
            else if (sıcaklık >= (int)HavaDurumu.normal && sıcaklık<(int)HavaDurumu.coksıcak)
            {
                Console.WriteLine("Hadi dışarıya çıkalım!");
            }
        }
    }
    enum Gunler
    {   
        Paratesi=1,

        Salı,

        Çarşamba,

        Perşembe,

        Cuma=23,

        Cumartesi,

        Pazar

    }
    enum HavaDurumu
    {
        soğuk = 5,

        normal= 20,

        sıcak = 25,

        coksıcak = 30
    }
}

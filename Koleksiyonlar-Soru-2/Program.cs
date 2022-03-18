using System;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int girilenSayilar = 7;
            int[] arr = new int[girilenSayilar];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
                int girilenSayi = Convert.ToInt32(Console.ReadLine());
                arr[i] = girilenSayi;
            }
            Console.WriteLine();
            Array.Sort(arr);
            int ilkUcOrt = IlkveSonUc(arr);
            Console.Write("Girilen en küçük üç sayının ortalaması: " + ilkUcOrt);
            Console.WriteLine();
            Array.Reverse(arr);
            int sonUcOrt = IlkveSonUc(arr);
            Console.Write("Girilen en büyük üç sayının ortalaması: " + sonUcOrt);
            Console.WriteLine();
            Console.Write("Girilen saylarının en büyüğünün ve enküçüğünün ortalamaları toplamı: " + (ilkUcOrt + sonUcOrt));

        }

        public static int IlkveSonUc(int[] number)
        {
            int toplam =0;
            for (int i = 0; i < 3; i++)
                toplam += number[i];
            int ort = toplam / 3;
            return ort;
        }
    }
}

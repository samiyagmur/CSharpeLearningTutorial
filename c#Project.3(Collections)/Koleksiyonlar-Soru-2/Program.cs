using System;

namespace Koleksiyonlar_Soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            
            int[] arr = new int[7];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Lütfen {i + 1}. sayıyı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                arr[i] = number;
            }
            Console.WriteLine();
            Array.Sort(arr);
            int firstThreeIndxAvrg = IlkveSonUc(arr);
            Console.Write("Girilen en küçük üç sayının ortalaması: " + firstThreeIndxAvrg);
            Console.WriteLine();
            Array.Reverse(arr);
            int lastThreeIndxAvrg = IlkveSonUc(arr);
            Console.Write("Girilen en büyük üç sayının ortalaması: " + lastThreeIndxAvrg);
            Console.WriteLine();
            Console.Write("Girilen saylarının en büyüğünün ve enküçüğünün ortalamaları toplamı: " + (firstThreeIndxAvrg + lastThreeIndxAvrg));

        }

        public static int IlkveSonUc(int[] number)
        {
            int sum =0;
            for (int i = 0; i < 3; i++)
                sum += number[i];
            int Avrg = sum / 3;
            return Avrg;
        }
    }
}

using System;

namespace c_ders._14
{
    class Program
    {
        static void Main(string[] args)
        {   
            //rekürsif - öz yinelemeli fonksiyonlar.
            int result = 1;
            for (int i=1 ; i<5 ; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            //Girilen sayının üstünün alınamıs//recursive fonksiyon
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3,4));
            
            //extension Methotlar
            //Giriline karakterin boşluklarının silinip yazdırılması
            string ifade = "Sami Yagmur";
            bool sonuc = ifade.CheckSpeaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }
            //Girilen karakterin Harflerinin büyütülmesi
            Console.WriteLine(ifade.UpperCaseLetter());
            //Girilen karakterin Harflerinin büyütülmesi
            Console.WriteLine(ifade.LowerCaseLetter());
            //Girilen dizinin sıralanması
            int[] dizi = {9,3,6,2,5,1,0};
            dizi.SortArray();
            dizi.EkranaYazdir();
            //Girilen sayının tekmi çiftmi denetimi
            int sayi = 5;
            bool evetmi = sayi.IsEvenNumber();
            Console.WriteLine(evetmi);
            //Girilen sayının ilk karakterinin alınması
            Console.WriteLine(ifade.FirstCharcter());
            
        }
    }
    public class Islemler
    {
        public int Expo( int sayi, int üs)
        {
            if(üs<2)
                return sayi;

            return Expo(sayi,üs-1)*sayi;
        }
        //Expe (3,4)
        //Expe (3,3) * 3
        //Expe (3,2) * 3 * 3 
        //Expe (3,1) * 3 * 3 * 3
        //3 * 3 * 3 * 3=3'4
    }
    public static class Extension
    {
        public static bool CheckSpeaces (this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi =param.Split(" ");

            return string.Join("",dizi);
        }
        public static string UpperCaseLetter(this string param)
        {
            

                return param.ToUpper();;
        }
        public static string LowerCaseLetter(this string param)
        {
            

                return param.ToLower();;
        }
        public static int[] SortArray(this int[] param)
        {
                Array.Sort(param);

                return param;
        }
        public static void EkranaYazdir(this int[] param)
        {
                foreach (int item in param)
                        Console.WriteLine(item);

                
        }

        public static bool IsEvenNumber(this int Param)
        {
            return Param % 2 == 0;
        }
        public static void EkranaYazdir1(this int param)
        {    
                        Console.WriteLine(param);
                
        }
        public static string FirstCharcter(this string param)
        {
                

                return param.Substring(0,1);
        }

    }
}

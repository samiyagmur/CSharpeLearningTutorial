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

            Islemler instance = new Islemler();
            Console.WriteLine(instance.Expo(3,4));
            
            //extension Methotlar
            string ifade = "Sami Yagmur";
            bool sonuc = ifade.CheckSpeaces();
            Console.WriteLine(sonuc);
            if(sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            Console.WriteLine(ifade.UpperCaseLetter());

            Console.WriteLine(ifade.LowerCaseLetter());
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
            string[] dizi1 = param.ToUpper();

                return dizi1;
        }
        public static string LowerCaseLetter(this string param)
        {
            string[] dizi1 = param.ToLower();

                return dizi1;
        }

    }
}

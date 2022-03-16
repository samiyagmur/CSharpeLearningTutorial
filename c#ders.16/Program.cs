using System;

namespace cSharp.ders._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSarp, Hoşgeldiniz!";
            string degisken2 = "CSharp";

            Console.WriteLine(degisken.Length);//Degişkenin boyutunu kaç karakter olduğunu ekrana yazar

            //ToUppet,ToLower
            Console.WriteLine(degisken.ToUpper());//Değişkenin harflerini büyütür
            Console.WriteLine(degisken.ToLower());//Değişkenin harflerini küçültür

            //Concat
            Console.WriteLine(string.Concat(degisken, "Merhaba!"));//Merhabayı değişkenin sonuna atarak birleştirir

            //Compare,CompareTo
            Console.WriteLine(degisken.CompareTo(degisken2));//2 değişken karakter sayılarına göre true yada false döndürür
            Console.WriteLine(String.Compare(degisken,degisken2,true));//Karşılaştırır fakat büyük küçük harf denetimi de yapar.
                                                                       //True yaparsak Bunu açmış oluruz,False yaparsak kapatmış oluruz
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains//2 değişken içerisinde arama yapar eğer aynı karakterleri bulursa true döner.
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf//Beliirttiğimiz ifadenin hangi indexte olduğunu söyler//bulamazsa -1 döner.
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("sami"));
            Console.WriteLine(degisken.LastIndexOf("i"));//Sondan başlayarak istenilen karakterinin ilkini ekrana yazdırır.
            
            //Insert//belirtilen indexten başlayarak istediğimiz karakteri ekler.
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft,PadRight//Degişken 2 sonuna 30 karakteryada kadar boşluk ekler.Değişken 2 nin karakter sayısı 30 dan küçükse hiç bişi yapmaz
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken + degisken2.PadRight(50));
            Console.WriteLine(degisken + degisken2.PadRight(50, '-'));

            //Remove//Belirtilen indexi ve indexler arasını siler
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace//Belirtilen 1. parametyi  2. parametreyle değiştir
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split//Belirttiğimiz karakterden bölerek yeni bir liste oluştur.Eğer sonuna[] belirli bir index yeni listenin o indexini ekrana yazar
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring//Belitilen indexten itibaren ekrana yazar.Bitiş endexinide belirtebilirsizni
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));





        }
    }
}

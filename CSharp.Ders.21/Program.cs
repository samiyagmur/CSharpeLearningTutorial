using System;
using System.Collections.Generic;

namespace CSharp.Ders._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            //Anahtar ve değer olarak tutarlar verileri.
            //Dizilerin elemanlara değer,İndexlerinde key diyebiliriz.
            //Compiletime'da aynı değerde 2 farklı key sıkıntı çıkarmaz ama runtimeda hata verir.
            //Çünkü hash tablosuna aynı ifadeyi 2 farklı key bölgesine atayamayız.
            //System.Collection.generic

            Dictionary<int,string> kullanıcılar = new Dictionary<int,string>();
            kullanıcılar.Add(10, "Ayşe Yılmaz");
            kullanıcılar.Add(12, "Ahmet Yılmaz");
            //kullanıcılar.Add(12, "Ahmet Yılmaz");//Aynı yükleme 2 kez yapılamaz
            kullanıcılar.Add(18, "Ayşe Yılmaz");
            kullanıcılar.Add(20, "Ahmet Yılmaz");
            //Dizinin elemanlarına erişim
            Console.WriteLine("**** Elemanlara Erişim *****");
            Console.WriteLine(kullanıcılar[12]);
            foreach(var item in kullanıcılar)
                Console.WriteLine(item);

            //Count;
            Console.WriteLine("**** Count *****");
            Console.WriteLine(kullanıcılar.Count);

            //Contains
            Console.WriteLine("**** Contains *****");
            Console.WriteLine(kullanıcılar.ContainsKey(12));
            Console.WriteLine(kullanıcılar.ContainsValue("Sami Yagmur"));
            //Remove
            Console.WriteLine("**** Remove *****");
            kullanıcılar.Remove(12);
            foreach (var item in kullanıcılar)
                Console.WriteLine(item);

            //Keys
            Console.WriteLine("**** Keys *****");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);
            //Values
            Console.WriteLine("**** Values *****");
            foreach (var item in kullanıcılar.Keys)
                Console.WriteLine(item);






        }
    }
}

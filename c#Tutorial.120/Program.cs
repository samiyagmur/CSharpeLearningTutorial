using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp.ders._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');
            //
            ////içerisinde verilere erişim
            //Console.WriteLine(liste[1]);
            //
            //foreach(int listeYazdir in liste)
            //    Console.WriteLine(listeYazdir);
            //AddRange
            Console.WriteLine("*****Add Range*****");
            //string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayılar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach(int lst in liste)
                Console.WriteLine(lst);
            //Sort//Eğer sıralama yapacaksak liste içerisinde int tipinde değişkenler var olması gerekli,
            Console.WriteLine("***** Sort *****");
            liste.Sort();//Büyükten küçüğe sıralar
            foreach (int lst in liste)
                Console.WriteLine(lst);
            //Binary Search//Bu metodu kullana bilmek için öncesinde sıralama yapmak gerekli.
            Console.WriteLine("***** Sort *****");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse//Diziyi ayanalar/Ters çevirir
            Console.WriteLine("***** reverse *****");
            liste.Reverse();
            foreach (int lst in liste)
                Console.WriteLine(lst);

            //Clear
            Console.WriteLine("***** Clear *****");
            liste.Clear();//Listeyi temizler
            foreach (int lst in liste)
                Console.WriteLine(lst);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Alfabe alfabe = new Alfabe();//metot çağırma
            Console.WriteLine("Lütfen sesli harflerini sıralamak istediğiniz satırı giriniz: ");
            string cumle = Console.ReadLine();
            foreach (string j in alfabe.AlfabeSesli())//girdiğimiz ifadeye göre sesli haftleri karşılaştırma.
            {
                if (cumle.Contains(j) == true)
                {
                    Console.WriteLine("Sırasıyla sesli harfleriniz: "+j);
                    
                }

            }
            
        }
    }   

    class Alfabe
    {   
            
        public ArrayList AlfabeSesli()
        {   
          
            
            Dictionary<string, string> harfler = new Dictionary<string, string>()//sesli harfleri tanımlayalım
            {
                { "a", "sesli"},{"e", "sesli"},
                { "ı", "sesli"},{"i", "sesli"},
                { "o", "sesli"},{"ö", "sesli"},
                { "u", "sesli"},{"ü", "sesli"}
                
            };
            ArrayList arr1 = new ArrayList();//Sesli harfleri sakşayacacağınız diziyi 
            //var sesli = new List<string>();
            foreach (var s in harfler)//sesli harfeleri diziye ekleme
            {
                arr1.Add(s.Key);
            }
            return arr1;
        }

    }
}

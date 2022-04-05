using System;
using System.Collections.Generic;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Alfabe alphabet = new Alfabe();//callTheMethod
            Console.WriteLine("Lütfen sesli harflerini sıralamak istediğiniz satırı giriniz: ");
            string sentence = Console.ReadLine();
            foreach (string j in alphabet.alfabeSesli())//Contrast vowel as my input
            {
                if (sentence.Contains(j) == true)
                {
                    Console.WriteLine("Sırasıyla sesli harfleriniz: "+j);
                    
                }

            }
            
        }
    }   

    class Alfabe
    {   
            
        public ArrayList alfabeSesli()
        {   
          
            
            Dictionary<string, string> letters = new Dictionary<string, string>()//We tell vowel to the program.cs
            {
                { "a", "sesli"},{"e", "sesli"},
                { "ı", "sesli"},{"i", "sesli"},
                { "o", "sesli"},{"ö", "sesli"},
                { "u", "sesli"},{"ü", "sesli"}
                
            };
            ArrayList arr1 = new ArrayList();//We keep them
            
            foreach (var s in letters)//We add them
            {
                arr1.Add(s.Key);
            }
            return arr1;
        }

    }
}

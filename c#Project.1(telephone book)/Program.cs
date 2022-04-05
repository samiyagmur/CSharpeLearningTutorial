﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Telefon.Rehberi.Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var regist = new Operations();
            while (true) 
            {
                Console.WriteLine("*******************************************");
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
                Console.WriteLine("(6) Rehberi kapamak");
                
                short islem=Convert.ToInt16(Console.ReadLine());

                switch (islem)
                {   
                    case 1:
                        regist.Regist();
                        break;

                    case 2:
                        regist.Remove();
                        break;

                    case 3:
                        regist.Update();
                        break;

                    case 4:
                        regist.List();
                        break;

                    case 5:
                        regist.Search();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Yalnış işlem numarası girdiniz!!!");
                        break;
                }
            }
            
        }
    }

    public class PhoneBook
    {
       
        private string name;
        private string surName;
        private string phoneNum;
        
        public string Name { get => name; set => name = value.ToUpper(); }
        public string SurName { get => surName; set => surName = value.ToUpper(); }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }


        public static List<PhoneBook> Person = new List<PhoneBook>()
        {
                new PhoneBook { Name="SAMİ", SurName="YAGMUR" ,PhoneNum= "5384786958"  },
                new PhoneBook { Name="KEMAL", SurName ="SUNAL" ,PhoneNum= "5384768214"   },
                new PhoneBook { Name="HALİT", SurName="AKÇATEPE",PhoneNum=  "5428469472" },
                new PhoneBook { Name="TARIK", SurName="AKAN",PhoneNum=  "5451649721" },
                new PhoneBook { Name="YILMAZ", SurName="GÜNEY",PhoneNum=  "5068469214" }
        };
    }    
}

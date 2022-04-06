using System;
using System.Collections.Generic;
using System.Text;

namespace Telefon.Rehberi.Uygulaması
{
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

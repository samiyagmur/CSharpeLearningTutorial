using System;
using System.Collections;
using System.Collections.Generic;

namespace Telefon.Rehberi.Uygulaması
{
    
    internal class Program
    {
        

        static void Main(string[] args)
        {


            var kayit = new Rehber();

            

            kayit.Sil();

            Console.ReadKey();

        }
    }
    public class Rehber
    {

        private string ad;
        private string soyad;
        private string numara;
        
        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public string Numara { get => numara; set => numara = value; }


        public static Dictionary<Rehber,string> Kisisler = new Dictionary<Rehber, string>()
        {
                { new Rehber { Ad="Sami", Soyad="Yagmur" }, "5384786958"  },
                { new Rehber { Ad="Kemal", Soyad ="Sunal" }, "5384768214"   },
                { new Rehber { Ad="Halit", Soyad="Akçatepe"},  "5428469472" },
                { new Rehber { Ad="Tarık", Soyad="Akan"},  "5451649721" },
                { new Rehber { Ad="Yılmaz", Soyad="Güney"},  "5068469214" }
        };

        

        public  void Kayit()
        {   
            Ad = "sezai";// Console.ReadLine();
            Soyad = "karakoc";// Console.ReadLine();
            Numara = "5456895241";// Console.ReadLine();
            var dd = Kisisler;
            dd.Add(new Rehber { Ad = Ad, Soyad = Soyad },Numara);

        }

        public void Sil()
        {

            var kisilerMuhurleme = Kisisler;
            while (true)
            {
                Ad = Console.ReadLine();
                Soyad = Console.ReadLine();

                
                foreach (var item in kisilerMuhurleme)
                {
                    kisilerMuhurleme.ContainsKey({ Ad = Ad, Soyad = Soyad });
                }

                foreach()   

                if (parametreVarmi == true)
                {
                    kisilerMuhurleme.Remove(new Rehber { Ad = Ad, Soyad = Soyad });
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("Silmeyi sonlandırmak için : (2)");
                    int islem =Convert.ToInt32(Console.ReadLine());
                    switch (islem)
                    {   
                        case 1:
                            break;
                        case 2:

                        default:
                            break;
                    }
                    
                   

                }
            }
                
        }

    }
       
}

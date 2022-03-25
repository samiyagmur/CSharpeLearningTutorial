using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Telefon.Rehberi.Uygulaması
{
    
    internal class Program
    {
        

        static void Main(string[] args)
        {


            var kayit = new Rehber();

            //kayit.Kayit();

            kayit.Sil();

            Console.ReadKey();

        }
    }
    public class Rehber
    {

        private string ad;
        private string soyad;
        private string numara;
        
        public string Ad { get => ad; set => ad = value.ToUpper(); }
        public string Soyad { get => soyad; set => soyad = value.ToUpper(); }
        public string Numara { get => numara; set => numara = value; }


        public static List<Rehber> Kisisler = new List<Rehber>()
        {
                new Rehber { Ad="SAMİ", Soyad="YAGMUR" ,Numara= "5384786958"  },
                new Rehber { Ad="KEMAL", Soyad ="SUNAL" ,Numara= "5384768214"   },
                new Rehber { Ad="HALİT", Soyad="AKÇATEPE",Numara=  "5428469472" },
                new Rehber { Ad="TARIK", Soyad="AKAN",Numara=  "5451649721" },
                new Rehber { Ad="YILMAZ", Soyad="GÜNEY",Numara=  "5068469214" }
        };

        

        public  void Kayit()
        {   
            Ad = "sezai";// Console.ReadLine();
            Soyad = "karakoc";// Console.ReadLine();
            Numara = "5456895241";// Console.ReadLine();

            Kisisler.Add(new Rehber { Ad = Ad, Soyad = Soyad, Numara= Numara });
            

        }

        public void Sil()
        {
            


            while (true)
            {
                Ad = Console.ReadLine();
                Soyad = Console.ReadLine();
                //Numara = Console.ReadLine();

                var listendeAdVarmi =Kisisler.Find(i=>i.Ad==Ad);
                var listedeSoyadVarmi = Kisisler.Find(i => i.Soyad == Soyad);
                
                bool adVarmi = Kisisler.Contains(listendeAdVarmi);
                bool soyadVarmi = Kisisler.Contains(listedeSoyadVarmi);

                if (adVarmi == true && soyadVarmi== true)
                {
                    var listedeAdVarmiIndex = Kisisler.IndexOf(listendeAdVarmi);
                    Kisisler.Remove(Kisisler[listedeAdVarmiIndex]);
                    break;
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("İşeme devam etmek için : (2)");
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

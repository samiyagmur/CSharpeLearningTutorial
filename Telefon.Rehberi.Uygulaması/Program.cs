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


            var kayit = new Rehber();

            //kayit.Kayit();

            //kayit.Sil();
            kayit.Arama();

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
                

                var listendeAdVarmi =Kisisler.Find(i=>i.Ad==Ad);
                var listedeSoyadVarmi = Kisisler.Find(i => i.Soyad == Soyad);
                
                bool adVarmi = Kisisler.Contains(listendeAdVarmi);
                bool soyadVarmi = Kisisler.Contains(listedeSoyadVarmi);

                if (adVarmi == true && soyadVarmi== true)
                {   
                    var listedeAdVarmiIndex = Kisisler.IndexOf(listendeAdVarmi);
                    Console.WriteLine($"{listedeAdVarmiIndex}isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string onay = Console.ReadLine();
                    switch (onay.ToUpper())
                    {
                        case "Y":
                            Kisisler.Remove(Kisisler[listedeAdVarmiIndex]);
                            break;
                        case "N":
                            break;
                        default:
                            break;
                    }
                    
                    
                    
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

        public void Guncelle()
        {



            while (true)
            {
                Ad = Console.ReadLine();
                Soyad = Console.ReadLine();


                var listendeAdVarmi = Kisisler.Find(i => i.Ad == Ad);
                var listedeSoyadVarmi = Kisisler.Find(i => i.Soyad == Soyad);

                if (listendeAdVarmi != null && listedeSoyadVarmi != null)
                {
                    var listedeAdVarmiIndex = Kisisler.IndexOf(listendeAdVarmi);
                    Console.WriteLine($"{listedeAdVarmiIndex}isimli kişi rehberden güncellmek üzere, onaylıyor musunuz ?(y/n)");
                    string onay = Console.ReadLine();
                    switch (onay.ToUpper())
                    {
                        case "Y":
                            Kisisler[listedeAdVarmiIndex].Numara =Console.ReadLine();
                            break;
                        case "N":
                            break;
                        default:
                            break;
                    }



                    break;

                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("İşeme devam etmek için : (2)");
                    int islem = Convert.ToInt32(Console.ReadLine());
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
        public void RehberiListele()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");



            for (int i = 0; i < Kisisler.Count; i++)
            {
                Console.WriteLine("isim:{0}",Kisisler[i].Ad);
                Console.WriteLine("Soyisim:{0}",Kisisler[i].Soyad);
                Console.WriteLine("Telefon Numarası:{0}", Kisisler[i].numara);
                Console.WriteLine("-");

            }

        }
        public void Arama()
        {
            char dd = Kisisler[0].Ad.
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**********************************************");
            Console.WriteLine("İsim ve Soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    Ad = Console.ReadLine();
                    Soyad = Console.ReadLine();

                    var listendeAdVarmi = Kisisler.Find(i => i.Ad == Ad);
                    var listedeSoyadVarmi = Kisisler.Find(i => i.Soyad == Soyad);
                    var listedeAdVarmiIndex = Kisisler.IndexOf(listendeAdVarmi);
                    var listedeSoyadVarmiIndex = Kisisler.IndexOf(listedeSoyadVarmi);

                    if (listendeAdVarmi != null && listedeSoyadVarmi != null)
                    {
                        Console.WriteLine("isim:{0}", Kisisler[listedeAdVarmiIndex].Ad);
                        Console.WriteLine("Soyisim:{0}", Kisisler[listedeAdVarmiIndex].Soyad);
                        Console.WriteLine("Telefon Numarası:{0}", Kisisler[listedeAdVarmiIndex].numara);
                        Console.WriteLine("-");

                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde yoktur.");
                    }

                    break;
                
                case 2:
                    
                    Numara = Console.ReadLine();
                    var listendeNumaraVarmi = Kisisler.Find(i => i.Numara == Numara);
                    var listedeNumaraVarmiIndex = Kisisler.IndexOf(listendeNumaraVarmi);
                    
                    if (listendeNumaraVarmi != null)
                    {
                        Console.WriteLine("isim:{0}", Kisisler[listedeNumaraVarmiIndex].Ad);
                        Console.WriteLine("Soyisim:{0}", Kisisler[listedeNumaraVarmiIndex].Soyad);
                        Console.WriteLine("Telefon Numarası:{0}", Kisisler[listedeNumaraVarmiIndex].numara);
                        Console.WriteLine("-");

                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde yoktur.");
                    }
                    


                    break;

                default:
                    break;
            }
        }

    }
       
}

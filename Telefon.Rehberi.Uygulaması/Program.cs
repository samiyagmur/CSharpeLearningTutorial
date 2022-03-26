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
                        kayit.Kayit();
                        break;

                    case 2:
                        kayit.Sil();
                        break;

                    case 3:
                        kayit.Guncelle();
                        break;

                    case 4:
                        kayit.Listele();
                        break;

                    case 5:
                        kayit.Arama();
                        break;

                    case 6:
                        return;

                    default:
                        Console.WriteLine("Yalnış işlem numarası girdiniz!!!");
                        break;
                }
            }
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
            Console.Write("Lütfen isim giriniz             :");
            Ad =Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            Soyad =Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            Numara =Console.ReadLine();

            Kisisler.Add(new Rehber { Ad = Ad, Soyad = Soyad, Numara= Numara });
            

        }

        public void Sil()
        {
            


            while (true)
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ve soyadını giriniz:");
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
                            return;
                        case "N":
                            return;
                        default:
                            Console.WriteLine("Yalnış işlem  girişi yaptınız!!!");
                            break;
                    }
                    
                    
                    
                    

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
                            return;
                        case 2:
                            break;
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
                    Console.WriteLine($"{listedeAdVarmiIndex}isimli kişinin numarasını rehberden güncellemek üzere, onaylıyor musunuz ?(y/n)");
                    string onay = Console.ReadLine();
                    switch (onay.ToUpper())
                    {
                        case "Y":
                            Kisisler[listedeAdVarmiIndex].Numara =Console.ReadLine();
                            return;
                        case "N":
                            return;
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
                            break;
                        default:
                            break;
                    }
                }
            }

        }

        public void Listele()
        {       
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");

            var lts = new List<string>();
            

            for (int i = 0; i < Kisisler.Count; i++)
            {   

                lts.Add(Kisisler[i].Ad);
 
            }
            
            lts.Sort();

            for (int j = 0; j < Kisisler.Count; j++)//Kisisler[0]=Kisisler[3]
            {
                string ff = lts[j];
                var listedeSoyadVarmi = Kisisler.Find(i => i.Ad == ff);
                var listedeAdVarmiIndex = Kisisler.IndexOf(listedeSoyadVarmi);
                var swap = Kisisler[j];
                Kisisler[j] = Kisisler[listedeAdVarmiIndex];
                Kisisler[listedeAdVarmiIndex]= swap;
            }
            
            Console.WriteLine("Liste sıralması yolunu seçiniz:A->Z için {1},Z->A için {2}");
            int islem = Convert.ToInt32(Console.ReadLine());

            switch (islem)
            {   
                case 1:
                    for (int i = 0; i < Kisisler.Count; i++)
                    {
                        Console.WriteLine("isim:{0}", Kisisler[i].Ad);
                        Console.WriteLine("Soyisim:{0}", Kisisler[i].Soyad);
                        Console.WriteLine("Telefon Numarası:{0}", Kisisler[i].numara);
                        Console.WriteLine("-");
                    }
                    break;

                case 2:
                    Kisisler.Reverse();
                    for (int i = 0; i < Kisisler.Count; i++)
                    {
                        Console.WriteLine("isim:{0}", Kisisler[i].Ad);
                        Console.WriteLine("Soyisim:{0}", Kisisler[i].Soyad);
                        Console.WriteLine("Telefon Numarası:{0}", Kisisler[i].numara);
                        Console.WriteLine("-");
                    }
                    break;
                default:
                    break;
            }
            
                   
            

        }

        public void Arama()
        {
            
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

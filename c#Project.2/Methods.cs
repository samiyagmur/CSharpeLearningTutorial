using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace toDo.Uygulamasi
{
    public class Methods: Done
    {   
        public void DegerGir()
        {   
            
            Console.WriteLine("Lütfen işlem yapmak istediğiniz kişinin kart bilgilerini giriniz.");
            Console.Write("Başlık      :");
            Baslik = Console.ReadLine();
            Console.Write("\nİçerik      :");
            Icerik = Console.ReadLine();
            Console.Write("\nAtanan Kişi :");
            AtananKisi = Console.ReadLine();
            Console.Write("\nBüyüklük    :-> XS(1),S(2),M(3),L(4),XL(5)");
            int enumdanGerit = Convert.ToInt32(Console.ReadLine());
            Buyukluk = Enum.GetName(typeof(KartBoyutları), enumdanGerit);
        }

        public void DegerGirSadeceBaslik()
        {
            Console.WriteLine("Lütfen işlem yapmak istediğiniz kişinin kart bilgilerini giriniz.");
            Console.Write("Başlık      :");
            Baslik = Console.ReadLine();

        }
        public void HataDurumu()
        {
            Console.WriteLine("Aradığınız kıriterlere uygun kart board'da bulunamamış olabilir." +
                              "Kart bilgileriniz güncelleme veya taşımak istediğiniz kartta zaten  mevcut olabilir." +
                              "Lütfen bir seçim yapınız.");
            Console.Write("* İşlemi sonlandırmak için : (1) \n" 
                             +"* Yeniden denemek için : (2) \n"
                             +"İşlem=");
            short islem = Convert.ToInt16(Console.ReadLine());
            switch (islem)
            {
                case 1:
                    return;
                case 2:
                    break;
                default:
                    Console.WriteLine("Yalnış işlem girişi yaptınız");
                    break;
            }
        }

        public short KartSecimi()
        {
            Console.Write("İşlem yapmak istediğiniz kartının başlığı giriniz:\n"
                                  + "Todo için: (1)\n"
                                  + "InProgress için: (2)\n"
                                  + "Done için: (3)\n"
                                  + "İşlem=");
            short islemHangiKart = Convert.ToInt16(Console.ReadLine());
            return islemHangiKart;
        }
        public void Ekle(List<KartBilgileri> islemYapılcakListe)
        {
            DegerGir();
            var listedeVarmi = islemYapılcakListe.Find(x => x.AtananKisi == AtananKisi);
            if (listedeVarmi == null)
            {
                islemYapılcakListe.Add(new KartBilgileri()
                {
                    Baslik = Baslik,
                    Icerik = Icerik,
                    Buyukluk = Buyukluk,
                    AtananKisi = AtananKisi
                });
            }
            else
            {
                HataDurumu();
            }

        }
        public void Sil(List<KartBilgileri> islemYapılcakListe)
        {
            DegerGirSadeceBaslik();
            var listedeVarmi = islemYapılcakListe.Find(x => x.Baslik == Baslik);
            

            if (listedeVarmi != null)
            {
                int baslikIndex = islemYapılcakListe.IndexOf(listedeVarmi);
                islemYapılcakListe.RemoveAt(baslikIndex);
            }
            else
            {
                HataDurumu();
            }

        }
        public void Guncelle(List<KartBilgileri> islemYapılcakListe)
        {
            DegerGir();
            var listedeVarmi = islemYapılcakListe.Find(x => x.Baslik == Baslik);
            
            if (listedeVarmi != null)
            {
                int baslikIndex = islemYapılcakListe.IndexOf(listedeVarmi);
                islemYapılcakListe.RemoveAt(baslikIndex);

                islemYapılcakListe.Insert(baslikIndex, new KartBilgileri()
                {
                    Baslik = Baslik,
                    Icerik = Icerik,
                    Buyukluk = Buyukluk,
                    AtananKisi = AtananKisi
                });

            }
            else
            {
                HataDurumu();
            }

        }

        public void Tasi (List<KartBilgileri> kartınBulunduguListe, List<KartBilgileri> kartınTasinacagiListe, KartBilgileri varligiBulunanListedenGelenBaslik)
        {
                
            int baslikIndex = kartınBulunduguListe.IndexOf(varligiBulunanListedenGelenBaslik);
            kartınBulunduguListe.RemoveAt(baslikIndex);
            DegerGir();
            kartınTasinacagiListe.Add( new KartBilgileri()
                {
                    Baslik = Baslik,
                    Icerik = Icerik,
                    Buyukluk = Buyukluk,
                    AtananKisi = AtananKisi
                });
           
        }
        public void Listele(List<KartBilgileri> listelenecekKart)
        {

            //for (int i = 0; i < listelenecekKart.Count; i++)
            //{
            //    listelenecekKart
            //}
            if (listelenecekKart==todo)
            {
                Console.WriteLine("TODO Line\n"
                                 + "************************");
            }
            else if (listelenecekKart==inProgress)
            {
                Console.WriteLine("IN PROGRESS Line\n"
                                 + "************************");
            }
            
            else
            {
                Console.WriteLine("DONE Line\n"
                                 + "************************");
            }
            bool flag = false;
            foreach (var item in listelenecekKart)
            {
                flag = true;
                Console.WriteLine(
                                  "Başlık      :"+item.Baslik
                                + "\nİçerik      :"+item.Icerik
                                + "\nAtanan Kişi :"+item.AtananKisi
                                + "\nBüyüklük    :"+item.Buyukluk
                                + "\n-");
                                
            }
            if (flag==false)
            {
                Console.WriteLine("~ BOŞ ~");
            }

        }

    }

}

using System;

namespace CSharp.Ders._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Static sınıf
            //Bır sınıf içerisinde statik olmayan fieldlara metotlara özelliklere o sınıftan oluşturduğunuz nesne aracı ile erişiyoruz.
            //Statik olan elemanlara o sınıfın adı ile erişilebilir.

            Console.WriteLine("Çalışan Syısı: {0}", Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayşe", "Yılmaz", "IK");
            Console.WriteLine("Çalışan Syısı: {0}", Calisan.CalisanSayisi);
            
            Calisan calisan1 = new Calisan( "Sami", "Yagmur", "IK" );
            Calisan calisan2 = new Calisan( "Zikriye", "dönmez", "IK" );
            Console.WriteLine("Çalışan Syısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));
            Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(400, 50));


            //Islemler Sınıfın üyelerine erişmeye çalıştığımızda stastic olduğu için bu sınıf fabu şekilde erişim yapılmaz.
            //Islemler ıslemler = new Islemler();


        }
    }
    //statik olmayan class lar içerisindeki nesneye özgü iken.
    //Onun içerisindeki statik olmayan üyseler,
    //o sınıfn nesnelerine özel set'leniyo ve get'leniyoken,
    //bir sınıf içerisinde statik olan üyeler sınıf bazında atanır
    class Calisan//bir sınıfı statik yaparsanız grubun tüm üyeleri static olması gerekir.
    {               
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string Isım;

        private string Soyisim;

        private string Departman;

        static Calisan() //statik kurucuların erişim belirteçleri yoktur
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim,string soyisim,string departman)//krurucuların erişim belirteçleri geri dönüş tipi yoktur.
        {
            this.Isım = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
               
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cıkar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

}

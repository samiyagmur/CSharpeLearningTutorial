using System;

namespace CSharp.ders._23
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Söz Dizimi
            //class sinifAdi
            //{
            //
            //
            //    [eriişim belirleyici] Veri tipi ozellikAdi;
            //    [Erişim belirleyici] [Geri Dönüş Tipi] metot adi(parameyre listesi)
            //    {
            //     //Metot komutları
            //    }
            //    
            //
            //}
            //sınıf üyeleri proportiler

            //Erişim belirleyiciler
            //**public 
            //**private
            //**Iternal
            //** Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 2168543;
            calisan1.Depertman = "İnsan kaynakları";

            calisan1.CalisanBilgileri();
            Console.WriteLine("**************************");
            Calisan calisan2 =new Calisan();
            calisan2.Ad = "sami";
            calisan2.Soyad = "yagmur";
            calisan2.No = 165463;
            calisan2.Depertman = "Geme development";

            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;

        public string Soyad;

        public int No;

        public string Depertman;

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı:{0}", Ad);
            Console.WriteLine($"Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine($"Çalısan Numarası:{0}", No);
            Console.WriteLine($"Çalışan Departmanı:{0}", Depertman);
        }
    }
}

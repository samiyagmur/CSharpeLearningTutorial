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
            //kurucu fonksiyon overload(aşırı yükleme)yapılabilir.
            Calisan calisan1 = new Calisan("Ayşe","Kara",543183,"İnsan kaynakları");//nesneye ayağı kaldırma işlemi
            
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
        public string Ad;//proportiler üzerinde değişiklik yapmak için kurucu metot tanımlıyourz

        public string Soyad;

        public int No;

        public string Depertman;

        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad= ad;//this bu sınıfın elemanı olduğu için kullandık
            this.Soyad= soyad;
            this.No= no;
            this.Depertman= departman;
        }
        //overload işlemi
        public Calisan() { };
        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışan Adı:{0}", Ad);
            Console.WriteLine($"Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine($"Çalısan Numarası:{0}", No);
            Console.WriteLine($"Çalışan Departmanı:{0}", Depertman);
        }
    }
}
//Kurucu metotlar:Bir sınıfın nesnesi oluşturulduğunda yani new ile yeni bir nesne oluşturulduğunuz da
////arka planda otmatik olarak çalışan metotlardır
///dolayısı ile bir nesne oluşturulduğunda otamatikmen arka planda yapılmasını istediğimiz bir nesne ayağa kalktığında
///varsa biz bunu kurucu metotlarla constracterlarla yaparız
///Bir kurucu metot sınıf isimle aynı olmak zorundandı.İsmi bulunduğu classla aynı olmak zorunda.
///kuru metotların erişim belirteçleri public olmak zorundadır
///kurucu metotların geri dönüşleri yoktur
///kuru fonsiyonların geri dönüş tipini yazmıyoruz
///birden fazla parametre alabilir yada hiç parametre almayabilir.
using System;

namespace CSharp.Ders._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 1917;
            ogrenci.Sinif = 3;
                 //.Sin dediğimzde public olan proportsine erişebiliyoruz.Onunda bir seti olduğu için erişim sağlayabiliyoruz.
            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogrenci ogrenci1 = new Ogrenci("Mahir","Ulaş",256,1);
            ogrenci.SinifDusur();
            ogrenci.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();


        }
    }



    class Ogrenci//kontrollü bir şekilde açmak için public proporty oluşturmak gerekir.ctrl+. basınız kısayolu için
    {
        private string isim;

        private string soyisim;

        private int ogrenciNo;

        private int sinif;

        public string Isim
        {
            get { return isim; }
            set { isim = value; }
        }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf En Az 1 Olabilir!");
                    sinif = 1;
                }
                else
                    sinif = value;



            }
        }
        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci()
        { }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***** Ögrenci Bilgileri *****");
            Console.WriteLine("Öğrenci Adı :{0}",this.Isim);
            Console.WriteLine("Öğrenci Soyisim :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci OgrenciNo :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci sinif :{0}", this.sinif);

        }
        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif -1 ;
        }

    } 
}
//kapsülleme nesneye yönelimli programlamanın temeli
//Erişim belirleyiceiler ile yapılır
//En kapsüle işlemi diğer kabsüllerden ve diğer nesnelerden koruma işlemidir
//Bir bölgeyi korumak için privete tanımlamak gerekityordu
//Fakat kontrollü olarak bu bölgeyi açmak istediğimizde en kapsüle işlemi ortaya çıkıyor.
//Get ve set ile oluşur.Prive değerine set veya get eden proportilerden oluşur

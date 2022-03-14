using System;

namespace c_ders._13
{
    class Program
    {
        static void Main(string[] args)//out parametre//bir fonksiyonda iş yaptırıp ve onun sonucunda bir değeri setlemek istiyorsanız ve o setlediğini kullanmak istiyorsanız bu out parameyredr
        {
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi,out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
                
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            //Method Aşırı Yükleme--Overloading

            string ifade = "sami yagmur";
            instance.EkranYazdır(ifade);
            instance.EkranYazdır("Sami ","yagmur");

            //Metot Imzası
            //metotAdı + parametre sayisi + parametre tipi
        }
    }
    class Metotlar
    {
        public void Topla(int a,int b, out int toplam)
        {
            toplam = a+b;
        }
        public void EkranYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        //Bu iki metodun aynı olması dikkat çekici!
        //işte bu durumda değişkenin hem int hemde string türünden yazdırabiliriz.
        //Bu işlem overload oluyor.
        //Peki hangigisini yazacağına nasıl karar veriyor.
        //Şu an methodu string le çağırdığımız için string parametreli methodu işletecek.Eğer int olsaydı int parametreli olan işleyecekti
        //Peki bunu yaparken nasıl bir yöntem uyguluyor.İşte bunda.Method imzası diyoruz.
        public void EkranYazdır(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranYazdır(string veri1,string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
        
    }
}

using System;

namespace c_ders._12
{
    class Program
    {
        static void Main(string[] args)//metotlar
        {
            //erişim_belirteci geri_donuştipi metot_adi(paramatereListesi/argumanlar)
            // {
            //     ///komutlar
            // }

            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);
            
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);
            
            metotlar ornek = new metotlar();
            ornek.EkranaYazdir(sonuc.ToString());
            
            
            
            
            int sonuc2 = ornek.ArttırVeTopla(ref a,ref b);//Fonksiyonun referans almak o değişkenin var olduğu adresin yerini belirtiyo olmaktır.Değişken main fonsiyonu tarafından çağırıladığında direk adresten değer dönecektir.
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir((a+b).ToString());
        }
    
        static int Topla(int deger1, int deger2)//Başlangıç//
        {
            return (deger1+deger2);
        }




    }
    class metotlar
    {
        public void EkranaYazdir(string veri)//Başlangıçta bu veri prive olarak gelir.
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1+deger2;
        }
    }
}

using System;

namespace CSharp.Ders._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sınıflar referans türündedir.struct değer tipindedir
            Dikdortgen dikdortgen = new Dikdortgen();
            //dikdortgen.KisaKenar = 3;
            //dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı  :{0}", dikdortgen.AlanHesapla());
            //Classlardaki fieldlara değer atamadığımız taktirde başlangıç(initial,int= 0,bool=false vb.) atamsı vardır.
            //Dikdortgen_Struct dikdortgen_struct;//bu şekildede tanımlama yapabiliriz
            //Fakat struct fieldlara başlangıç (initial) atama yapmaz.Eğer bir üst satırdaki gibi tanımlama yaparsak.
            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct(3,4);
            //dikdortgen_struct.KisaKenar = 3;//initial ataması yapmadoığı için bu başlangıç atamalrını yapmalıyız.
            //dikdortgen_struct.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı  :{0}", dikdortgen.AlanHesapla());
            //classlar yavaş ve heap bölgesinde//structlar hızlı ve stack bölgesinde.
            //16 byte kadar olan veriler için struck kullanmak daha doğru iken
            //16 byte üzeri verilerde class sınıfını kullanmak daha doğrudur
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;

        public int UzunKenar;

        public Dikdortgen()
        {
            KisaKenar = 3;
            UzunKenar = 4;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }

    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;

        public int UzunKenar;

        //public Dikdortgen()//parametresi olmadan tanımlama yapılmaz.
        //{
           //KisaKenar = 3;
            //UzunKenar = 4;
        //}

        public Dikdortgen_Struct(int kisaKenar,int uzunKenar)//parametresi olmadan tanımlama yapılmaz.
        {
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }

    }
}


//yapıların özellikleri:
//
//
//
//class lar referans tipli özellikler gösterir, yapılar ise değer tipli özellikler gösterirler. en temel fark budur.
//diğer struct yada sınıflardan kalıtım almazlar.
//ınterface'lerden kalıtım alabilirler.
//new anahtar sözcüğü ile nesneleri yaratılabilir.
//sınıflar gibi metot, property ve field'lardan oluşurlar.
//sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
//static üye barındırabilirler.

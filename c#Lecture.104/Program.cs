using System;

namespace c_.ders._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Implicit Conversion *****");
            //pc otomatik olarak çevrimi yapıyor.
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;              //a,b,c değişkenlerinin hafızada int kdar yer kaplamaz türleri int türünün kapasitesinden daha küçük
            Console.WriteLine("d1:"+d); //Bu yüzden int kaplayacağı toplam yer kadar bu değişkenlerden tanımlanabilir.
                                        //Bu tür dönüşümünü pc otomatikmen yapar.
            long h = d;
            Console.WriteLine("h1:"+h);

            float i = h;
            Console.WriteLine("i1:"+i);

            string e = "sami";
            char f = 'k';
            object g= e+f+d;            //tüp veri tipleri objectten türemiştir.
            Console.WriteLine("g1"+g);
            
            //Explicit Conversion
            //parse,convert,tostring() komutları ile yapılır.

            Console.WriteLine("*****Explicit Conversion*****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);
            
            //*** ToString Methodu
            Console.WriteLine("*****ToString Methodu*****");

            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            //System.convert
            Console.WriteLine("*****System Convert*****");
            string s1 ="10", s2="20";
            int sayi1,sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            //Parse            
            Console.WriteLine("*****Parse Methodu*****");
            ParseMethod();

        }
    
        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            Console.WriteLine("rakam1 :"+rakam1);
            Console.WriteLine("double1 :"+double1);

            

        }
    }
}

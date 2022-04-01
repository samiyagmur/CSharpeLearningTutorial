using System;

namespace c_.ders._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Atama Ve islemli Operatorler*****");
            // Atama Ve islemli atama(=, +=, -=, *=, /=)
            int x = 3;
            int y = 3;
            y = y+2;
            Console.WriteLine(y);//5
            y += 2;//işlemli atama
            Console.WriteLine(y);//7
            y /= 1;
            Console.WriteLine(y);//7
            x *= 2;
            Console.WriteLine(x);//6
            Console.WriteLine("*****Mantiksal Operatorler*****");
            //mantıksal Operatörler
            //||, &&, !
             bool isSuccell = true;
            bool isCompleted = false;

            if(isSuccell && isCompleted)// bu koşul sağlanmadığı için alttaki komutu çalıştırmadı
            Console.WriteLine("Perfect!");

            if(isSuccell || isCompleted)
            Console.WriteLine("Great!");//Great!

            if(isSuccell && !isCompleted)
            Console.WriteLine("Fine!");//Fine!

            Console.WriteLine("*****iliskisel Operatorler*****");
            //İlişkisel Operatörler (==,!=, <, >, >=,<=)
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);//1
            
            sonuc = a>b;
            Console.WriteLine(sonuc);//0
           
            sonuc = a>=b;
            Console.WriteLine(sonuc);//0
           
            sonuc = a<=b;
            Console.WriteLine(sonuc);//1
           
            sonuc = a==b;
            Console.WriteLine(sonuc);//0
           
            sonuc = a!=b;
            Console.WriteLine(sonuc);//1

            Console.WriteLine("*****Aritmetik Oporatörler*****");
            //Aritmetik Oporatörler (+, -, *, /, %, ++, --)

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);//2
            
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);//50
            
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);//15
            
            sonuc1 = sayi1++ ;
            Console.WriteLine(sonuc1);//11

            //% mod oporatörü

            int sonuc2= 20%3;
            Console.WriteLine(sonuc2);//2 

        }
    }
}

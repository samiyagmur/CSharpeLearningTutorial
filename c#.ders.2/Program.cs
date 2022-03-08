using System;

namespace ders._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int deger;//Bir değer atamadan kullanırsak hata alırız.
            //deger = 2;//şeklinde atama yapmamız gerekir
            //string degisken = null;//verebileceğimiz bir değer yoksa null atayabiliriz.
            //string degisken = null;//birden fazla tanımlama yapılmaz
            //string Degisken = null;//Değişkenler büyük küçük harfe duyarladır.
            //string 3degisken = null;//numara ile başlayamaz.
            //string class = "";//özel isimlele kullanılamaz
            //string degisken + veri = null;//+ - boşluk gibi işlem oprptoru kullanılamaz.yalnızca "_" kullanabilrisin
            //string degis = " ";//if üzerinde true döndermesi için 
            //if(degis = "")//boşluk bırakmak gerekli
            //byte b = 5;     //0-255 arasındaki değer alır/1 byte yer kaplar
            //sbyte c = 5;    //-128-+127 arasında değer alır/1 byte yer kaplar
            //short s = 5;    //2byte yer kaplar/-32768-+32768 arasında değer alır
            //ushort us = 5;  //2 byte yer kaplar/0-65365 arasında değer kaplar
            //Int16 i16 = 2;  //2 byte yer kaplar/
            //int i = 2;      //4 byte yer kaplar//-2147483648-+2147483648 arasında yer kapalar
            //Int32 i32 = 2;  //4 byte yer kaplar//ihtiyaç duyuldurğunda alacağı değerler searc edilebilir.
            //Int64 i64 = 2;  //8 byte yer kaplar
            //uint ui = 4;    //4byte yer kaplar
            //long l = 8;     //8 byte yer kaplar
            //ulong ul = 8;   //8 byte yer kaplar
            //reel sayılar için
            //float f = 3.1;  
            //double d = 5;   //8 byte yer kaplar
            //decimal de = 16; //16 byte yer kaplar
            //karakter
            //char ch = '2';   //2 byte yer kaplar
            //string str = "sami";   //sınırsız

            //bool b1 = true;  //evet yada hayır alır
            //bool b2 = false;
            //DateTime dt = DateTime.Now;
        
        
            //Console.WriteLine(dt);
            
            //object o1 = "x";//her türlü veriyi tutabilir.
            //object o2 = "y";
            //object o3 = 4;
            //object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "yagmur";
            string ad = "sami";
            string soyad = "yagmur";
            string tamisim = ad + " " + soyad;

            //integer Tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1*integer2;

            //bool u1 = 10<2;//false gelcek

            //Değişken dönüşümleri
            string str20 = "20";
            int int20 = 20;

            string yenideger = str20 + int20.ToString();//Bu yöntemle int türünü dönüşümünü yaptık.

            Console.WriteLine(yenideger);// 2020

            int int21 = int20 + Convert.ToInt32(str20);

            Console.WriteLine(int21);//40

            int int22= int20 +int.Parse(str20);//tür dönüşümü bu yöntemlede değişir
                                            //Bu yöntem sadece string için geçerlidir.
            Console.WriteLine(int21);//40

            //datetimes

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);//08.03.2022
            string datetime1 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime1);//08/03/2022

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);//16:07
            
        }
    }
}



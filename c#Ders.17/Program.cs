using System;

namespace cSharp.Ders._17
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Dateteme ve Math hotlar
            Console.WriteLine(DateTime.Now);//Günün tarihi
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());//Gün ay ve yıl//Ayı ve yılı string ve number formatında getirir.
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            //now yerine herhangi bir datetaime ifadesini kullanabiliriz.
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            //Datime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); //17
            Console.WriteLine(DateTime.Now.ToString("ddd"));//Per
            Console.WriteLine(DateTime.Now.ToString("dddd"));//Perşembe

            Console.WriteLine(DateTime.Now.ToString("MM")); //03
            Console.WriteLine(DateTime.Now.ToString("MMM"));//Mar
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//Mart

            Console.WriteLine(DateTime.Now.ToString("yy")); //22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022
            Console.WriteLine("****Math Kütüphanesi****");
            //Math Kütüphanesi//Fiziksel hesapları için gerekli olacaktır.
            Console.WriteLine(Math.Abs(-25));//Mutlak değer alır
            Console.WriteLine(Math.Sin(10));//Sin alır
            Console.WriteLine(Math.Cos(10));//Cos alır
            Console.WriteLine(Math.Tan(10));//Tan alır

            Console.WriteLine(Math.Ceiling(22.3));//Büyük tam sayıya yuvarlar
            Console.WriteLine(Math.Round(22.3));//Kendisinden büyük yada küçük tam sayıylardan hangisine yakınsa ona yuvarlar
            Console.WriteLine(Math.Floor(22.7));//

            Console.WriteLine(Math.Min(2, 6));// hangisi büyükse onu getirir.
            Console.WriteLine(Math.Max(2, 6));

            Console.WriteLine(Math.Pow(3, 4));//3^4 ü verir.=81
            Console.WriteLine(Math.Sqrt(4));//Karakök hesabı yapar
            Console.WriteLine(Math.Log(9));//ln 9 getir.
            Console.WriteLine(Math.Exp(3));//e^3 ü verir.
            Console.WriteLine(Math.Log10(10));//10 sayısının logaritma 10 tabanindeki değeri=1 veriri
        }
    }
}

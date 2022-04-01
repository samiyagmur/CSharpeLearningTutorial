using System;

namespace c_.ders._6
{
    class Program
    {
        static void Main(string[] args)//İf else yapıları
        {
            int time =DateTime.Now.Hour;
            if(time >=6 && time < 11)
            {
                Console.WriteLine("Günaydın");
            }
            else if(time <= 18)
            {
                Console.WriteLine("İyi Günler!");
            }
            else
            {
                Console.WriteLine("İyi Geceler!");
            }
            //Daha küçük koşul yapıları için altaki şekilde yazdırlması daha doğrudur.
            //Aksi takitrde yataya doğru ilerleyeceği için okunabilirliği azalacaktır.
            string sonuc = time <= 18 ? "İyi Günler!" : "İyi Geceler!";

            sonuc = (time >= 6) && (time < 11) ? "Günaydın" : time <= 18 ? "İyi Gümnler!" : "İyi Geceler!";

            Console.WriteLine(sonuc);
        }
    }
}

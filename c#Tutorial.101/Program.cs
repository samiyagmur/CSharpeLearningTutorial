using System;//System çağırılmadığı taktirde(using ile).gireceğimiz komutların çalışabilmesi için Manuel olarak çağırmamız gerekir.
            //Bu durumuda anlıyoruzki Systemde aslında bir pc'nin biyerlerinde gizli ve public edilmiş bir namespacetir.

namespace myproject//.net veri kütüphanesi deki komutları kullanabilmek için,
{                   //aynı zamanda aynı amaca hizmet eden komut,verilerin bulunduğu çatıya namespace denir.Using system'a bağlı çalışır./
                    //Burdan şu sonucu çukarabiliriz ki;Bir namespace kullanmak için.  "namecpaceismi.systemkomutu"Şeklinde çalıştırabiliriz.
    class Program//Benzer bir değişkenin verilerini,parametrelerini ve metotlarını sakladığımız ve bunları ana fonksiyon için kullanışlı hale getiren komut dizinidir.
                //başka projede yazdığımız verilerini,parametrelerini ve metotlarını kullanırken bir obje oluşturup o obje işlemi üzerinden çağırarak üzerinde işlem yapabiliriz.
                //Aynı işi yapan farklı kodcuların olduğunu düşünürsek.Bir kitabın içindeki bir bilgiyi alıp istediğimiz şekilde kullanmaya benzer.Fakat kitaptaki bilgi sabit kalır.
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyisminizi giriniz:");
            string soyisim = Console.ReadLine();
            Console.WriteLine("C# programlamaya hos geldin " + name + " " + soyisim);


        }
    }
}
//public:genel olarak tüm alanlara açık,her yerden ulaşılabilir demektedir.public ettiğiniz veriyi,kodu,methodu başka bir projeden dahi çağırabilirsiniz.
//Private:Sadece o sınıf içerisinde erişilebilir.Genel olarak korunması gereken verileri bu şekilde tutarız
//Protected:Bulunduğu sınıftan üretilen sınıflarda kullanılabilir.
//İnternal :Aynı program içerisindeki sınıflardan erişilebilir. 
//C# Dilinde Metotlar
//[Erişim belirleyici] [Dönen değerin türü] [Metotun adı] ([Metota gönderilen değişkenler ve türleri])
//Void: Komut işlemi sonrasında bir değer döndürmüyorusak bu türü kullanırız.
//Eğer: bir değer döndürüyorsak(İnt,string) bu türü kullanırız.Return kullanmak zorundayız.
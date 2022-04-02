using System;

namespace c_.ders._5
{
    class Program
    {
        static void Main(string[] args)
        {   //Hata yönetimi//
           //hatalar 2 ye ayrılır
           //compaile time hatalar siz kodu yazarken derleyicinin verdiği hatalar.
           //run time hatası yakalıyo olamak gerekir
           
           //try                   //Hata almadan çalışma koşulunda işleyecek kod satırı.
           //{
            
            //Console.WriteLine("Bir Sayi giriniz:");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Girmiş olduğunuz sayi:"+sayi);
               
           //}
           //catch (Exception ex)  //Hata aldığı taktirde çalıştıracağı kod satırı.
           //{
             //  Console.WriteLine("Hata: "+ ex.Message.ToString());             
           //}
        //    finally               //Her halükarda işleyecek kod.//finally isteğe bağlı eklenebilir.
        //    {
        //        Console.Write("İşlem tamamlandi."); 

        //    }
            
            try
            {
                //int a = int.Parse( );
                //int a = int.Parse("test");
                //int a = int.Parse("-20000000000");
                int x;
                int y;
                x=8;
                y=0;
                int z = x/y;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex);    

            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer giriniz.");
                Console.WriteLine(ex);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("İşlem 0 a bölünemez");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("İşlem başarılı");
                              
            }
        }
    }
}

//ArgumentException	Bir yönteme geçirilen null olmayan bağımsız değişken geçersizdir.
//ArgumentNullException	Bir yönteme geçirilen bağımsız değişken şu null şekildedir: .
//ArgumentOutOfRangeException	Bağımsız değişken, geçerli değer aralığının dışındadır.
//DirectoryNotFoundException	Dizin yolunun bir bölümü geçerli değil.
//DivideByZeroException	Bir tamsayı veya bölme işlemi içinde Decimal payda sıfırdır.
//DriveNotFoundException	Sürücü kullanılamıyor veya mevcut değil.
//FileNotFoundException	Bir dosya yok.
//FormatException	Değer, gibi bir dönüştürme yöntemi tarafından bir dizeden dönüştürülecek uygun biçimde Parse değildir.
//IndexOutOfRangeException	Dizin, bir dizinin veya koleksiyonun sınırlarının dışındadır.
//InvalidOperationException	Yöntem çağrısı bir nesnenin geçerli durumda geçersizdir.
//KeyNotFoundException	Koleksiyonda bir üyeye erişmek için belirtilen anahtar bulunamıyor.
//NotImplementedException	Yöntem veya işlem uygulanmaz.
//NotSupportedException	Yöntem veya işlem desteklenmiyor.
//ObjectDisposedException	Bir işlem, atıldı bir nesne üzerinde gerçekleştirilir.
//OverflowException	Aritmetik, tür dönüştürme veya dönüştürme işlemi taşma ile sonuç verir.
//PathTooLongException	Yol veya dosya adı, sistem tanımlı uzunluk üst sınırını aşıyor.
//PlatformNotSupportedException	İşlem geçerli platformda desteklenmiyor.
//RankException	Yanlış sayıda boyuta sahip bir dizi bir yönteme geçirildi.
//TimeoutException	Bir işlem için gereken zaman aralığının süresi doldu.
//UriFormatException	Geçersiz bir Tekdüzi Kaynak Tanımlayıcısı (URI) kullanılır.

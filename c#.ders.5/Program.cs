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

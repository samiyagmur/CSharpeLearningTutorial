using System;

namespace c_ders._13
{
    class Program
    {
        static void Main(string[] args)//out parametre//bir fonksiyonda iş yaptırıp ve onun sonucunda bir değeri setlemek istiyorsanız ve o setlediğini kullanmak istiyorsanız bu out parameyredr
        {
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi,out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
                
            }


        }
    }
}

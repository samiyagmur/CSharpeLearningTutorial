//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
//Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.


using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!Cevapları denemek için Ayırım noktalarını dikkate alınız!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            Method instance = new Method();
            //1.soru cevabı

            //string param = "n";
            //
            //int n = instance.wrteScrn(param);
            //
            //int [] dizi =instance.wrteScrnArr(n);
            //foreach(int cift in dizi)
            //{
            //    if(cift % 2 == 0)
            //    {
            //        Console.Write(cift + " ");
            //    }
            //}


            //2. soru cevabı

            //int n = instance.wrteScr_n();
            //int m = instance.wrteScr_m();
            //int[] dizi = instance.wrteScrnArr(n);
            //foreach (int equltyordividing in dizi)
            //{   
            //    if ( (m == equltyordividing) || (m% equltyordividing == 0) )
            //    {
            //        Console.Write(equltyordividing + " ");
            //    }
            //    
            //}

            //3. soru cevabı

            //int n = instance.wrteScr_n();
            //List<string> lst = new List<string>();
            //
            //for (int k = 0; k < n; k++)
            //{
            //    string chr = instance.wrteScr_s(k+1);
            //    lst.Add(chr);
            //}
            //lst.Reverse();
            //foreach(string str in lst)
            //{
            //    Console.Write(str+" ");
            //}

            //4. soru cevabı
            //string word = instance.wrteScr_s("ilk");
            //int wordCount = word.Length;
            //Console.Write ("wordCount: "+wordCount);

        }

        
    }

    public class Method
    {
       //Bir n sayı girme methodu
        public int wrteScr_n()
        {   
            
            Console.Write("Lütfen pozitif n sayısını giriniz: ");
            int n= Convert.ToInt32(Console.ReadLine());
            
                return n;
        }
        // m sayı girme methodu//Yazım içine m veya n yazabilmek için ayrı fonksiyonla çağırdım
        public int wrteScr_m()
        {

            Console.Write("Lütfen pozitif m sayısını giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            return m;
        }
        //n sayısını karşılaştırmaya sokmak için arrayden yararlandım
        public int[] wrteScrnArr(int deger)
        {

            int[] arry = new int[deger];
            for (int i = 0; i < deger; i++)
            {   Console.Write((i+1)+".n sayısını giriniz:"); 
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arry;

        }
        //List yöntemi ile string ifadeleri yazdırabilmek için string fonksiyonu yazdım

        public string wrteScr_s(int count)
        {
            
            Console.Write("Lütfen "+ count+" kelime/cümleyi giriniz: ");
            string lste = Console.ReadLine();
            

            return lste;
        }
        ///3. ve 4. sorularda Overloading göstermek amacı ile başka fonksiyon tanımladım.
        public string wrteScr_s(string count)
        {

            Console.Write("Lütfen " + count + " kelime/cümleyi giriniz: ");
            string lste = Console.ReadLine();


            return lste;
        }
    }

}

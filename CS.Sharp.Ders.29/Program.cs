using System;

namespace CS.Sharp.Ders._29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //                                 Canlılar

            //                 Bitkiler                        Hayvanlar

            //         Tohumlu         Tohumsuz        Sürüngenler      Kuslar
            //Hayatta var olan herşeyi programlayabilmek için nesneye dayalı programlama gelişmiştir.
            //Nesneye dayalı programlama soyut yada somut tüm şeylerin algoritmalar ile sanal düzleme entegre edilmesindeki izlenen yoldur.
            //Neneyi oluştururken onun Tüm parçaları veya tüm özellikleri bla bla gibi o nesnenin alt kümesini oluşturacak her şey ile sınıflandırabiliriz.
            //Bu sınıflandırma biçimine Kalıtım diyebiliriz.
            //Kalıtımda nesneyi daha küçük alt kümelere bölüm sorunun çözümünü okunabilir ve basit bir kodlar bütünü haline getirmektir.
            //oluşturduğumuz 3 nesne arasında kalıtımın bağını oluşturuna ":Bağ kurmak istediğimiz sınıf" şeklindedir.
            //Public olarak tanımladığımız tüm sınıfların tüm metolarını protected olarak değiştirdiğimizde
            //Aradaki bağın kopmaması için "base.metot adı" şeklinde bağlantıyı tekrar oluşturarak.Hem kalıtımı ettirir,kalıtım üyelerini kurur ve ana fonkiyonda daha az kod bloğu ile daha çok iş yapmış oluruz.
            //Buna bağlı olarak kodun okunabilirliğide artmış olur.
            
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            
            //tohumluBitki.Beslenme();
            //tohumluBitki.Solunum();
            //tohumluBitki.Boşaltım();
            //tohumluBitki.Fotosentez();
            tohumluBitki.TohumlaCogalma();
            Console.WriteLine("****************************");
            Kuslar martı = new Kuslar();
            //martı.Beslenme();
            //martı.Solunum();
            //martı.Adaptasyon();
            martı.Ucmak();
            //martı.Boşaltım();

        }
    }
}

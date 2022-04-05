using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace toDo.Uygulamasi
{
    public class KartBilgileri:Program
    {
        private string title;
        private string scope;
        private string size;
        private string member;


        public string Title { get => title; set => title = value; }

        public string Scope { get => scope; set => scope = value; }

        public string Size { get => size; set => size = value; }
        public string Member { get => member; set => member = value; }

        public static List<KartBilgileri> todo = new List<KartBilgileri>()
        {
            new KartBilgileri() {Title="Bozkart",Scope="Otobüs Kartı",Size="xL",Member="Sami Yagmur"}
        };

        public static List<KartBilgileri> inProgress = new List<KartBilgileri>()
        {
            new KartBilgileri() {Title="Ankart",Scope="Otobüs Kartı",Size="xL",Member="Fırat Kaya"}
        };

        public static List<KartBilgileri> done = new List<KartBilgileri>()
        {
            new KartBilgileri() {Title="Denkart",Scope="Otobüs Kartı",Size="xL",Member="Yılmaz Sağlam"}
        };

        public enum KartBoyutları
        {
            XS=1,
            S,
            M,
            L,
            X,
            XL

        }

    }
}

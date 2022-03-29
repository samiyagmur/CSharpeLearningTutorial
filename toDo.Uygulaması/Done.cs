using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace toDo.Uygulamasi
{
    public class Done: InProgress
    {
        public static List<KartBilgileri> done = new List<KartBilgileri>()
        {
            new KartBilgileri() {Baslik="Denkart",Icerik="Otobüs Kartı",Buyukluk="xL",AtananKisi="Yılmaz Sağlam"}

        };

    }
}

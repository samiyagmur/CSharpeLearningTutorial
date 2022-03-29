using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace toDo.Uygulamasi
{   

    public class InProgress: toDoo
    {
        public static List<KartBilgileri> inProgress = new List<KartBilgileri>()
        {
            new KartBilgileri() {Baslik="Ankart",Icerik="Otobüs Kartı",Buyukluk="xL",AtananKisi="Fırat Kaya"}

        };

    }
}

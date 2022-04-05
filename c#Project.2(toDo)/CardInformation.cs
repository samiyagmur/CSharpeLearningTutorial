using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace ToDo.App
{
    public class CardInformation:Program
    {
        private string title;
        private string scope;
        private string size;
        private string member;


        public string Title { get => title; set => title = value; }

        public string Scope { get => scope; set => scope = value; }

        public string Size { get => size; set => size = value; }
        public string Member { get => member; set => member = value; }

        public static List<CardInformation> todo = new List<CardInformation>()
        {
            new CardInformation() {Title="Bozkart",Scope="Otobüs Kartı",Size="xL",Member="Sami Yagmur"}
        };

        public static List<CardInformation> inProgress = new List<CardInformation>()
        {
            new CardInformation() {Title="Ankart",Scope="Otobüs Kartı",Size="xL",Member="Fırat Kaya"}
        };

        public static List<CardInformation> done = new List<CardInformation>()
        {
            new CardInformation() {Title="Denkart",Scope="Otobüs Kartı",Size="xL",Member="Yılmaz Sağlam"}
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

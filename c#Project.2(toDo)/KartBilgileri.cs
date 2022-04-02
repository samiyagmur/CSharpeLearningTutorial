using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
namespace toDo.Uygulamasi
{
    public class KartBilgileri:Program
    {
        private string baslik;
        private string icerik;
        private string buyukluk;
        private string atananKisi;


        public string Baslik { get => baslik; set => baslik = value; }

        public string Icerik { get => icerik; set => icerik = value; }

        public string Buyukluk { get => buyukluk; set => buyukluk = value; }
        public string AtananKisi { get => atananKisi; set => atananKisi = value; }

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

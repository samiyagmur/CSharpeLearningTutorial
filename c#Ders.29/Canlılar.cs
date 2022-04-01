using System;
using System.Collections.Generic;
using System.Text;

namespace CS.Sharp.Ders._29
{
    public sealed class Canlılar//sealed kalıtımın önüne geçer
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar Solunum yapar");
        }
        protected void Boşaltım()
        {
            Console.WriteLine("Canlılar Boşaltım Yapar.");
        }

        public virtual void UyarılaraTepki() 
        {
            Console.WriteLine("Canlılar uyarılara tepki verir.");
        }

    }
}
